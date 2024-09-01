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
                
                string Acc = LoginFrm.Acc;
                int total = 0;
                string querySelect = "SELECT * FROM CartTBL WHERE AccountName = '" + Acc + "'";
                string queryCount = "SELECT COUNT(*) FROM CartTBL WHERE AccountName='" + Acc + "'";
                string queryOrders = "SELECT Orders FROM AccountTBL WHERE AccountName='" + Acc + "'";

                SqlCommand cmndSelect = new SqlCommand(querySelect, con);
                SqlCommand cmndCount = new SqlCommand(queryCount, con);
                SqlCommand cmndOrders = new SqlCommand(queryOrders, con);

                //creating the datagrid
                CartGrid.Columns.Add("ItemName", "Item Name");
                CartGrid.Columns.Add("ItemPrize", "Item Prize");
                CartGrid.Columns.Add("ItemQuantity", "Item Quantity");
                CartGrid.Columns.Add("Value", "Value");

                con.Open();
                int count = (int)cmndCount.ExecuteScalar();
                con.Close();

                //adding data to the grid
                con.Open();
                SqlDataReader r1 = cmndSelect.ExecuteReader();
                while (r1.Read())
                {
                    for (int i = 0; i < count; i = i + 5)
                    {
                        CartGrid.Rows.Add(new object[] { r1[i + 1], r1[i + 2], r1[i + 3], r1[i + 4] });
                    }
                }
                con.Close();

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
                OrderLbl.Text = Acc +"@"+ iorder.ToString();

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
                    
                    string Acc = LoginFrm.Acc;
                    string ItemName;
                    int RQty;
                    int AQty;

                    string queryDeleteAll = "DELETE FROM CartTBL WHERE AccountName = '" + Acc + "'";
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

                    string Acc = LoginFrm.Acc;
                    int total = int.Parse(ValueLbl.Text.ToString());
                    string OrderName = OrderLbl.Text.ToString();
                    DateTime TDate = DateTime.Today;
                    string Date = TDate.ToString("yyyyMMdd"); 

                    string querySelectBal = "SELECT AvailableBalance FROM AccountTBL WHERE AccountName='" + Acc + "'";
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
                        string queryInsert = "INSERT INTO OrderTBL VALUES('" + OrderName + "','" + Acc + "','" + Date + "'," + total + ")";
                        string queryUpdateBal = "UPDATE AccountTBL SET AvailableBalance=" + Bal + " WHERE AccountName = '" + Acc + "'";
                        string queryDeleteAll = "DELETE FROM CartTBL WHERE AccountName = '" + Acc + "'";
                        string queryUpdateOrders = "UPDATE AccountTBL SET Orders=" + iorder + " WHERE AccountName='" + Acc + "'";

                        SqlCommand cmndInsert = new SqlCommand(queryInsert, con);
                        SqlCommand cmndUpdate = new SqlCommand(queryUpdateBal, con);
                        SqlCommand DeleteAll = new SqlCommand(queryDeleteAll, con);
                        SqlCommand UpdateOrders = new SqlCommand(queryUpdateOrders, con);

                        con.Open();
                        cmndInsert.ExecuteNonQuery();
                        con.Close();

                        con.Open();
                        cmndUpdate.ExecuteNonQuery();
                        con.Close();

                        con.Open();
                        DeleteAll.ExecuteNonQuery();
                        con.Close();

                        con.Open();
                        UpdateOrders.ExecuteNonQuery();

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
                con.Close();
            }

        }

        private void RemoveSelBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure ? ", "Messages", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    string Acc = LoginFrm.Acc;
                    string Item = CartGrid.SelectedCells[0].Value.ToString();
                    int RQty = (int)CartGrid.SelectedCells[2].Value;

                    string queryRemove = "DELETE FROM CartTBL WHERE AccountName='" + Acc + "' AND ItemName='" + Item + "'";
                    string querySelect = "SELECT AvailableQty FROM StockTBL WHERE ItemName='" + Item + "'";

                    SqlCommand Remove = new SqlCommand(queryRemove, con);
                    SqlCommand SelectStock = new SqlCommand(querySelect, con);

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
