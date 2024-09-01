using GroceryProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esoft_last_project
{
    public partial class StaffInterfaceFrm : Form
    {
        public StaffInterfaceFrm()
        {
            InitializeComponent();
        }

        private void ManageBtn_Click(object sender, EventArgs e)
        {
            ManageAccountFrm ManageAccount = new ManageAccountFrm();
            ManageAccount.Show();
            this.Hide();
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

        private void EditBtn_Click(object sender, EventArgs e)
        {
            StaffStockViewFrm StockView = new StaffStockViewFrm();
            StockView.Show();
            this.Close();
        }

        private void OrderBtn_Click(object sender, EventArgs e)
        {
            OrdersFrm Orders = new OrdersFrm();
            Orders.Show();
            this.Close();
        }
    }
}
