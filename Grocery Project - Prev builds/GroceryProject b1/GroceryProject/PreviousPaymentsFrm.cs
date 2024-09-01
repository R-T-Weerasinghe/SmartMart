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

            SqlConnection con1 = new SqlConnection(@"Data Source=DESKTOP-QGUNALP;Initial Catalog=GroceryDB;Integrated Security=True");
            SqlConnection con2 = new SqlConnection(@"Data Source=DESKTOP-QGUNALP;Initial Catalog=GroceryDB;Integrated Security=True");

            try
            {
                con1.Open();
                con2.Open();
                string Acc = LoginFrm.Acc;
                string querySelect = "SELECT * FROM OrderTBL WHERE PlacedBy='" + Acc + "'";
                string queryCount = "SELECT COUNT(*) FROM OrderTBL WHERE PlacedBy='" + Acc + "'";

                SqlCommand cmndSelect = new SqlCommand(querySelect, con1);
                SqlCommand cmndCount = new SqlCommand(queryCount, con2);
                SqlDataReader r = cmndSelect.ExecuteReader();
                Int32 count = (Int32)cmndCount.ExecuteScalar(); //using a scalar coz we only need a single value(means count)
                                                                //we can get multiple values(or objects) if we use ExecuteNonQuery BUT it is not necessary here
                
                OrdersGrid.Columns.Add("OrderNo", "Order Number");   //first one is the columnname. Second one is the header name
                OrdersGrid.Columns.Add("Items", "Items");
                OrdersGrid.Columns.Add("Date", "Date");
                OrdersGrid.Columns.Add("Value", "Value");


                while (r.Read())
                {
                    for (int i = 0; i < count; i = i + 4)         
                    {
                        OrdersGrid.Rows.Add(new object[] { r[i], r[i + 2], r[i + 3], r[i + 4] });   //assigning datareader array values to rows

                    }

                    //if (reader.HasRows)
                    //else
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while retrieving data ! " + ex,"Messages",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally
            {
                con1.Close();
                con2.Close();
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
    }
}

