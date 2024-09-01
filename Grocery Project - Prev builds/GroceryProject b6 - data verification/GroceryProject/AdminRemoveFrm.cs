using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroceryProject
{
    public partial class AdminRemoveFrm : Form
    {
        public AdminRemoveFrm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-QGUNALP;Initial Catalog=GroceryDB;Integrated Security=True");


        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure ?", "Messages", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int UserID = int.Parse(IDTxt.Text);
                    string queryDelete = "DELETE FROM AccountTBL WHERE UserID = " + UserID + "";

                    SqlCommand Delete = new SqlCommand(queryDelete, con);

                    con.Open();
                    Delete.ExecuteNonQuery();
                    MessageBox.Show("Account deleted !", "Messages", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Deleting cancelled !", "Messages", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while deleting the account ! " + ex, "Messages", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            try
            {  




                con.Open();

                if (SearchCom.Text == "User ID")
                {
                    int SearchID = int.Parse(SearchTxt.Text);
                    string querySelect1 = "SELECT * FROM AccountTBL WHERE UserID=" + SearchID + "AND AccountType='Staff'";

                    SqlCommand SelectID = new SqlCommand(querySelect1, con);
                    SqlDataReader ID = SelectID.ExecuteReader();

                    if (ID.HasRows == true)
                    {
                        while (ID.Read())
                        {
                            IDTxt.Text = ID[0].ToString();
                            AccTxt.Text = ID[1].ToString();
                            FnameTxt.Text = ID[4].ToString();
                            LnameTxt.Text = ID[5].ToString();
                            EmailTxt.Text = ID[6].ToString();
                            TelTxt.Text = ID[7].ToString();
                            DOBTxt.Text = ID[8].ToString();
                            GenderTxt.Text = ID[10].ToString();
                            NICTxt.Text = ID[9].ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No accounts found !", "Messages", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                
                if (SearchCom.Text == "Account Name")
                {
                    string SearchName = SearchTxt.Text;
                    string querySelect = "SELECT * FROM AccountTBL WHERE AccountName='" + SearchName + "'AND AccountType='Staff'";

                    SqlCommand SelectName = new SqlCommand(querySelect, con);
                    SqlDataReader iName = SelectName.ExecuteReader();

                    if (iName.HasRows == true)
                    {
                        while (iName.Read())
                        {
                            IDTxt.Text = iName[0].ToString();
                            AccTxt.Text = iName[1].ToString();
                            FnameTxt.Text = iName[4].ToString();
                            LnameTxt.Text = iName[5].ToString();
                            EmailTxt.Text = iName[6].ToString();
                            TelTxt.Text = iName[7].ToString();
                            DOBTxt.Text = iName[8].ToString();
                            GenderTxt.Text = iName[10].ToString();
                            NICTxt.Text = iName[9].ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No accounts found !", "Messages", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            AdminInterfaceFrm AdminInterface = new AdminInterfaceFrm();
            AdminInterface.Show();
            this.Close();
        }

        private void AdminRemoveFrm_Load(object sender, EventArgs e)
        {
            try
            {
                if (AdminViewFrm.SelectedID != null)
                {
                    int ID = AdminViewFrm.SelectedID;
                    string querySelect = "SELECT * FROM AccountTBL WHERE UserID=" + ID + "";

                    SqlCommand Select = new SqlCommand(querySelect, con);
                    con.Open();
                    SqlDataReader r = Select.ExecuteReader();

                    while (r.Read())
                    {
                        IDTxt.Text = r[0].ToString();
                        AccTxt.Text = r[1].ToString();
                        FnameTxt.Text = r[4].ToString();
                        LnameTxt.Text = r[5].ToString();
                        EmailTxt.Text = r[6].ToString();
                        TelTxt.Text = r[7].ToString();
                        DOBTxt.Text = r[8].ToString();
                        GenderTxt.Text = r[10].ToString();
                        NICTxt.Text = r[9].ToString();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error while retrieving data ! " + ex, "Messages", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }

        }
        
    }
}
