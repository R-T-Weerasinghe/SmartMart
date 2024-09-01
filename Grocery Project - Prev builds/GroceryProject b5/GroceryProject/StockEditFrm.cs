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
using System.IO;


namespace Esoft_last_project
{
    public partial class StockEditFrm : Form
    {
        public StockEditFrm()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-QGUNALP;Initial Catalog=GroceryDB;Integrated Security=True");
        

        private void StockEditFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'groceryDBDataSet1.StockTBL' table. You can move, or remove it, as needed.
            try
            {
                string SelectedRefID = StaffStockViewFrm.SelectedRefID;
                if (SelectedRefID != null)
                {
                    string querySelectItem = "SELECT * FROM StockTBL WHERE ReferenceID='" + SelectedRefID + "'";
                    string querySelectPic = "SELECT ItemPicture FROM StockTBL WHERE ReferenceID='" + SelectedRefID + "'";

                    SqlCommand SelectItem = new SqlCommand(querySelectItem, con);
                    SqlCommand SelectPic = new SqlCommand(querySelectPic, con);

                    con.Open();
                    SqlDataReader Item = SelectItem.ExecuteReader();
                    while (Item.Read())
                    {
                        RefIDTxt.Text = Item[0].ToString();
                        NewRefIDTxt.Text = Item[0].ToString();
                        NameTxt.Text = Item[2].ToString();
                        DescTxt.Text = Item[3].ToString();
                        PrizeTxt.Text = Item[4].ToString();
                        WeightVolumeTxt.Text = Item[5].ToString();
                        MfdPicker.Text = Item[6].ToString();
                        ExpPicker.Text = Item[7].ToString();
                        QtyTxt.Text = Item[8].ToString();
                        SoldTxt.Text = Item[9].ToString();
                        SupTxt.Text = Item[10].ToString();
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

                    ItemPictureBox.Image = Image.FromStream(stream1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while retrieving data (Selected RefID) ! " + ex, "Messages", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SelectBtn_Click(object sender, EventArgs e)
        {
            RefidChk.Checked = true;
            NameChk.Checked = true;
            PrizeChk.Checked = true;
            WeightVolumeChk.Checked = true;         
            QtyChk.Checked = true;
            SoldChk.Checked = true;
            SupChk.Checked = true;
            PathChk.Checked = true;
            DescChk.Checked = true;
            NewRefIDChk.Checked = true;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string RefID = RefIDTxt.Text;
                string Name = NameTxt.Text;
                string Desc = DescTxt.Text;
                float Prize = float.Parse(PrizeTxt.Text);
                string Weightvolume = WeightVolumeTxt.Text;
                string Sup = SupTxt.Text;
                string Mfd = MfdPicker.Text;
                string Exp = ExpPicker.Text;
                int Sold = int.Parse(SoldTxt.Text);
                int Qty = int.Parse(QtyTxt.Text);

                string querySave = "INSERT INTO StockTBL VALUES('" + RefID + "',@pic,'" + Name + "','" + Desc + "'," + Prize + ",'" + Weightvolume + "','" + Mfd + "','" + Exp + "'," + Qty + "," + Sold + ",'" + Sup + "')";
                SqlCommand Save = new SqlCommand(querySave, con);

                MemoryStream stream1 = new MemoryStream();
                ItemPictureBox.Image.Save(stream1, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] pic = stream1.ToArray();
                Save.Parameters.AddWithValue("@pic", pic);

                con.Open();
                Save.ExecuteNonQuery();
                MessageBox.Show("Item saved !", "Messages", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while saving item ! " + ex, "Messages", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
           
        }

        private void UnselectBtn_Click(object sender, EventArgs e)
        {
            RefidChk.Checked = false;
            NameChk.Checked = false;
            PrizeChk.Checked = false;
            WeightVolumeChk.Checked = false;
            QtyChk.Checked = false;
            SoldChk.Checked = false;
            SupChk.Checked = false;
            PathChk.Checked = false;
            DescChk.Checked = false;
            NewRefIDChk.Checked = false;
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            if (RefidChk.Checked == true)
            {
                RefIDTxt.Clear();
            }

            if (NameChk.Checked == true)
            {
                NameTxt.Clear();
            } 
            
            if (PrizeChk.Checked == true)
            {
                PrizeTxt.Clear();
            } 
            
            if (WeightVolumeChk.Checked == true)
            {
                WeightVolumeTxt.Clear();
            }            
            
            if (QtyChk.Checked == true)
            {
                QtyTxt.Clear();
            } 
            
            if (SoldChk.Checked == true)
            {
                SoldTxt.Clear();
            } 
            
            if (SupChk.Checked == true)
            {
                SupTxt.Clear();
            }
            if (PathChk.Checked == true)
            {
                PathTxt.Clear();
            }
            if (DescChk.Checked == true)
            {
                DescTxt.Clear();
            }
            if (NewRefIDChk.Checked == true)
            {
                NewRefIDTxt.Clear();
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)

        {
            try
            {
                string RefID = RefIDTxt.Text;
                string NewID = NewRefIDTxt.Text;
                string Name = NameTxt.Text;
                string Desc = DescTxt.Text;
                float Prize = float.Parse(PrizeTxt.Text);
                string Weightvolume = WeightVolumeTxt.Text;
                string Sup = SupTxt.Text;
                string Mfd = MfdPicker.Text;
                string Exp = ExpPicker.Text;
                int Sold = int.Parse(SoldTxt.Text);
                int Qty = int.Parse(QtyTxt.Text);

                string queryUpdate = "UPDATE StockTBL SET ReferenceID='" + NewID + "',ItemPicture=@pic,ItemName='" + Name + "',ItemDescription='" + Desc + "',ItemPrize=" + Prize + ",WeightVolume='" + Weightvolume + "',ManuDT='" + Mfd + "',ExpDT='" + Exp + "',AvailableQty=" + Qty + ",SoldItems=" + Sold + ",Supplier='" + Sup + "'WHERE ReferenceID='" + RefID + "'";
                SqlCommand Update = new SqlCommand(queryUpdate, con);

                MemoryStream stream1 = new MemoryStream();
                ItemPictureBox.Image.Save(stream1, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] pic = stream1.ToArray();
                Update.Parameters.AddWithValue("@pic", pic);

                con.Open();
                Update.ExecuteNonQuery();
                MessageBox.Show("Item updated !", "Messages", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while updating item ! " + ex, "Messages", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
           

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure ? ", "Messages", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    con.Open();
                    string Refid = RefIDTxt.Text;

                    string queryDelete = "DELETE FROM StockTBL WHERE ReferenceID='" + Refid + "'";
                    SqlCommand cmndDelete = new SqlCommand(queryDelete, con);
                    cmndDelete.ExecuteNonQuery();
                    MessageBox.Show("Item deleted ! ", "Messages", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while deleting item ! " + ex, "Messages", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            StaffInterfaceFrm StaffInterface = new StaffInterfaceFrm();
            StaffInterface.Show();
            this.Close();
        }

        private void ViewBtn_Click(object sender, EventArgs e)
        {
            StaffStockViewFrm StockView = new StaffStockViewFrm();
            StockView.Show();
            this.Hide();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            try
            {                  
                string Search = SearchTxt.Text;
                string querySelect1 = "SELECT * FROM StockTBL WHERE ReferenceID='" + Search + "'";
                string querySelect2 = "SELECT * FROM StockTBL WHERE ItemName='" + Search + "'";
                string querySelectPic1 = "SELECT ItemPicture FROM StockTBL WHERE ReferenceID='" + Search + "'";
                string querySelectPic2 = "SELECT ItemPicture FROM StockTBL WHERE ItemName='" + Search + "'";

                SqlCommand SelectID = new SqlCommand(querySelect1, con);
                SqlCommand SelectName = new SqlCommand(querySelect2, con);
                SqlCommand SelectPic1 = new SqlCommand(querySelectPic1, con);
                SqlCommand SelectPic2 = new SqlCommand(querySelectPic2, con);

                con.Open();

                if (SearchCom.Text == "Ref. ID")
                {
                    SqlDataReader ID = SelectID.ExecuteReader();
                    if (ID.HasRows == true)
                    {
                        while (ID.Read())
                        {
                            RefIDTxt.Text = ID[0].ToString();
                            NewRefIDTxt.Text = ID[0].ToString();
                            NameTxt.Text = ID[2].ToString();
                            DescTxt.Text = ID[3].ToString();
                            PrizeTxt.Text = ID[4].ToString();
                            WeightVolumeTxt.Text = ID[5].ToString();
                            MfdPicker.Text = ID[6].ToString();
                            ExpPicker.Text = ID[7].ToString();
                            QtyTxt.Text = ID[8].ToString();
                            SoldTxt.Text = ID[9].ToString();
                            SupTxt.Text = ID[10].ToString();
                        }
                        con.Close();

                        con.Open();
                        SqlDataAdapter da = new SqlDataAdapter(SelectPic1);
                        DataSet dataset1 = new DataSet("Image");

                        byte[] picture = new byte[0];
                        da.Fill(dataset1, "Image");
                        DataRow myrow;
                        myrow = dataset1.Tables["Image"].Rows[0];

                        picture = (byte[])myrow["ItemPicture"];
                        MemoryStream stream1 = new MemoryStream(picture);

                        ItemPictureBox.Image = Image.FromStream(stream1);
                    }
                    else
                    {
                        MessageBox.Show("No items found !", "Messages", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                
                if (SearchCom.Text == "Item Name")
                {

                    SqlDataReader iName = SelectName.ExecuteReader();
                    if (iName.HasRows == true)
                    {
                        while (iName.Read())
                        {
                            RefIDTxt.Text = iName[0].ToString();
                            NewRefIDTxt.Text = iName[0].ToString();
                            NameTxt.Text = iName[2].ToString();
                            DescTxt.Text = iName[3].ToString();
                            PrizeTxt.Text = iName[4].ToString();
                            WeightVolumeTxt.Text = iName[5].ToString();
                            MfdPicker.Text = iName[6].ToString();
                            ExpPicker.Text = iName[7].ToString();
                            QtyTxt.Text = iName[8].ToString();
                            SoldTxt.Text = iName[9].ToString();
                            SupTxt.Text = iName[10].ToString();
                        }
                        con.Close();
                        con.Open();
                        SqlDataAdapter da = new SqlDataAdapter(SelectPic2);
                        DataSet dataset1 = new DataSet("Image");

                        byte[] picture = new byte[0];
                        da.Fill(dataset1, "Image");
                        DataRow myrow;
                        myrow = dataset1.Tables["Image"].Rows[0];

                        picture = (byte[])myrow["ItemPicture"];
                        MemoryStream stream1 = new MemoryStream(picture);

                        ItemPictureBox.Image = Image.FromStream(stream1);

                    }
                    else
                    {
                        MessageBox.Show("No items found !", "Messages", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while searching ! "+ex, "Messages", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void SearchCom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SearchTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void ImportBtn_Click(object sender, EventArgs e)
        {
            string path = PathTxt.Text;
            Image img = Image.FromFile(path);
            ItemPictureBox.Image = img;
        }

    }
}
