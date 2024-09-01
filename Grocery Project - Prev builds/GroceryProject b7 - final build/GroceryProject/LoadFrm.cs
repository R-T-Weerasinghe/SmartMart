using Esoft_last_project;
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
    public partial class LoadFrm : Form
    {
        int second = 0;

        public LoadFrm()
        {
            InitializeComponent();
        }

        private void LoadFrm_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            second += 1;
            if (second >= 3)
            {
                WelcomeFrm Welcome = new WelcomeFrm();
                Welcome.Show();
                this.Hide();
                timer.Stop();
            }
        }
    }
}
