using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MySql.Data.MySqlClient;

namespace WeatherStation
{
    public partial class Form1 : Form
    {
        //Fields for access API.cs
        private Api _api;
        private dynamic _data;

        //Fields for Database connection
        private MySqlConnection _conn;
        private const string MyConnectionString = "server=127.0.0.1;uid=root;pwd=;database=weatherstation;";

        //Lock timer interval form running code
        private bool _locked;
        public Form1()
        {
            //Splash screen
            Thread t = new Thread(new ThreadStart(SplashStart));
            t.Start();

            Thread.Sleep(5000);

            InitializeComponent();

            t.Abort();

            //initialse Api
            _api = new Api();

            //hide input error labels
            lblErrorInterval.Visible = false;
            lblErrorPlace.Visible = false;

            //Set inteval time
            interval.Interval = Properties.Settings.Default.Interval;

            //checks right radiobutton
            if (Properties.Settings.Default.Units == "metric")
            {
                rdCelcius.Checked = true;
            }
            else
            {
                rdiFahrenheit.Checked = true;
            }

            txtbCity.Text = Properties.Settings.Default.City;
            txtbInterval.Text = (Properties.Settings.Default.Interval / 1000).ToString();

            //Get current weather
            InsertData();
        }

        public void SplashStart()
        {
            Application.Run(new splash());
        }

        /// <summary>
        /// Gets the current weather data.
        /// </summary>
        public void GetWeather()
        {
            //Call api
            _data = _api.ApiCall(null);

            //Get labels text from API
            city.Text = (string)_data["name"];
            clouds.Text = (string)_data["weather"][0]["description"];
            air.Text = (string)_data["main"]["humidity"] + "%";

            //Raw Values Temperture
            double tempRaw = (double)_data["main"]["temp"];
            double minTempRaw = (double)_data["main"]["temp_min"];
            double maxTempRaw = (double)_data["main"]["temp_max"];

            //Check if metric or imperial
            if (Properties.Settings.Default.Units == "metric")
            {
                temp.Text = Math.Round(tempRaw, 1) +"°C";
                minTemp.Text = Math.Round(minTempRaw, 1) + "°C";
                maxTemp.Text = Math.Round(maxTempRaw, 1) + "°C";
            }
            else
            {
                temp.Text = Math.Round(tempRaw, 1) + "°F";
                minTemp.Text = Math.Round(minTempRaw, 1) + "°F";
                maxTemp.Text = Math.Round(maxTempRaw, 1) + "°F";
            }    

            //Get icon string from API and post Image
            string iconString = _data["weather"][0]["icon"];
            icon.ImageLocation = "http://openweathermap.org/img/w/" + iconString + ".png";

            //Get and Set update time
            DateTime date = DateTime.Now;
            update.Text = date.ToString("dd/MM/yyyy H:mm:ss");
        }

        /// <summary>
        /// Update GUI to latest data, user can set this in options
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void interval_Tick(object sender, EventArgs e)
        {
            if (!_locked)
            {
                //Get current weather at tick
                GetWeather();
            }
        }

        /// <summary>
        /// Button click to save changes to the settings of the program: City, Interval and Units
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void opslaan_Click(object sender, EventArgs e)
        {
            //Fields neccery voor error checking
            Boolean error = false;
            Boolean celcius;
            int i;

            //Clear errors
            lblErrorPlace.Visible = false;
            lblErrorInterval.Visible = false;

            //checks if not empty or any numbers
            if (String.IsNullOrWhiteSpace(txtbCity.Text))
            {
                lblErrorPlace.Text = "Vul een plaats in";
                lblErrorPlace.Visible = true;
                error = true;
            } else if(int.TryParse(txtbCity.Text, out i))
            {
                lblErrorPlace.Text = "Vul een plaats in";
                lblErrorPlace.Visible = true;
                error = true;
            }

            //checks if not empty and numbers are used
            if (String.IsNullOrWhiteSpace(txtbInterval.Text))
            {
                lblErrorInterval.Text = "Vul een aantal seconden in";
                lblErrorInterval.Visible = true;
                error = true;
            } else if (!int.TryParse(txtbInterval.Text, out i))
            {
                lblErrorInterval.Text = "Alleen cijfers gebruiken";
                lblErrorInterval.Visible = true;
                error = true;
            }

            //checks if celcius is true or false
            if (rdCelcius != null && rdCelcius.Checked)
            {
                celcius = true;
            }
            else
            {
                celcius = false;
            }

            //No errors? Then save new values and reload weather actual
            if (error == false)
            {
                ChangeOptions(txtbCity.Text, celcius, int.Parse(txtbInterval.Text));
                GetWeather();
            }
        }

        /// <summary>
        /// Saves the properties of the program
        /// </summary>
        /// <param name="location">Sets the city</param>
        /// <param name="metric">Sets the unit: Metric or Imperial</param>
        /// <param name="seconds">Sets the interval timer</param>
        public void ChangeOptions(string location, Boolean metric, int? seconds)
        {
           _data = _api.ApiCall(location);

            //change location if not null
            if (location != null)
            {
                location = (string)_data["name"];
                txtbCity.Text = location;
                Properties.Settings.Default.City = location;
                Properties.Settings.Default.Save();
            }
            //Radio buttons handeling
            if (metric == false)
            {
                Properties.Settings.Default.Units = "imperial";
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.Units = "metric";
                Properties.Settings.Default.Save();
            }
            //Set interval timer
            if (seconds != null)
            {
                seconds = (int)seconds * 1000;
                interval.Interval = (int)seconds;
                Properties.Settings.Default.Interval = (int)seconds;
                Properties.Settings.Default.Save();
            }
        }

        /// <summary>
        /// Open database connection
        /// </summary>
        private void DatabaseConection()
        { 
           try
            {
                //Open connection
                _conn = new MySqlConnection {ConnectionString = MyConnectionString};
                _conn.Open();
            }
            catch (MySqlException ex)
            {
                //catch errors
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Insert data into database
        /// </summary>
        private void InsertData()
        {
            //Open database connection
            DatabaseConection();

            //Update Weather
            GetWeather();

            //Datetime for mysql
            DateTime date = DateTime.Now;

            //Make query and excute query
            string query = "INSERT INTO `chart`(`city`,`humidity`,`temp`, `temp_min`, `temp_max`, `date`) VALUES ('" + city.Text + "','" + air.Text + "','" + temp.Text +"','" + minTemp.Text + "','" + maxTemp.Text + "','" + date.ToString("yy-MM-dd H:mm:ss") + "'" + ")";
            MySqlCommand command = new MySqlCommand(query, _conn);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                
            }
            //Close database connection
            _conn.Close();
        }

        /// <summary>
        /// Locks interval timer and excutes InsertData method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void databaseTimer_Tick(object sender, EventArgs e)
        {
            _locked = true;
            InsertData();
            _locked = false;
        }
        
        /// <summary>
        /// Get all the data for the chart from today
        /// </summary>
        private void getData()
        {
            //DataBase connection
            DatabaseConection();
            //Get to today's date for query
            string today = DateTime.Now.ToString("yyyy-MM-dd");

            //Query and running qeury
            string query = "SELECT * FROM chart WHERE date LIKE '" + today + "%' AND city = '" + city.Text + "'";
            MySqlCommand cmd = new MySqlCommand(query, _conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            //Clear chart
            chart1.Series.Clear();

            //Add Series
            chart1.Series.Add("Luchtvochtigheid");
            chart1.Series.Add("Minimale Tempratuur");
            chart1.Series.Add("Maximale Tempratuur");
            
            //Series setting color and style
            chart1.Series["Minimale Tempratuur"].ChartType = SeriesChartType.FastLine;
            chart1.Series["Minimale Tempratuur"].Color = Color.Aqua;
            chart1.Series["Maximale Tempratuur"].ChartType = SeriesChartType.FastLine;
            chart1.Series["Maximale Tempratuur"].Color = Color.OrangeRed;
            chart1.Series["Luchtvochtigheid"].Color = Color.LightGray;

            //Loop for getting data
            while (reader.Read())
            {
                //Data out of the database into variables
                string cityChart = (string)reader["city"];
                int humidity = (int)reader["humidity"];
                decimal temp = (decimal) reader["temp"];
                decimal tempMin = (decimal)reader["temp_min"];
                decimal tempMax = (decimal)reader["temp_max"];

                //Get current time
                DateTime date = (DateTime) reader["date"];
                int mins = date.Minute;
                int hours = date.Hour;
                string time = hours + ":" + mins;

                //Check for series so there no doubles
                if (chart1.Series.IndexOf(cityChart) == -1)
                {
                    //Get the city out of the database
                    chart1.Series.Add(cityChart);
                    chart1.Series[cityChart].ChartType = SeriesChartType.FastLine;
                    chart1.Series[cityChart ].Color = Color.Chocolate;
                }

                //Add the points to the chart
                chart1.Series["Luchtvochtigheid"].Points.AddXY(time, humidity);
                chart1.Series[cityChart].Points.AddY(temp);
                chart1.Series["Minimale Tempratuur"].Points.AddY(tempMin);
                chart1.Series["Maximale Tempratuur"].Points.AddY( tempMax);
                
            }
            //Close connection
            _conn.Close();
        }

        /// <summary>
        /// If tab trend is open run function getData
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EnterTab(object sender, EventArgs e)
        {
            getData();
        }

        private void conClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void conOpen_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
        }

        private void conOptions_Click(object sender, EventArgs e)
        {
            weatherTabs.SelectTab(optionTab);
            WindowState = FormWindowState.Normal;
        }

        private void conRefresh_Click(object sender, EventArgs e)
        {
            GetWeather();
        }

        private void conOver_Click(object sender, EventArgs e)
        {
            aboutbox box = new aboutbox();
            box.Show();
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                contextMenu.Show(MousePosition);
            }
        }
    }
}
