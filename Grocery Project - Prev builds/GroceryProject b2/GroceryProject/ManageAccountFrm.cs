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
        SqlConnection con1 = new SqlConnection(@"Data Source=DESKTOP-QGUNALP;Initial Catalog=GroceryDB;Integrated Security=True");
        SqlConnection con2 = new SqlConnection(@"Data Source=DESKTOP-QGUNALP;Initial Catalog=GroceryDB;Integrated Security=True");
        SqlConnection con3 = new SqlConnection(@"Data Source=DESKTOP-QGUNALP;Initial Catalog=GroceryDB;Integrated Security=True");

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                con1.Open();
                con2.Open();
                con3.Open();
                string Acc = AccTxt.Text;
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
                string DOB = BirthTxt.Text;
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

                string queryUpdate = "UPDATE AccountTBL SET AccountName='" + NewAcc + "',AccountPassword='" + NewPss + "',AccountType='" + Type + "',FirstName='" + Fname + "',LastName='" + Lname + "',Email='" + Email + "',TelNum=" + Tel + ",DOB='" + DOB + "',Gender='" + Gender + "',NIC='" + NIC + "' WHERE AccountName='" + Acc + "'";
                string querySelect = "SELECT AccountPassword FROM AccountTBL WHERE AccountName = '" + Acc + "'";
                string queryReqAdminPss = "SELECT AccountPassword FROM AccountTBL WHERE AccountName='Admin'";

                SqlCommand cmndUpdate = new SqlCommand(queryUpdate, con1);
                SqlCommand cmndSelect = new SqlCommand(querySelect, con2);
                SqlCommand cmndCheckPss = new SqlCommand(queryReqAdminPss, con3);

                SqlDataReader r1 = cmndSelect.ExecuteReader();
                SqlDataReader r2 = cmndCheckPss.ExecuteReader();

                while (r1.Read())
                {
                    string CPss = r1[0].ToString();
                    if (CPss == Pss)
                    {
                        if (StaffRad.Checked == true)
                        {
                            while (r2.Read())
                            {
                                string CAdminPss = r2[0].ToString();
                                if (CAdminPss == AdminPass)
                                {
                                    cmndUpdate.ExecuteNonQuery();
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
                        }
                        else
                        {
                            cmndUpdate.ExecuteNonQuery();
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
                con1.Close();
                con2.Close();
                con3.Close();
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure ? ", "Messages", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    con1.Open();
                    con2.Open();
                    string Acc = LoginFrm.Acc;


                    string queryDelete = "DELETE FROM AccountTBL WHERE AccountName = '" + Acc + "'";

                    SqlCommand cmndDelete = new SqlCommand(queryDelete, con1);
                    cmndDelete.ExecuteNonQuery();

                    MessageBox.Show("Your account is deleted !", "Messages", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            
            catch (Exception ex)
            {
                MessageBox.Show("Error while deleting !" +ex, "Messages", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
