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
using Esoft_last_project;

namespace GroceryProject
{
    public partial class StockViewFrm : Form
    {
        public StockViewFrm()
        {
            InitializeComponent();
        }

        SqlConnection con1 = new SqlConnection(@"Data Source=DESKTOP-QGUNALP;Initial Catalog=GroceryDB;Integrated Security=True");
        SqlConnection con2 = new SqlConnection(@"Data Source=DESKTOP-QGUNALP;Initial Catalog=GroceryDB;Integrated Security=True");

        private void searchtxt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void dbViewBtn_Click(object sender, EventArgs e)
        {
            ViewDBFrm ViewDB = new ViewDBFrm();
            ViewDB.Show();
            this.Hide();

          
            
        }

        private void customerfrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'groceryDBDataSet.StockTBL' table. You can move, or remove it, as needed.
            this.stockTBLTableAdapter.Fill(this.groceryDBDataSet.StockTBL);

        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            try
            {
                con1.Open();
                string search = searchtxt.Text;
                string querySearch = "SELECT * FROM StockTBL WHERE ReferenceID='" + search + "'";
                SqlCommand cmnd = new SqlCommand(querySearch, con1);
                SqlDataReader r = cmnd.ExecuteReader();

                while (r.Read())
                {
                    RefidTxt.Text = r[0].ToString();                    
                    nameTxt.Text = r[1].ToString();
                    prizeTxt.Text = r[2].ToString();
                    weightTxt.Text = r[3].ToString();
                    volumeTxt.Text = r[4].ToString();
                    mdtTxt.Text = r[5].ToString();
                    edtTxt.Text = r[6].ToString();
                    aQtyTxt.Text = r[7].ToString();
                }

            }
                catch(Exception ex)
                {
                    MessageBox.Show("Error while Searching ! "+ex,"Messages",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            finally
            {
                con1.Close();

            }


        }

        private void CartBtn_Click(object sender, EventArgs e)
        {
            try
            {
                con1.Open();
                con2.Open();

                string Acc = LoginFrm.Acc;
                string name = nameTxt.Text;
                int prize = int.Parse(prizeTxt.Text);
                int aQty = int.Parse(aQtyTxt.Text);
                int qty = int.Parse(rQtyTxt.Text);
                int value = prize * qty;
                int selected = 0;

                aQty-=qty;

                string queryAddtoCart = "INSERT INTO CartTBL VALUES ("+selected+",'"+Acc+"','" + name + "'," + prize + "," + qty + "," + value + ")";
                string queryUpdate = "UPDATE StockTBL SET AvailableQty=" + aQty + " WHERE ItemName='" + name + "'";
                SqlCommand Add = new SqlCommand(queryAddtoCart, con1);
                SqlCommand Update = new SqlCommand(queryUpdate, con2);
                
                Add.ExecuteNonQuery();
                Update.ExecuteNonQuery();
                MessageBox.Show("Added successfully !", "Messages", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while adding to cart ! " + ex, "Messages", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con1.Close();
                con2.Close();
            }
        }

        private void rQtyTxt_TextChanged(object sender, EventArgs e)
        {
            if (rQtyTxt.Text == "")
            {
                rQtyTxt.Text = "0";
            }                      
            int rQty = int.Parse(rQtyTxt.Text);
            int aQty = int.Parse(aQtyTxt.Text);
            int prize = int.Parse(prizeTxt.Text);

            //Calculating the total amount 
            if (aQty >= rQty)
            {
                int tAmount = prize * rQty;
                tAmountTxt.Text = tAmount.ToString();
            }
            else
            {
                MessageBox.Show("Available Quantity is not enough! You have to reduce your Required Quantity", "Messages", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

      
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            CustomerInterfaceFrm CustomerInterface = new CustomerInterfaceFrm();
            CustomerInterface.Show();
            this.Close();

        }

        private void CartViewBtn_Click(object sender, EventArgs e)
        {
            CartFrm Cart = new CartFrm();
            Cart.Show();
            this.Hide();
        }
    }
}
