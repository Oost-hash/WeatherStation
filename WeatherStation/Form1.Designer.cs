namespace WeatherStation
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.weatherTabs = new System.Windows.Forms.TabControl();
            this.actualTab = new System.Windows.Forms.TabPage();
            this.lblAcUpdate = new System.Windows.Forms.Label();
            this.maxTemp = new System.Windows.Forms.Label();
            this.minTemp = new System.Windows.Forms.Label();
            this.lblAcMax = new System.Windows.Forms.Label();
            this.lblAcAir = new System.Windows.Forms.Label();
            this.lblAcMin = new System.Windows.Forms.Label();
            this.icon = new System.Windows.Forms.PictureBox();
            this.update = new System.Windows.Forms.Label();
            this.air = new System.Windows.Forms.Label();
            this.clouds = new System.Windows.Forms.Label();
            this.temp = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.Label();
            this.trendTab = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.optionTab = new System.Windows.Forms.TabPage();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.lblErrorInterval = new System.Windows.Forms.Label();
            this.lblErrorPlace = new System.Windows.Forms.Label();
            this.lblOptions = new System.Windows.Forms.Label();
            this.opslaan = new System.Windows.Forms.Button();
            this.txtbCity = new System.Windows.Forms.TextBox();
            this.txtbInterval = new System.Windows.Forms.TextBox();
            this.lblOpUnits = new System.Windows.Forms.Label();
            this.lblOpInterval = new System.Windows.Forms.Label();
            this.lblOpCity = new System.Windows.Forms.Label();
            this.rdCelcius = new System.Windows.Forms.RadioButton();
            this.rdiFahrenheit = new System.Windows.Forms.RadioButton();
            this.interval = new System.Windows.Forms.Timer(this.components);
            this.databaseTimer = new System.Windows.Forms.Timer(this.components);
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.conOver = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.conRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.conOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.conOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.conClose = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.weatherTabs.SuspendLayout();
            this.actualTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.trendTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.optionTab.SuspendLayout();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // weatherTabs
            // 
            this.weatherTabs.Controls.Add(this.actualTab);
            this.weatherTabs.Controls.Add(this.trendTab);
            this.weatherTabs.Controls.Add(this.optionTab);
            this.weatherTabs.Location = new System.Drawing.Point(0, 0);
            this.weatherTabs.Name = "weatherTabs";
            this.weatherTabs.SelectedIndex = 0;
            this.weatherTabs.Size = new System.Drawing.Size(477, 281);
            this.weatherTabs.TabIndex = 0;
            // 
            // actualTab
            // 
            this.actualTab.BackColor = System.Drawing.Color.White;
            this.actualTab.Controls.Add(this.lblAcUpdate);
            this.actualTab.Controls.Add(this.maxTemp);
            this.actualTab.Controls.Add(this.minTemp);
            this.actualTab.Controls.Add(this.lblAcMax);
            this.actualTab.Controls.Add(this.lblAcAir);
            this.actualTab.Controls.Add(this.lblAcMin);
            this.actualTab.Controls.Add(this.icon);
            this.actualTab.Controls.Add(this.update);
            this.actualTab.Controls.Add(this.air);
            this.actualTab.Controls.Add(this.clouds);
            this.actualTab.Controls.Add(this.temp);
            this.actualTab.Controls.Add(this.city);
            this.actualTab.Location = new System.Drawing.Point(4, 22);
            this.actualTab.Name = "actualTab";
            this.actualTab.Padding = new System.Windows.Forms.Padding(3);
            this.actualTab.Size = new System.Drawing.Size(469, 255);
            this.actualTab.TabIndex = 0;
            this.actualTab.Text = "Actueel";
            // 
            // lblAcUpdate
            // 
            this.lblAcUpdate.AutoSize = true;
            this.lblAcUpdate.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblAcUpdate.Location = new System.Drawing.Point(277, 224);
            this.lblAcUpdate.Name = "lblAcUpdate";
            this.lblAcUpdate.Size = new System.Drawing.Size(81, 13);
            this.lblAcUpdate.TabIndex = 12;
            this.lblAcUpdate.Text = "Laatste update:";
            // 
            // maxTemp
            // 
            this.maxTemp.AutoSize = true;
            this.maxTemp.Location = new System.Drawing.Point(174, 195);
            this.maxTemp.Name = "maxTemp";
            this.maxTemp.Size = new System.Drawing.Size(26, 13);
            this.maxTemp.TabIndex = 11;
            this.maxTemp.Text = "max";
            // 
            // minTemp
            // 
            this.minTemp.AutoSize = true;
            this.minTemp.Location = new System.Drawing.Point(174, 170);
            this.minTemp.Name = "minTemp";
            this.minTemp.Size = new System.Drawing.Size(23, 13);
            this.minTemp.TabIndex = 10;
            this.minTemp.Text = "min";
            // 
            // lblAcMax
            // 
            this.lblAcMax.AutoSize = true;
            this.lblAcMax.Location = new System.Drawing.Point(114, 195);
            this.lblAcMax.Name = "lblAcMax";
            this.lblAcMax.Size = new System.Drawing.Size(54, 13);
            this.lblAcMax.TabIndex = 9;
            this.lblAcMax.Text = "Maximaal:";
            // 
            // lblAcAir
            // 
            this.lblAcAir.AutoSize = true;
            this.lblAcAir.Location = new System.Drawing.Point(76, 147);
            this.lblAcAir.Name = "lblAcAir";
            this.lblAcAir.Size = new System.Drawing.Size(92, 13);
            this.lblAcAir.TabIndex = 8;
            this.lblAcAir.Text = "Luchtvochtigheid:";
            // 
            // lblAcMin
            // 
            this.lblAcMin.AutoSize = true;
            this.lblAcMin.Location = new System.Drawing.Point(117, 170);
            this.lblAcMin.Name = "lblAcMin";
            this.lblAcMin.Size = new System.Drawing.Size(51, 13);
            this.lblAcMin.TabIndex = 6;
            this.lblAcMin.Text = "Minimaal:";
            // 
            // icon
            // 
            this.icon.Location = new System.Drawing.Point(177, 36);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(48, 50);
            this.icon.TabIndex = 5;
            this.icon.TabStop = false;
            // 
            // update
            // 
            this.update.AutoSize = true;
            this.update.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.update.Location = new System.Drawing.Point(355, 224);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(40, 13);
            this.update.TabIndex = 4;
            this.update.Text = "update";
            // 
            // air
            // 
            this.air.AutoSize = true;
            this.air.Location = new System.Drawing.Point(174, 147);
            this.air.Name = "air";
            this.air.Size = new System.Drawing.Size(18, 13);
            this.air.TabIndex = 3;
            this.air.Text = "air";
            // 
            // clouds
            // 
            this.clouds.AutoSize = true;
            this.clouds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clouds.Location = new System.Drawing.Point(224, 64);
            this.clouds.Name = "clouds";
            this.clouds.Size = new System.Drawing.Size(55, 20);
            this.clouds.TabIndex = 2;
            this.clouds.Text = "clouds";
            // 
            // temp
            // 
            this.temp.AutoSize = true;
            this.temp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temp.Location = new System.Drawing.Point(173, 89);
            this.temp.Name = "temp";
            this.temp.Size = new System.Drawing.Size(45, 20);
            this.temp.TabIndex = 1;
            this.temp.Text = "temp";
            // 
            // city
            // 
            this.city.AutoSize = true;
            this.city.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.city.Location = new System.Drawing.Point(223, 36);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(50, 26);
            this.city.TabIndex = 0;
            this.city.Text = "City";
            // 
            // trendTab
            // 
            this.trendTab.Controls.Add(this.chart1);
            this.trendTab.Location = new System.Drawing.Point(4, 22);
            this.trendTab.Name = "trendTab";
            this.trendTab.Padding = new System.Windows.Forms.Padding(3);
            this.trendTab.Size = new System.Drawing.Size(469, 255);
            this.trendTab.TabIndex = 1;
            this.trendTab.Text = "Trend";
            this.trendTab.UseVisualStyleBackColor = true;
            this.trendTab.Enter += new System.EventHandler(this.EnterTab);
            // 
            // chart1
            // 
            this.chart1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(-4, 3);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(473, 249);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "\\";
            // 
            // optionTab
            // 
            this.optionTab.Controls.Add(this.lblSeconds);
            this.optionTab.Controls.Add(this.lblErrorInterval);
            this.optionTab.Controls.Add(this.lblErrorPlace);
            this.optionTab.Controls.Add(this.lblOptions);
            this.optionTab.Controls.Add(this.opslaan);
            this.optionTab.Controls.Add(this.txtbCity);
            this.optionTab.Controls.Add(this.txtbInterval);
            this.optionTab.Controls.Add(this.lblOpUnits);
            this.optionTab.Controls.Add(this.lblOpInterval);
            this.optionTab.Controls.Add(this.lblOpCity);
            this.optionTab.Controls.Add(this.rdCelcius);
            this.optionTab.Controls.Add(this.rdiFahrenheit);
            this.optionTab.Location = new System.Drawing.Point(4, 22);
            this.optionTab.Name = "optionTab";
            this.optionTab.Padding = new System.Windows.Forms.Padding(3);
            this.optionTab.Size = new System.Drawing.Size(469, 255);
            this.optionTab.TabIndex = 2;
            this.optionTab.Text = "Opties";
            this.optionTab.UseVisualStyleBackColor = true;
            // 
            // lblSeconds
            // 
            this.lblSeconds.AutoSize = true;
            this.lblSeconds.Location = new System.Drawing.Point(132, 132);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(56, 13);
            this.lblSeconds.TabIndex = 11;
            this.lblSeconds.Text = "Seconden";
            // 
            // lblErrorInterval
            // 
            this.lblErrorInterval.AutoSize = true;
            this.lblErrorInterval.ForeColor = System.Drawing.Color.Red;
            this.lblErrorInterval.Location = new System.Drawing.Point(260, 132);
            this.lblErrorInterval.Name = "lblErrorInterval";
            this.lblErrorInterval.Size = new System.Drawing.Size(74, 13);
            this.lblErrorInterval.TabIndex = 10;
            this.lblErrorInterval.Text = "lblErrorInterval";
            // 
            // lblErrorPlace
            // 
            this.lblErrorPlace.AutoSize = true;
            this.lblErrorPlace.ForeColor = System.Drawing.Color.Red;
            this.lblErrorPlace.Location = new System.Drawing.Point(260, 93);
            this.lblErrorPlace.Name = "lblErrorPlace";
            this.lblErrorPlace.Size = new System.Drawing.Size(66, 13);
            this.lblErrorPlace.TabIndex = 9;
            this.lblErrorPlace.Text = "lblErrorPlace";
            // 
            // lblOptions
            // 
            this.lblOptions.AutoSize = true;
            this.lblOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOptions.ForeColor = System.Drawing.Color.Black;
            this.lblOptions.Location = new System.Drawing.Point(26, 34);
            this.lblOptions.Name = "lblOptions";
            this.lblOptions.Size = new System.Drawing.Size(84, 29);
            this.lblOptions.TabIndex = 8;
            this.lblOptions.Text = "Opties";
            // 
            // opslaan
            // 
            this.opslaan.Location = new System.Drawing.Point(383, 221);
            this.opslaan.Name = "opslaan";
            this.opslaan.Size = new System.Drawing.Size(75, 23);
            this.opslaan.TabIndex = 7;
            this.opslaan.Text = "Opslaan";
            this.opslaan.UseVisualStyleBackColor = true;
            this.opslaan.Click += new System.EventHandler(this.opslaan_Click);
            // 
            // txtbCity
            // 
            this.txtbCity.Location = new System.Drawing.Point(91, 86);
            this.txtbCity.Name = "txtbCity";
            this.txtbCity.Size = new System.Drawing.Size(163, 20);
            this.txtbCity.TabIndex = 6;
            // 
            // txtbInterval
            // 
            this.txtbInterval.Location = new System.Drawing.Point(91, 129);
            this.txtbInterval.Name = "txtbInterval";
            this.txtbInterval.Size = new System.Drawing.Size(35, 20);
            this.txtbInterval.TabIndex = 5;
            // 
            // lblOpUnits
            // 
            this.lblOpUnits.AutoSize = true;
            this.lblOpUnits.Location = new System.Drawing.Point(28, 169);
            this.lblOpUnits.Name = "lblOpUnits";
            this.lblOpUnits.Size = new System.Drawing.Size(57, 13);
            this.lblOpUnits.TabIndex = 4;
            this.lblOpUnits.Text = "Weergave";
            // 
            // lblOpInterval
            // 
            this.lblOpInterval.AutoSize = true;
            this.lblOpInterval.Location = new System.Drawing.Point(28, 132);
            this.lblOpInterval.Name = "lblOpInterval";
            this.lblOpInterval.Size = new System.Drawing.Size(45, 13);
            this.lblOpInterval.TabIndex = 3;
            this.lblOpInterval.Text = "Interval:";
            // 
            // lblOpCity
            // 
            this.lblOpCity.AutoSize = true;
            this.lblOpCity.Location = new System.Drawing.Point(28, 93);
            this.lblOpCity.Name = "lblOpCity";
            this.lblOpCity.Size = new System.Drawing.Size(39, 13);
            this.lblOpCity.TabIndex = 2;
            this.lblOpCity.Text = "Plaats:";
            // 
            // rdCelcius
            // 
            this.rdCelcius.AutoSize = true;
            this.rdCelcius.Location = new System.Drawing.Point(132, 167);
            this.rdCelcius.Name = "rdCelcius";
            this.rdCelcius.Size = new System.Drawing.Size(36, 17);
            this.rdCelcius.TabIndex = 1;
            this.rdCelcius.TabStop = true;
            this.rdCelcius.Text = "°C";
            this.rdCelcius.UseVisualStyleBackColor = true;
            // 
            // rdiFahrenheit
            // 
            this.rdiFahrenheit.AutoSize = true;
            this.rdiFahrenheit.Location = new System.Drawing.Point(91, 167);
            this.rdiFahrenheit.Name = "rdiFahrenheit";
            this.rdiFahrenheit.Size = new System.Drawing.Size(35, 17);
            this.rdiFahrenheit.TabIndex = 0;
            this.rdiFahrenheit.TabStop = true;
            this.rdiFahrenheit.Text = "°F";
            this.rdiFahrenheit.UseVisualStyleBackColor = true;
            // 
            // interval
            // 
            this.interval.Enabled = true;
            this.interval.Interval = 60000;
            this.interval.Tick += new System.EventHandler(this.interval_Tick);
            // 
            // databaseTimer
            // 
            this.databaseTimer.Enabled = true;
            this.databaseTimer.Interval = 300000;
            this.databaseTimer.Tick += new System.EventHandler(this.databaseTimer_Tick);
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conOver,
            this.toolStripSeparator1,
            this.conRefresh,
            this.conOptions,
            this.toolStripSeparator2,
            this.conOpen,
            this.conClose});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(135, 126);
            // 
            // conOver
            // 
            this.conOver.Name = "conOver";
            this.conOver.Size = new System.Drawing.Size(134, 22);
            this.conOver.Text = "Over";
            this.conOver.Click += new System.EventHandler(this.conOver_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(131, 6);
            // 
            // conRefresh
            // 
            this.conRefresh.Name = "conRefresh";
            this.conRefresh.Size = new System.Drawing.Size(134, 22);
            this.conRefresh.Text = "Verversen...";
            this.conRefresh.Click += new System.EventHandler(this.conRefresh_Click);
            // 
            // conOptions
            // 
            this.conOptions.Name = "conOptions";
            this.conOptions.Size = new System.Drawing.Size(134, 22);
            this.conOptions.Text = "Opties...";
            this.conOptions.Click += new System.EventHandler(this.conOptions_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(131, 6);
            // 
            // conOpen
            // 
            this.conOpen.Name = "conOpen";
            this.conOpen.Size = new System.Drawing.Size(134, 22);
            this.conOpen.Text = "Open...";
            this.conOpen.Click += new System.EventHandler(this.conOpen_Click);
            // 
            // conClose
            // 
            this.conClose.Name = "conClose";
            this.conClose.Size = new System.Drawing.Size(134, 22);
            this.conClose.Text = "Sluiten";
            this.conClose.Click += new System.EventHandler(this.conClose_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notifyIcon1";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 278);
            this.Controls.Add(this.weatherTabs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "WeatherStation";
            this.weatherTabs.ResumeLayout(false);
            this.actualTab.ResumeLayout(false);
            this.actualTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.trendTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.optionTab.ResumeLayout(false);
            this.optionTab.PerformLayout();
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl weatherTabs;
        private System.Windows.Forms.TabPage actualTab;
        private System.Windows.Forms.TabPage trendTab;
        private System.Windows.Forms.TabPage optionTab;
        private System.Windows.Forms.Timer interval;
        private System.Windows.Forms.Label city;
        private System.Windows.Forms.Label air;
        private System.Windows.Forms.Label clouds;
        private System.Windows.Forms.Label temp;
        private System.Windows.Forms.Label update;
        private System.Windows.Forms.PictureBox icon;
        private System.Windows.Forms.Label lblAcAir;
        private System.Windows.Forms.Label lblAcMin;
        private System.Windows.Forms.Label lblOptions;
        private System.Windows.Forms.Button opslaan;
        private System.Windows.Forms.TextBox txtbCity;
        private System.Windows.Forms.TextBox txtbInterval;
        private System.Windows.Forms.Label lblOpUnits;
        private System.Windows.Forms.Label lblOpInterval;
        private System.Windows.Forms.Label lblOpCity;
        private System.Windows.Forms.RadioButton rdCelcius;
        private System.Windows.Forms.RadioButton rdiFahrenheit;
        private System.Windows.Forms.Label lblAcMax;
        private System.Windows.Forms.Label lblAcUpdate;
        private System.Windows.Forms.Label maxTemp;
        private System.Windows.Forms.Label minTemp;
        private System.Windows.Forms.Label lblErrorInterval;
        private System.Windows.Forms.Label lblErrorPlace;
        private System.Windows.Forms.Label lblSeconds;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer databaseTimer;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem conOver;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem conRefresh;
        private System.Windows.Forms.ToolStripMenuItem conOptions;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem conOpen;
        private System.Windows.Forms.ToolStripMenuItem conClose;
        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}

