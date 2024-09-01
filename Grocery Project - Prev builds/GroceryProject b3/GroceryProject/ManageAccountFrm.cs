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
    public partial class ManageAccountFrm : Form
    {
        public ManageAccountFrm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-QGUNALP;Initial Catalog=GroceryDB;Integrated Security=True");

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int UserID = LoginFrm.UserID;
                string Pss = PssTxt.Text;
                string NewAcc = NewAccTxt.Text;
                string NewPss = NewPssTxt.Text;
                string Type;
                if (StaffRad.Checked == true)
                {
                    Type = "Staff";
                }
                else
                {
                    Type = "Customer";
                }
                string Fname = FnameTxt.Text;
                string Lname = LnameTxt.Text;
                string Email = EmailTxt.Text;
                string Tel = TelTxt.Text;
                string DOB = DOBPicker.Text;
                string NIC = NICTxt.Text;
                string Gender;
                if (MaleRad.Checked == true)
                {
                    Gender = "Male";
                }
                else
                {
                    Gender = "Female";
                }
                string AdminPass = AdminPassTxt.Text;

                string queryUpdate = "UPDATE AccountTBL SET AccountName='" + NewAcc + "',AccountPassword='" + NewPss + "',AccountType='" + Type + "',FirstName='" + Fname + "',LastName='" + Lname + "',Email='" + Email + "',TelNum=" + Tel + ",DOB='" + DOB + "',Gender='" + Gender + "',NIC='" + NIC + "' WHERE UserID=" + UserID + "";
                string querySelect = "SELECT AccountPassword FROM AccountTBL WHERE UserID = " + UserID + "";
                string queryReqAdminPss = "SELECT AccountPassword FROM AccountTBL WHERE AccountName='Admin'";
                string queryStatus = "SELECT AccountName FROM AccountTBL WHERE AccountName='" + NewAcc + "'";

                SqlCommand Update = new SqlCommand(queryUpdate, con);
                SqlCommand Select = new SqlCommand(querySelect, con);
                SqlCommand CheckAdminPss = new SqlCommand(queryReqAdminPss, con);
                SqlCommand CheckStatus = new SqlCommand(queryStatus, con);

                con.Open();
                string dbAcc = (string)CheckStatus.ExecuteScalar();
                con.Close();

                if (dbAcc == NewAcc)
                {
                    MessageBox.Show("The account name you entered is already taken ! Please try a different account name.", "Messages", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    con.Open();
                    string CPss = (string)Select.ExecuteScalar();
                    con.Close();

                    con.Open();
                    string CAdminPss = (string)CheckAdminPss.ExecuteScalar();
                    con.Close();

                    if (CPss == Pss)
                    {
                        if (StaffRad.Checked == true)
                        {
                            if (CAdminPss == AdminPass)
                            {
                                con.Open();
                                Update.ExecuteNonQuery();
                                MessageBox.Show("Your account has been updated !", "Messages", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoginFrm Login = new LoginFrm();
                                Login.Show();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Please check the admin password !", "Messages", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                        }
                        else
                        {
                            con.Open();
                            Update.ExecuteNonQuery();
                            MessageBox.Show("Your account has been updated !", "Messages", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoginFrm Login = new LoginFrm();
                            Login.Show();
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please check your password !", "Messages", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while Updating ! " + ex, "Messages", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (MessageBox.Show("Are you sure ?", "Messages", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int UserID = LoginFrm.UserID;
                    string Pss = PssTxt.Text;

                    if (Pss == "")
                    {
                        MessageBox.Show("Please enter your password to continue !", "Messages", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string queryDelete = "DELETE FROM AccountTBL WHERE UserID = " + UserID + "";
                        string querySelect = "SELECT AccountPassword FROM AccountTBL WHERE UserID = " + UserID + "";

                        SqlCommand cmndSelect = new SqlCommand(querySelect, con);
                        SqlCommand cmndDelete = new SqlCommand(queryDelete, con);

                        con.Open();
                        string CPss = (string)cmndSelect.ExecuteScalar();
                        con.Close();
                        if (CPss == Pss)
                        {
                            con.Open();
                            cmndDelete.ExecuteNonQuery();

                            MessageBox.Show("Your account is deleted !", "Messages", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Please check your password !", "Messages", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error while deleting your account ! " + ex, "Messages", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            LoginFrm Login = new LoginFrm();
            Login.Show();
            this.Close();
        }

        private void NewPssTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void StaffRad_CheckedChanged(object sender, EventArgs e)
        {
            if (StaffRad.Checked == true)
            {
                AdminPassTxt.Visible = true;
                AdminPassLbl.Visible = true;
            }
            else
            {
                AdminPassTxt.Visible = false;
                AdminPassLbl.Visible = false;
            }
        }

        private void ManageAccountFrm_Load(object sender, EventArgs e)
        {

        }
    }
}
