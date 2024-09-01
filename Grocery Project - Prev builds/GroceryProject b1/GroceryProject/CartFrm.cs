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
using GroceryProject;

namespace Esoft_last_project
{
    public partial class CartFrm : Form
    {
        public static int iorder;
        public CartFrm()
        {
            InitializeComponent();

            SqlConnection con1 = new SqlConnection(@"Data Source=DESKTOP-QGUNALP;Initial Catalog=GroceryDB;Integrated Security=True");
            SqlConnection con2 = new SqlConnection(@"Data Source=DESKTOP-QGUNALP;Initial Catalog=GroceryDB;Integrated Security=True");
            SqlConnection con3 = new SqlConnection(@"Data Source=DESKTOP-QGUNALP;Initial Catalog=GroceryDB;Integrated Security=True");

            try
            {
                con1.Open();
                con2.Open();
                con3.Open();
                string Acc = LoginFrm.Acc;
                int total = 0;
                string querySelect = "SELECT * FROM CartTBL WHERE AccountName = '" + Acc + "'";
                string queryCount = "SELECT COUNT(*) FROM CartTBL WHERE AccountName='" + Acc + "'";
                string queryOrders = "SELECT Orders FROM CustomerOrderTBL WHERE AccountName='" + Acc + "'";

                SqlCommand cmndSelect = new SqlCommand(querySelect, con1);
                SqlCommand cmndCount = new SqlCommand(queryCount, con2);
                SqlCommand cmndOrders = new SqlCommand(queryOrders, con3);

                SqlDataReader r1 = cmndSelect.ExecuteReader();
                int orders = (int)cmndOrders.ExecuteScalar();
                int count = (int)cmndCount.ExecuteScalar();
                
                CartGrid.Columns.Add("ItemName", "Item Name");
                CartGrid.Columns.Add("ItemPrize", "Item Prize");
                CartGrid.Columns.Add("ItemQuantity", "Item Quantity");
                CartGrid.Columns.Add("Value", "Value");

                //adding data to the grid
                while (r1.Read())
                {
                    for (int i = 0; i < count; i = i + 6)
                    {
                        CartGrid.Rows.Add(new object[] { r1[i + 2], r1[i + 3], r1[i + 4], r1[i + 5] });
                    }
                }

                //getting the total value
                for (int x = 0; x < CartGrid.Rows.Count; x++)
                {
                    total += Convert.ToInt32(CartGrid.Rows[x].Cells[3].Value);  //Cells[3] ==> 3 is the index value of the column
                }
                ValueLbl.Text = total.ToString();

                //getting the number of items
                ItemsLbl.Text = CartGrid.Rows.Count.ToString();

                //generating the order number
                iorder = orders + 1;
                OrderLbl.Text = Acc +"@"+ iorder.ToString();
                


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while retrieving data ! " + ex, "Messages", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con1.Close();
                con2.Close();
                con3.Close();
            }

        }

        SqlConnection con1 = new SqlConnection(@"Data Source=DESKTOP-QGUNALP;Initial Catalog=GroceryDB;Integrated Security=True");
        SqlConnection con2 = new SqlConnection(@"Data Source=DESKTOP-QGUNALP;Initial Catalog=GroceryDB;Integrated Security=True");
        SqlConnection con3 = new SqlConnection(@"Data Source=DESKTOP-QGUNALP;Initial Catalog=GroceryDB;Integrated Security=True");
        SqlConnection con4 = new SqlConnection(@"Data Source=DESKTOP-QGUNALP;Initial Catalog=GroceryDB;Integrated Security=True");
        SqlConnection con5 = new SqlConnection(@"Data Source=DESKTOP-QGUNALP;Initial Catalog=GroceryDB;Integrated Security=True");
        SqlConnection con6 = new SqlConnection(@"Data Source=DESKTOP-QGUNALP;Initial Catalog=GroceryDB;Integrated Security=True");
        SqlConnection con7 = new SqlConnection(@"Data Source=DESKTOP-QGUNALP;Initial Catalog=GroceryDB;Integrated Security=True");

        private void CartFrm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            StockViewFrm StockView = new StockViewFrm();
            StockView.Show();
            this.Close();
        }

        private void RemoveAllBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure ? ", "Messages", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    con1.Open();
                    con2.Open();
                    con3.Open();
                    con4.Open();
                    con5.Open();

                    string Acc = LoginFrm.Acc;
                    string ItemName;
                    int RQty;
                    int AQty;
                    int x = 0;

                    string queryDeleteAll = "DELETE FROM CartTBL WHERE AccountName = '" + Acc + "'";
                    string querySelectCart = "SELECT ItemName,ItemQuantity FROM CartTBL WHERE AccountName = '" + Acc + "'";
                    string queryCountCart = "SELECT COUNT(*) FROM CartTBL WHERE AccountName='" + Acc + "'";

                    SqlCommand DeleteAll = new SqlCommand(queryDeleteAll, con1);
                    SqlCommand CountCart = new SqlCommand(queryCountCart, con2);
                    SqlCommand SelectCart = new SqlCommand(querySelectCart, con3);

                    int count = (int)CountCart.ExecuteScalar();
                    //MessageBox.Show("hi" + count);
                    SqlDataReader r = SelectCart.ExecuteReader();

                    while (r.Read())
                    {
                        for (int i = 0; i < count; i++)
                        {                            
                            ItemName = (string)r[x];
                            RQty = (int)r[x+1];
                            x += 2;

                            string querySelectStock = "SELECT AvailableQty FROM StockTBL WHERE ItemName='" + ItemName + "'";
                            SqlCommand SelectStock = new SqlCommand(querySelectStock, con4);

                            AQty = (int)SelectStock.ExecuteScalar();
                            AQty += RQty;

                            string queryUpdateStock = "UPDATE StockTBL SET AvailableQty=" + AQty + " WHERE ItemName='" + ItemName + "'";
                            SqlCommand UpdateStock = new SqlCommand(queryUpdateStock, con5);

                            UpdateStock.ExecuteNonQuery();
                        }
                    }
                        
                    
                    DeleteAll.ExecuteNonQuery();
                    MessageBox.Show("All items are removed from your cart ! ", "Messages", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while removing items ! " + ex, "Messages", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con1.Close();
                con2.Close();
                con3.Close();
                con4.Close();
                con5.Close();
            }
        }

        private void PurchaseBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure ? ", "Messages", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    con1.Open();
                    con2.Open();
                    con3.Open();
                    con4.Open();
                    con5.Open();
                    con6.Open();
                    con7.Open();

                    string Acc = LoginFrm.Acc;
                    int total = int.Parse(ValueLbl.Text.ToString());
                    string Order = OrderLbl.Text.ToString();
                    DateTime TDate = DateTime.Today;
                    string Date = TDate.ToString("yyyyMMdd"); 
                    int count = 0;
                    List<string> ListItems = new List<string>();    //arrays have a fixed size and lists have a dynamic size

                    string querySelectBal = "SELECT AvailableBalance FROM AccountTBL WHERE AccountName='" + Acc + "'";
                    string querySelectItems = "SELECT ItemName FROM CartTBL WHERE AccountName='" + Acc + "'";
                    string queryCount = "SELECT COUNT(*) FROM CartTBL WHERE AccountName='" + Acc + "'";



                    SqlCommand cmndBal = new SqlCommand(querySelectBal, con1);
                    SqlCommand cmndItems = new SqlCommand(querySelectItems, con2);
                    SqlCommand cmndCount = new SqlCommand(queryCount, con3);

                    int Bal = (int)cmndBal.ExecuteScalar();
                    SqlDataReader r = cmndItems.ExecuteReader();
                    count = (int)cmndCount.ExecuteScalar();

                    if (Bal < total)
                    {
                        MessageBox.Show("Available balance is insufficient ! ", "Messages", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Bal = Bal - total;
                    }

                    while (r.Read())
                    {

                        for (int i = 0; i < count; i++)
                        {
                            ListItems.Add(r[i].ToString());  //out of bounds error !!!
                        }

                        var Items = string.Join(",", ListItems);             // converting the list to a string 

                        string queryInsert = "INSERT INTO OrderTBL VALUES('" + Order + "','" + Acc + "','" + Items + "','" + Date + "'," + total + ")";
                        string queryUpdateBal = "UPDATE AccountTBL SET AvailableBalance=" + Bal + " WHERE AccountName = '" + Acc + "'";
                        string queryDeleteAll = "DELETE FROM CartTBL WHERE AccountName = '" + Acc + "'";
                        string queryUpdateCO = "UPDATE CustomerOrderTBL SET Orders=" + iorder + " WHERE AccountName='" + Acc + "'";

                        SqlCommand cmndInsert = new SqlCommand(queryInsert, con4);
                        SqlCommand cmndUpdate = new SqlCommand(queryUpdateBal, con5);
                        SqlCommand DeleteAll = new SqlCommand(queryDeleteAll, con6);
                        SqlCommand UpdateCO = new SqlCommand(queryUpdateCO, con7);
                        
                        cmndInsert.ExecuteNonQuery();
                        cmndUpdate.ExecuteNonQuery();
                        DeleteAll.ExecuteNonQuery();
                        UpdateCO.ExecuteNonQuery();



                        MessageBox.Show("Your purchase completed ! ", "Messages", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Purchase cancelled ! ", "Messages", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Purchase failed ! " + ex, "Messages", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con1.Close();
                con2.Close();
                con3.Close();
                con4.Close();
                con5.Close();
                con6.Close();
                con7.Close();
            }

        }

        private void RemoveSelBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure ? ", "Messages", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    con1.Open();
                    con2.Open();
                    con3.Open();
                    con4.Open();

                    string Acc = LoginFrm.Acc;
                    string Item = ItemNameTxt.Text;

                    string queryRemove = "DELETE FROM CartTBL WHERE AccountName='" + Acc + "' AND ItemName='" + Item + "'";
                    string querySelectCart = "SELECT ItemQuantity FROM CartTBL WHERE AccountName='" + Acc + "' AND ItemName='" + Item + "'";
                    string querySelectStock = "SELECT AvailableQty FROM StockTBL WHERE ItemName='" + Item + "'";

                    SqlCommand Remove = new SqlCommand(queryRemove, con1);
                    SqlCommand SelectCart = new SqlCommand(querySelectCart, con2);
                    SqlCommand SelectStock = new SqlCommand(querySelectStock, con3);

                    int RQty = (int)SelectCart.ExecuteScalar();
                    int AQty = (int)SelectStock.ExecuteScalar();

                    AQty += RQty;
                    string queryUpdate = "UPDATE StockTBL SET AvailableQty=" + AQty + " WHERE ItemName='" + Item + "'";
                    SqlCommand Update = new SqlCommand(queryUpdate, con4);

                    Update.ExecuteNonQuery();
                    Remove.ExecuteNonQuery();

                    MessageBox.Show("Item removed ! ", "Messages", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while removing ! " + ex, "Messages", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con1.Close();
                con2.Close();
                con3.Close();
                con4.Close();
            }
        }
    }
}
