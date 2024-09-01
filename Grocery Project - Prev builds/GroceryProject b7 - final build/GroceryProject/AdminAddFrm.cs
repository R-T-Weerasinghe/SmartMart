using Esoft_last_project;
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
    public partial class AdminAddFrm : Form
    {
        public AdminAddFrm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-QGUNALP;Initial Catalog=GroceryDB;Integrated Security=True");

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (errorProvider.GetError(NICTxt) == "" && errorProvider.GetError(TelTxt) == "" && errorProvider.GetError(EmailTxt) == "")
                {
                    string Acc = AccTxt.Text;
                    string Pss = PssTxt.Text;
                    string Type = "Staff";
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

                    string queryStatus = "SELECT AccountName FROM AccountTBL WHERE AccountName='" + Acc + "'";
                    SqlCommand CheckStatus = new SqlCommand(queryStatus, con);

                    con.Open();
                    string dbAcc = (string)CheckStatus.ExecuteScalar();
                    con.Close();

                    if (Acc == "" || Pss == "")
                    {
                        MessageBox.Show("Please enter a valid account name and a password !", "Messages", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (dbAcc == Acc)
                    {
                        MessageBox.Show("The account name you entered is already taken ! Please try a different account name.", "Messages", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        string querySignup = "INSERT INTO AccountTBL VALUES('" + Acc + "','" + Pss + "','" + Type + "','" + Fname + "','" + Lname + "','" + Email + "','" + Tel + "','" + DOB + "','" + NIC + "','" + Gender + "'," + Balance + ",0)";
                        SqlCommand cmndSignup = new SqlCommand(querySignup, con);

                        con.Open();
                        cmndSignup.ExecuteNonQuery();

                        MessageBox.Show("New Account is added !", "Messages", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        AdminInterfaceFrm AdminInterface = new AdminInterfaceFrm();
                        AdminInterface.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Please solve the errors before proceeding !", "Messages", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while adding the account ! " + ex, "Messages", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();

            }
        }

        private void DefaultBtn_Click(object sender, EventArgs e)
        {          
            FnameTxt.Text="Staff";
            LnameTxt.Text="Staff";
            EmailTxt.Text="123@Staff";
            TelTxt.Text="0123456789";            
            NICTxt.Text="0123456789AB";
            DateTime TDate = DateTime.Today;
            string Date = TDate.ToShortDateString();
            DOBPicker.Text = Date;

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
        private void EmailTxt_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {


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
            if (NIC.Length == 10||NIC.Length==12)
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
