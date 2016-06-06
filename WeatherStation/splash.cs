using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherStation
{
    public partial class splash: Form
    {
        public splash()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void splashTimer_Tick(object sender, EventArgs e)
        {
            splashProgress.Increment(1);
            if (splashProgress.Value == 100)
            {
                splashTimer.Stop();
            }
        }
    }
}
