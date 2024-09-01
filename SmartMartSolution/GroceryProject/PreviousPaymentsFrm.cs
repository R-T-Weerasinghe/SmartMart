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
using System.Data.SqlClient;
using System.Collections;

namespace GroceryProject
{
    public partial class PreviousPaymentsFrm : Form
    {
        public PreviousPaymentsFrm()
        {
            InitializeComponent();

            //it is a must to add this code after the InitializeComponent(); Otherwise your dataGrid won't represent the retrieved data

            SqlConnection con = new SqlConnection(@"Data Source=RAVINDU-PC;Initial Catalog=GroceryDB;Integrated Security=True");

            OrdersGrid.Font = new Font("Microsoft Sans Serif", 10);

            try
            {
               
                
                int UserID = LoginFrm.UserID;
                string querySelect = "SELECT OrderNumber,Date,Value FROM OrderTBL WHERE PlacedBy=" + UserID + "";

                SqlCommand cmndSelect = new SqlCommand(querySelect, con);

                SqlDataAdapter OrderAdp = new SqlDataAdapter(cmndSelect);
                DataTable tbl = new DataTable();
                OrderAdp.Fill(tbl);
                OrdersGrid.DataSource = tbl;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while retrieving data ! " + ex,"Messages",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }

        }


        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            WalletFrm Wallet = new WalletFrm();
            Wallet.Show();
            this.Close();
        }
        private void PreviousPaymentsFrm_Load(object sender, EventArgs e)
        {

        }

        private void OrdersGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PreviousPaymentsFrm_Load_1(object sender, EventArgs e)
        {

        }
    }
}

