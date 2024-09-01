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
    public partial class AdminInterfaceFrm : Form
    {
        public AdminInterfaceFrm()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            AdminAddFrm AdminAdd = new AdminAddFrm();
            AdminAdd.Show();
            this.Close();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            LoginFrm Login = new LoginFrm();
            Login.Show();
            this.Close();
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            AdminRemoveFrm AdminRemove = new AdminRemoveFrm();
            AdminRemove.Show();
            this.Close();
        }

        private void ViewBtn_Click(object sender, EventArgs e)
        {
            AdminViewFrm ViewFrm = new AdminViewFrm();
            ViewFrm.Show();
            this.Close();
        }

        private void PssBtn_Click(object sender, EventArgs e)
        {
            AdminPssFrm AdminPss = new AdminPssFrm();
            AdminPss.Show();
            this.Close();
        }
    }
}
