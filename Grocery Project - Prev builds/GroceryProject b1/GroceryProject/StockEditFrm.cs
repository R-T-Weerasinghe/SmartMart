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
    public partial class StockEditFrm : Form
    {
        public StockEditFrm()
        {
            InitializeComponent();
        }

        SqlConnection con1 = new SqlConnection(@"Data Source=DESKTOP-QGUNALP;Initial Catalog=GroceryDB;Integrated Security=True");
        SqlConnection con2 = new SqlConnection(@"Data Source=DESKTOP-QGUNALP;Initial Catalog=GroceryDB;Integrated Security=True");

        private void StockEditFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'groceryDBDataSet1.StockTBL' table. You can move, or remove it, as needed.
            this.stockTBLTableAdapter.Fill(this.groceryDBDataSet1.StockTBL);

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
            WeightChk.Checked = true; 
            VolumeChk.Checked = true;
            ManuChk.Checked = true;
            ExpChk.Checked = true; 
            QtyChk.Checked = true;
            SoldChk.Checked = true;
            SupChk.Checked = true;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string Refid = RefIDTxt.Text;
                string Name = NameTxt.Text;
                int Prize = int.Parse(PrizeTxt.Text);
                string Weight = WeightTxt.Text;
                string Volume = VolumeTxt.Text;
                string Mfd = MfdTxt.Text;
                string Exp = ExpTxt.Text;
                int Qty = int.Parse(QtyTxt.Text);
                int Sold = int.Parse(SoldTxt.Text);
                string Sup = SupTxt.Text;

                string querySave = "INSERT INTO StockTBL VALUES('" + Refid + "','" + Name + "'," + Prize + ",'" + Weight + "','" + Volume + "','" + Mfd + "','" + Exp + "'," + Qty + "," + Sold + ",'" + Sup + "')";
                SqlCommand cmndSave = new SqlCommand(querySave,con1);
                con1.Open();

                cmndSave.ExecuteNonQuery();
                MessageBox.Show("Item saved !", "Messages", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while saving ! " + ex, "Messages", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                con1.Close();
            }



           
        }

        private void UnselectBtn_Click(object sender, EventArgs e)
        {
            RefidChk.Checked = false;
            NameChk.Checked = false;
            PrizeChk.Checked = false;
            WeightChk.Checked = false;
            VolumeChk.Checked = false;
            ManuChk.Checked = false;
            ExpChk.Checked = false;
            QtyChk.Checked = false;
            SoldChk.Checked = false;
            SupChk.Checked = false;
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
            
            if (WeightChk.Checked == true)
            {
                WeightTxt.Clear();
            } 
            
            if (VolumeChk.Checked == true)
            {
                VolumeTxt.Clear();
            }
            
            if (ManuChk.Checked == true)
            {
                MfdTxt.Clear();
            } 
            
            if (ExpChk.Checked == true)
            {
                ExpTxt.Clear();
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
        }

        private void UpdateBtn_Click(object sender, EventArgs e)

        {
            try
            {
                con1.Open();
                con2.Open();

                string Refid = RefIDTxt.Text;
                string Name = NameTxt.Text;
                int Prize = int.Parse(PrizeTxt.Text);
                string Weight = WeightTxt.Text;
                string Volume = VolumeTxt.Text;
                string Mfd = MfdTxt.Text;
                string Exp = ExpTxt.Text;
                int Qty = int.Parse(QtyTxt.Text);
                int Sold = int.Parse(SoldTxt.Text);
                string Sup = SupTxt.Text;

                string queryUpdate = "UPDATE StockTBL SET ReferenceID='" + Refid + "', ItemName='" + Name + "', ItemPrize=" + Prize + ", Weight='" + Weight + "', Volume='" + Volume + "', ManuDT='" + Mfd + "',ExpDT='" + Exp + "', AvailableQty = " + Qty + ", SoldItems = " + Sold + ", Supplier = '" + Sup + "' WHERE ReferenceID='" + Refid + "'";
                string querySelect = "SELECT * FROM StockTBL WHERE ReferenceID='" + Refid + "'";

                SqlCommand cmndUpdate = new SqlCommand(queryUpdate, con1);
                cmndUpdate.ExecuteNonQuery();
                MessageBox.Show("Updated successfully !", "Messages", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while updating ! " + ex, "Messages", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con1.Close();
                con2.Close();
            }




        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure ? ", "Messages", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    con1.Open();
                    string Refid = RefIDTxt.Text;

                    string queryDelete = "DELETE FROM StockTBL WHERE ReferenceID='" + Refid + "'";
                    SqlCommand cmndDelete = new SqlCommand(queryDelete, con1);
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
                con1.Close();
            }

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            StaffInterfaceFrm StaffInterface = new StaffInterfaceFrm();
            StaffInterface.Show();
            this.Close();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            EditDBFrm EditDB = new EditDBFrm();
            EditDB.Show();
            this.Hide();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                con1.Open();
                con2.Open();

                string Search = SearchTxt.Text;
                string querySelect1 = "SELECT * FROM StockTBL WHERE ReferenceID='" + Search + "'";
                string querySelect2 = "SELECT * FROM StockTBL WHERE ItemName='" + Search + "'";

                SqlCommand SelectID = new SqlCommand(querySelect1, con1);
                SqlCommand SelectName = new SqlCommand(querySelect2, con2);

                
                

                if (SearchCom.Text == "Ref. ID")
                {
                    SqlDataReader ID = SelectID.ExecuteReader();
                    if (ID.HasRows == true)
                    {
                        while (ID.Read())
                        {
                            RefIDTxt.Text = ID[0].ToString();
                            NameTxt.Text = ID[1].ToString();
                            PrizeTxt.Text = ID[2].ToString();
                            WeightTxt.Text = ID[3].ToString();
                            VolumeTxt.Text = ID[4].ToString();
                            MfdTxt.Text = ID[5].ToString();
                            ExpTxt.Text = ID[6].ToString();
                            QtyTxt.Text = ID[7].ToString();
                            SoldTxt.Text = ID[8].ToString();
                            SupTxt.Text = ID[9].ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No items found !","Messages",MessageBoxButtons.OK,MessageBoxIcon.Error);
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
                            NameTxt.Text = iName[1].ToString();
                            PrizeTxt.Text = iName[2].ToString();
                            WeightTxt.Text = iName[3].ToString();
                            VolumeTxt.Text = iName[4].ToString();
                            MfdTxt.Text = iName[5].ToString();
                            ExpTxt.Text = iName[6].ToString();
                            QtyTxt.Text = iName[7].ToString();
                            SoldTxt.Text = iName[8].ToString();
                            SupTxt.Text = iName[9].ToString();
                        }
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
                con1.Close();
                con2.Close();
            }
        }

        private void SearchCom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SearchTxt_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
