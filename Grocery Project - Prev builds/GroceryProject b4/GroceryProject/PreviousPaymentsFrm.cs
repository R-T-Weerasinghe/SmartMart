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

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-QGUNALP;Initial Catalog=GroceryDB;Integrated Security=True");


            try
            {
               
                
                int UserID = LoginFrm.UserID;
                string querySelect = "SELECT * FROM OrderTBL WHERE PlacedBy=" + UserID + "";
                string queryCount = "SELECT COUNT(*) FROM OrderTBL WHERE PlacedBy=" + UserID + "";

                SqlCommand cmndSelect = new SqlCommand(querySelect, con);
                SqlCommand cmndCount = new SqlCommand(queryCount, con);

                con.Open();
                int count = (int)cmndCount.ExecuteScalar(); //using a scalar coz we only need a single value(means count)
                con.Close();                                //we can get multiple values(or objects) if we use ExecuteReader BUT it is not necessary here
                
                OrdersGrid.Columns.Add("OrderNo", "Order Number");   //first one is the columnname. Second one is the header name
                OrdersGrid.Columns.Add("Date", "Date");
                OrdersGrid.Columns.Add("Value", "Value");

                con.Open();
                SqlDataReader r = cmndSelect.ExecuteReader();
                while (r.Read())
                {
                    for (int i = 0; i < count; i = i + 4)         
                    {
                        OrdersGrid.Rows.Add(new object[] { r[i], r[i + 2], r[i + 3] });   //assigning datareader array values to rows

                    }
                }
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

