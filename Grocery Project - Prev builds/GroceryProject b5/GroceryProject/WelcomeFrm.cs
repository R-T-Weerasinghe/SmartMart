using GroceryProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Esoft_last_project
{
    public partial class WelcomeFrm : Form
    {
        public WelcomeFrm()
        {
            InitializeComponent();
        }

        public void Startform()
        {
           // Application.Run(new SplashScreenFrm());
        }
       


        private void LoginBtn_Click(object sender, EventArgs e)
        {
            LoginFrm AppLogin = new LoginFrm();            
            AppLogin.Show();
            this.Hide();

        }

        private void AppWelcomeFrm_Load(object sender, EventArgs e)
        {

        }

        private void SignupBtn_Click(object sender, EventArgs e)
        {
            SignUpFrm SignUp = new SignUpFrm();
            this.Hide();
            SignUp.Show();

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
