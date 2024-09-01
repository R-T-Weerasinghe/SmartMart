using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GroceryProject
{
    public partial class SplashScreenFrm : Form
    {
        public SplashScreenFrm()
        {
            InitializeComponent();
        }



        private void SplashScreenFrm_Load(object sender, EventArgs e)
        {
            CP.Value = 0;
            CP.Minimum = 0;
            CP.Maximum = 100;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            CP.Increment(1);
            if (CP.Value == 100)
            {
                timer.Stop();
            }
        }

    }
}
