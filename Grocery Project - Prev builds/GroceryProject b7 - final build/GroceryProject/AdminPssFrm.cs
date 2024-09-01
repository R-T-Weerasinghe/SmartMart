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
    public partial class AdminPssFrm : Form
    {
        public AdminPssFrm()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-QGUNALP;Initial Catalog=GroceryDB;Integrated Security=True");


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

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (errorProvider.GetError(NewPssTxt) == "")
                {
                    string Pss = PssTxt.Text;
                    string NewPss = NewPssTxt.Text;

                    string querySelect = "SELECT AccountPassword FROM AccountTBL WHERE AccountName = 'Admin'";
                    string queryUpdate = "UPDATE AccountTBL SET AccountPassword = '" + NewPss + "' WHERE AccountName='Admin'";

                    SqlCommand Select = new SqlCommand(querySelect, con);
                    SqlCommand Update = new SqlCommand(queryUpdate, con);

                    con.Open();
                    string CPss = (string)Select.ExecuteScalar();
                    con.Close();

                    con.Open();
                    if (CPss == Pss)
                    {
                        Update.ExecuteNonQuery();
                        MessageBox.Show("Account updated !", "Messages", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Please check your current password !", "Messages", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please solve the errors before proceeding !", "Messages", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error while updating account ! " + ex, "Messages", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }


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
            if (NewPssTxt.UseSystemPasswordChar == true)
            {
                NewPssTxt.UseSystemPasswordChar = false;
                EyePic2.BackColor = Color.PaleGreen;

            }
            else
            {
                NewPssTxt.UseSystemPasswordChar = true;
                EyePic2.BackColor = Color.White;

            }
        }

        private void NewPssTxt_TextChanged(object sender, EventArgs e)
        {
            bool validPss = false;
            string NewPss = NewPssTxt.Text;

            if (NewPss != "")
            {
                validPss = true;
            }

            if (!validPss)
            {
                errorProvider.SetError(NewPssTxt, "Enter a valid password !");
            }
            else
            {
                errorProvider.Clear();
            }

        }
    }
}
