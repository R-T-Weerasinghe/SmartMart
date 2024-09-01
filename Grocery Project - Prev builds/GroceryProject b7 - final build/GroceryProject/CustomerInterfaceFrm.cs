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
    public partial class CustomerInterfaceFrm : Form
    {
        public CustomerInterfaceFrm()
        {
            InitializeComponent();
        }

        private void BuyBtn_Click(object sender, EventArgs e)
        {
            StockViewFrm StockView = new StockViewFrm();
            StockView.Show();
            this.Hide();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            LoginFrm Login = new LoginFrm();
            Login.Show();
            this.Close();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ManageBtn_Click(object sender, EventArgs e)
        {
            ManageAccountFrm ManageAccount = new ManageAccountFrm();
            ManageAccount.Show();
            this.Hide();
        }

        private void WalletBtn_Click(object sender, EventArgs e)
        {
            WalletFrm Wallet = new WalletFrm();
            Wallet.Show();
            this.Hide();

        }

        private void CustomerInterfaceFrm_Load(object sender, EventArgs e)
        {

        }
    }
}
