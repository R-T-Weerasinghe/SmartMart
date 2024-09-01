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

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-QGUNALP;Initial Catalog=GroceryDB;Integrated Security=True");

        public CartFrm()
        {
            InitializeComponent();        

            try
            {
                
                int UserID=LoginFrm.UserID;
                int total = 0;
                string querySelect = "SELECT ItemName,ItemPrize,ItemQuantity,Value FROM CartTBL WHERE UserID = " + UserID + "";
                string queryOrders = "SELECT Orders FROM AccountTBL WHERE UserID=" +UserID + "";

                SqlCommand cmndSelect = new SqlCommand(querySelect, con);
                SqlCommand cmndOrders = new SqlCommand(queryOrders, con);

                //generating the datagrid
                SqlDataAdapter CartAdp = new SqlDataAdapter(cmndSelect);
                DataTable tbl = new DataTable();
                CartAdp.Fill(tbl);

                CartGrid.DataSource = tbl;

                //getting the total value
                for (int x = 0; x < CartGrid.Rows.Count; x++)
                {
                    total += Convert.ToInt32(CartGrid.Rows[x].Cells[3].Value);  //Cells[3] ==> 3 is the index value of the column
                }
                ValueLbl.Text = total.ToString();

                //getting the number of items
                ItemsLbl.Text = CartGrid.Rows.Count.ToString();

                
                //generating the order number
                con.Open();
                int orders = (int)cmndOrders.ExecuteScalar();
                iorder = orders + 1;
                OrderLbl.Text = UserID +"@"+ iorder.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while retrieving data ! " + ex, "Messages", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }

        }

        private void CartFrm_Load(object sender, EventArgs e)
        {
            this.CartGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.CartGrid.MultiSelect = false;
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
            ItemPreviewFrm ItemPreview = new ItemPreviewFrm();
            ItemPreview.Show();
            this.Close();
        }

        private void RemoveAllBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure ? ", "Messages", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    int UserID = LoginFrm.UserID;
                    string ItemName;
                    int RQty;
                    int AQty;

                    string queryDeleteAll = "DELETE FROM CartTBL WHERE UserID = " + UserID + "";
                    SqlCommand DeleteAll = new SqlCommand(queryDeleteAll, con);

                    int items = CartGrid.Rows.Count;

                    for (int y = 0; y < items; y++)
                    {
                        ItemName = CartGrid.Rows[y].Cells[0].Value.ToString();
                        RQty = (int)CartGrid.Rows[y].Cells[2].Value;
                       
                        string querySelectStock = "SELECT AvailableQty FROM StockTBL WHERE ItemName='" + ItemName + "'";
                        SqlCommand SelectStock = new SqlCommand(querySelectStock, con);

                        con.Open();
                        AQty = (int)SelectStock.ExecuteScalar();
                        con.Close();

                        AQty += RQty;

                        string queryUpdateStock = "UPDATE StockTBL SET AvailableQty=" + AQty + " WHERE ItemName='" + ItemName + "'";
                        SqlCommand UpdateStock = new SqlCommand(queryUpdateStock, con);

                        con.Open();
                        UpdateStock.ExecuteNonQuery();
                        con.Close();
                    }

                    con.Open();
                    DeleteAll.ExecuteNonQuery();
                    MessageBox.Show("All items are removed from your cart ! ", "Messages", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //updating the datagrid

                    string querySelect = "SELECT ItemName,ItemPrize,ItemQuantity,Value FROM CartTBL WHERE UserID = " + UserID + "";
                    SqlCommand cmndSelect = new SqlCommand(querySelect, con);
                    SqlDataAdapter CartAdp = new SqlDataAdapter(cmndSelect);
                    DataTable tbl = new DataTable();
                    CartAdp.Fill(tbl);

                    CartGrid.DataSource = tbl;

                    //getting the total value
                    int total = 0;
                    for (int x = 0; x < CartGrid.Rows.Count; x++)
                    {
                        total += Convert.ToInt32(CartGrid.Rows[x].Cells[3].Value);  //Cells[3] ==> 3 is the index value of the column
                    }
                    ValueLbl.Text = total.ToString();

                    //getting the number of items
                    ItemsLbl.Text = CartGrid.Rows.Count.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while removing items ! " + ex, "Messages", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void PurchaseBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure ? ", "Messages", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {

                    int UserID = LoginFrm.UserID;
                    int total = int.Parse(ValueLbl.Text.ToString());
                    string OrderName = OrderLbl.Text.ToString();
                    DateTime TDate = DateTime.Today;
                    string Date = TDate.ToString("yyyyMMdd");

                    string querySelectBal = "SELECT AvailableBalance FROM AccountTBL WHERE UserID=" + UserID + "";
                    SqlCommand cmndBal = new SqlCommand(querySelectBal, con);

                    con.Open();
                    int Bal = (int)cmndBal.ExecuteScalar();
                    con.Close();
                    int count = (int)CartGrid.Rows.Count;

                    if (Bal < total)
                    {
                        MessageBox.Show("Available balance is insufficient ! ", "Messages", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Bal -= total;
                        string queryInsert = "INSERT INTO OrderTBL VALUES('" + OrderName + "'," + UserID + ",'" + Date + "'," + total + ")";
                        string queryUpdateBal = "UPDATE AccountTBL SET AvailableBalance=" + Bal + " WHERE UserID = " + UserID + "";
                        string queryDeleteAll = "DELETE FROM CartTBL WHERE UserID = " + UserID + "";
                        string queryUpdateOrders = "UPDATE AccountTBL SET Orders=" + iorder + " WHERE UserID=" + UserID + "";

                        SqlCommand cmndInsert = new SqlCommand(queryInsert, con);
                        SqlCommand cmndUpdate = new SqlCommand(queryUpdateBal, con);
                        SqlCommand DeleteAll = new SqlCommand(queryDeleteAll, con);
                        SqlCommand UpdateOrders = new SqlCommand(queryUpdateOrders, con);

                        //updating sold items
                        for (int i = 0; i < count; i++)
                        {
                            string ItemName = CartGrid.Rows[i].Cells[0].Value.ToString();
                            int ItemQty = (int)CartGrid.Rows[i].Cells[2].Value;

                            string querySelectSold = "SELECT SoldItems FROM StockTBL WHERE ItemName = '"+ItemName+"'";
                            SqlCommand SelectSold = new SqlCommand(querySelectSold, con);

                            con.Open();
                            int Sold = (int)SelectSold.ExecuteScalar();
                            con.Close();

                            Sold += ItemQty;

                            string queryUpdateStock = "UPDATE StockTBL SET SoldItems = " + Sold + "";
                            SqlCommand UpdateStock = new SqlCommand(queryUpdateStock, con);

                            con.Open();
                            UpdateStock.ExecuteNonQuery();
                            con.Close();
                        }

                        //adding the order
                        con.Open();
                        cmndInsert.ExecuteNonQuery();
                        con.Close();

                        //updating available balance
                        con.Open();
                        cmndUpdate.ExecuteNonQuery();
                        con.Close();

                        //removing all items from the cart
                        con.Open();
                        DeleteAll.ExecuteNonQuery();
                        con.Close();

                        //updating no.of orders
                        con.Open();
                        UpdateOrders.ExecuteNonQuery();

                        MessageBox.Show("Your purchase completed ! ", "Messages", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //updating the datagrid

                        string querySelect = "SELECT ItemName,ItemPrize,ItemQuantity,Value FROM CartTBL WHERE UserID = " + UserID + "";
                        SqlCommand cmndSelect = new SqlCommand(querySelect, con);
                        SqlDataAdapter CartAdp = new SqlDataAdapter(cmndSelect);
                        DataTable tbl = new DataTable();
                        CartAdp.Fill(tbl);

                        CartGrid.DataSource = tbl;

                        //getting the total value
                        ValueLbl.Text = "0";

                        //getting the number of items
                        ItemsLbl.Text = "0";
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
                con.Close();
            }

        }

        private void RemoveSelBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure ? ", "Messages", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int UserID = LoginFrm.UserID;
                    
                    string Item = CartGrid.SelectedCells[0].Value.ToString();
                    int RQty = (int)CartGrid.SelectedCells[2].Value;

                    string queryRemove = "DELETE FROM CartTBL WHERE UserID=" + UserID + " AND ItemName='" + Item + "'";
                    string querySelectStock = "SELECT AvailableQty FROM StockTBL WHERE ItemName='" + Item + "'";

                    SqlCommand Remove = new SqlCommand(queryRemove, con);
                    SqlCommand SelectStock = new SqlCommand(querySelectStock, con);

                    con.Open();
                    int AQty = (int)SelectStock.ExecuteScalar();
                    con.Close();

                    AQty += RQty;
                    string queryUpdate = "UPDATE StockTBL SET AvailableQty=" + AQty + " WHERE ItemName='" + Item + "'";
                    SqlCommand Update = new SqlCommand(queryUpdate, con);

                    con.Open();
                    Update.ExecuteNonQuery();
                    con.Close();

                    con.Open();
                    Remove.ExecuteNonQuery();

                    MessageBox.Show("Item removed !", "Messages", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //updating the datagrid

                    string querySelect = "SELECT ItemName,ItemPrize,ItemQuantity,Value FROM CartTBL WHERE UserID = " + UserID + "";
                    SqlCommand cmndSelect = new SqlCommand(querySelect, con);
                    SqlDataAdapter CartAdp = new SqlDataAdapter(cmndSelect);
                    DataTable tbl = new DataTable();
                    CartAdp.Fill(tbl);

                    CartGrid.DataSource = tbl;

                    //getting the total value
                    int total = 0;
                    for (int x = 0; x < CartGrid.Rows.Count; x++)
                    {
                        total += Convert.ToInt32(CartGrid.Rows[x].Cells[3].Value);  //Cells[3] ==> 3 is the index value of the column
                    }
                    ValueLbl.Text = total.ToString();

                    //getting the number of items
                    ItemsLbl.Text = CartGrid.Rows.Count.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while removing item ! " + ex, "Messages", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
