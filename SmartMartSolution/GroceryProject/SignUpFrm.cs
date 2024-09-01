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
    public partial class SignUpFrm : Form
    {
        public SignUpFrm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=RAVINDU-PC;Initial Catalog=GroceryDB;Integrated Security=True");
        

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (errorProvider.GetError(NICTxt) == "" && errorProvider.GetError(TelTxt) == "" && errorProvider.GetError(EmailTxt) == "")
                {
                    string Acc = AccTxt.Text;
                    string Pss = PssTxt.Text;
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
                    int Balance = 0;
                    if (MaleRad.Checked == true)
                    {
                        Gender = "Male";
                    }
                    else
                    {
                        Gender = "Female";
                    }

                    string querySignup = "INSERT INTO AccountTBL VALUES('" + Acc + "','" + Pss + "','" + Type + "','" + Fname + "','" + Lname + "','" + Email + "','" + Tel + "','" + DOB + "','" + NIC + "','" + Gender + "'," + Balance + ",0)";
                    string querySelect = "SELECT AccountName FROM AccountTBL WHERE AccountName = '" + Acc + "'";
                    string queryReqAdminPss = "SELECT AccountPassword FROM AccountTBL WHERE AccountName='Admin'";

                    SqlCommand cmndSignup = new SqlCommand(querySignup, con);
                    SqlCommand cmndReqAdminPss = new SqlCommand(queryReqAdminPss, con);
                    SqlCommand cmndSelect = new SqlCommand(querySelect, con);

                    con.Open();
                    string dbAdminPss = (string)cmndReqAdminPss.ExecuteScalar();
                    con.Close();

                    con.Open();
                    string dbAcc = (string)cmndSelect.ExecuteScalar();
                    con.Close();

                    if (Acc == "" || Pss == "" || Fname == "" || Lname == "" || Email == "" || Tel == "" || DOB == "" || NIC == "")
                    {
                        MessageBox.Show("Please fill all the fields !", "Messages", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (dbAcc != Acc)
                        {
                            con.Open();
                            if (StaffRad.Checked == true)
                            {
                                string AdminPss = AdminPassTxt.Text;

                                if (dbAdminPss == AdminPss)
                                {
                                    cmndSignup.ExecuteNonQuery();
                                    MessageBox.Show("Your Account is created !", "Messages", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    LoginFrm Login = new LoginFrm();
                                    Login.Show();
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Please check the admin Password !", "Messages", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }

                            else
                            {
                                cmndSignup.ExecuteNonQuery();
                                MessageBox.Show("Your Account is created !", "Messages", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                MessageBox.Show("Please note that this account will be used as your Wallet !", "Messages", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoginFrm Login = new LoginFrm();
                                Login.Show();
                                this.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("The account name you entered is already taken ! Please try a different account name.", "Messages", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please solve the errors before proceeding !", "Messages", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while Signing Up ! " + ex, "Messages", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();

            }

        }

        private void StaffRad_CheckedChanged(object sender, EventArgs e)
        {
            if (StaffRad.Checked == true)
            {
                AdminPassTxt.Visible = true;
                AdminPssLbl.Visible = true;
                EyePic2.Visible = true;
            }
            else
            {
                AdminPassTxt.Visible = false;
                AdminPssLbl.Visible = false;
                EyePic2.Visible = false;
            }

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            WelcomeFrm Welcome = new WelcomeFrm();
            Welcome.Show();
            this.Hide();
        }

        private void EyePic_Click(object sender, EventArgs e)
        {
            if (PssTxt.UseSystemPasswordChar == true)
            {
                PssTxt.UseSystemPasswordChar = false;
                EyePic.BackColor = Color.PaleGreen;

            }
            else
            {
                PssTxt.UseSystemPasswordChar = true;
                EyePic.BackColor = Color.White;

            }
        }

        private void EyePic2_Click(object sender, EventArgs e)
        {
            if (AdminPassTxt.UseSystemPasswordChar == true)
            {
                AdminPassTxt.UseSystemPasswordChar = false;
                EyePic2.BackColor = Color.PaleGreen;

            }
            else
            {
                AdminPassTxt.UseSystemPasswordChar = true;
                EyePic2.BackColor = Color.White;
            }
        }

        private void TelTxt_TextChanged(object sender, EventArgs e)
        {
            bool validNum1 = false;
            bool validNum2 = false;
            int num;

            if (TelTxt.TextLength == 10)
            {
                validNum1 = true;
            }

            if (int.TryParse(TelTxt.Text, out num))
            {
                validNum2 = true;
            }

            if (!validNum1 || !validNum2)
            {
                errorProvider.SetError(TelTxt, "Enter a valid Telephone Number !");
            }
            else
            {
                errorProvider.Clear();
            }
        }

        private void EmailTxt_TextChanged(object sender, EventArgs e)
        {
            bool validEmail = false;
            string Email = EmailTxt.Text;
            foreach (char letter in Email)
            {
                if (letter == '@')
                {
                    validEmail = true;
                    break;
                }
            }

            if (!validEmail)
            {
                errorProvider.SetError(EmailTxt, "Enter a valid Email address !");
            }
            else
            {
                errorProvider.Clear();
            }
        }

        private void NICTxt_TextChanged(object sender, EventArgs e)
        {
            bool validNIC = false;
            string NIC = NICTxt.Text;
            if (NIC.Length == 10 || NIC.Length == 12)
            {
                validNIC = true;
            }

            if (!validNIC)
            {
                errorProvider.SetError(NICTxt, "Enter a valid NIC number !");
            }
            else
            {
                errorProvider.Clear();
            }
        }

    }
}
