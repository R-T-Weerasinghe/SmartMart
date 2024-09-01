using Esoft_last_project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroceryProject
{
    public partial class ItemPreviewFrm : Form
    {
        public ItemPreviewFrm()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=RAVINDU-PC;Initial Catalog=GroceryDB;Integrated Security=True");

        private void ItemPreviewFrm_Load(object sender, EventArgs e)
        {
            try
            {
                string RefID = StockViewFrm.RefID;
                string querySelect = "SELECT * FROM StockTBL WHERE ReferenceID='" + RefID + "'";
                string querySelectPic = "SELECT ItemPicture FROM StockTBL WHERE ReferenceID='" + RefID + "'";

                SqlCommand Select = new SqlCommand(querySelect, con);
                SqlCommand SelectPic = new SqlCommand(querySelectPic, con);

                con.Open();
                SqlDataReader r = Select.ExecuteReader();
                while (r.Read())
                {
                    RefIDLbl.Text = r[0].ToString();
                    NameLbl.Text = r[2].ToString();
                    DescTxt.Text = r[3].ToString();
                    PrizeLbl.Text = r[4].ToString();
                    WeightVolumeLbl.Text = r[5].ToString();
                    MfdLbl.Text = r[6].ToString();
                    ExpLbl.Text = r[7].ToString();
                    AQtyLbl.Text = r[8].ToString();
                }
                con.Close();

                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(SelectPic);
                DataSet dataset1 = new DataSet("Image");

                byte[] picture = new byte[0];
                da.Fill(dataset1, "Image");
                DataRow myrow;
                myrow = dataset1.Tables["Image"].Rows[0];

                picture = (byte[])myrow["ItemPicture"];
                MemoryStream stream1 = new MemoryStream(picture);

                ItemPreview.Image = Image.FromStream(stream1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while retrieving data ! " + ex, "Messages", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }

            if (MfdLbl.Text == "2001-Jan-01")
            {
                MfdLbl.Text = "-";
            }
            if (ExpLbl.Text == "2001-Jan-01")
            {
                ExpLbl.Text = "-";
            }

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            StockViewFrm.RefID = "";
            StockViewFrm StockView = new StockViewFrm();
            StockView.Show();
            this.Close();
        }

        private void RQtyTxt_TextChanged(object sender, EventArgs e)
        {

            if (RQtyTxt.Text != "")
            {
                int RQty = int.Parse(RQtyTxt.Text);
                int AQty = int.Parse(AQtyLbl.Text);
                if (RQty > AQty)
                {
                    MessageBox.Show("Available quantity is not enough ! You have to reduce your required quantity.", "Messages", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    RQtyTxt.Text = AQtyLbl.Text;
                    RQty = int.Parse(RQtyTxt.Text);
                }               
                float prize = float.Parse(PrizeLbl.Text);
                TotalLbl.Text = (prize * RQty).ToString();

            }

            if (RQtyTxt.Text == "")
            {
                TotalLbl.Text = "0";
            }

        }

        private void CartBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string CheckRQty = RQtyTxt.Text;
                if (CheckRQty == "0" || CheckRQty == "")
                {
                    MessageBox.Show("Required quantity is not valid ! Please enter a valid quantity", "Messages", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    int UserID = LoginFrm.UserID;
                    string ItemName = NameLbl.Text;
                    int RQty = int.Parse(RQtyTxt.Text);   //required quantity
                    float Prize = float.Parse(PrizeLbl.Text);
                    float Value = float.Parse(TotalLbl.Text);
                    string dbQty = "";   //quantity in the cartDatabase
                    int Qty = 0;   //actual quantity
                    int nQty = int.Parse(AQtyLbl.Text);   //new quantity

                    nQty -= RQty;

                    string querySelect = "SELECT ItemQuantity FROM CartTBL WHERE UserID =" + UserID + " AND ItemName ='" + ItemName + "'";
                    string querySave = "INSERT INTO CartTBL VALUES(" + UserID + ",'" + ItemName + "'," + Prize + "," + RQty + "," + Value + ")";
                    string queryUpdateStock = "UPDATE StockTBL SET AvailableQty=" + nQty + " WHERE ItemName='" + ItemName + "'";

                    SqlCommand Select = new SqlCommand(querySelect, con);
                    SqlCommand Save = new SqlCommand(querySave, con);
                    SqlCommand UpdateStock = new SqlCommand(queryUpdateStock, con);

                    //Checking for item availability and retreiving the DB Qty
                    con.Open();
                    SqlDataReader r = Select.ExecuteReader();
                    while (r.Read())
                    {
                        if (r.HasRows == true)
                        {
                            dbQty = r[0].ToString();
                        }
                    }
                    con.Close();

                    //Checking whether the item is a new one or not
                    con.Open();
                    if (dbQty == "")
                    {
                        Save.ExecuteNonQuery();
                        MessageBox.Show("Item added to your cart !", "Messages", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        //dont rearrange these 4 lines 
                        Qty = RQty + int.Parse(dbQty);
                        Value = Prize * Qty;

                        string queryUpdate = "UPDATE CartTBL SET ItemPrize=" + Prize + ",ItemQuantity=" + Qty + ",Value=" + Value + " WHERE UserID=" + UserID + " AND ItemName='" + ItemName + "'";
                        SqlCommand Update = new SqlCommand(queryUpdate, con);
                        //!!!

                        Update.ExecuteNonQuery();
                        MessageBox.Show("Item added to your cart !", "Messages", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    con.Close();

                    //updating stock with the new available quantity
                    con.Open();
                    UpdateStock.ExecuteNonQuery();

                    //updating the Available Quantity label
                    AQtyLbl.Text = nQty.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while adding the item to your cart ! " + ex, "Messages", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void ViewBtn_Click(object sender, EventArgs e)
        {
            CartFrm Cart = new CartFrm();
            Cart.Show();
            this.Close();
        }
    }
}
