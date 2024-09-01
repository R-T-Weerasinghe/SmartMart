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
namespace Esoft_last_project
{
    public partial class LoginFrm : Form
    {
        public LoginFrm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-QGUNALP;Initial Catalog=GroceryDB;Integrated Security=True");

        public static string Acc;   // Static = modifiable ~ const = unmodifiable
        //will be accessed in WalletFrm

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                Acc = AccTxt.Text;                
                string Pss = PssTxt.Text;
                string queryLoginCheck = "SELECT AccountPassword,AccountType FROM AccountTBL WHERE AccountName='" + Acc + "'";
                SqlCommand cmnd = new SqlCommand(queryLoginCheck, con);
                SqlDataReader r = cmnd.ExecuteReader();

                if (r.HasRows)
                {
                    while (r.Read())
                    {
                        string CPss = r[0].ToString();  //CPass is for CheckPass
                        string Type = r[1].ToString();
                        if (CPss == Pss)
                        {
                            if (Type == "Staff"||Type=="Admin")
                            {
                                MessageBox.Show("Login Succeeded !", "Messages", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                StaffInterfaceFrm StaffFrm = new StaffInterfaceFrm();
                                StaffFrm.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Login Succeeded !", "Messages", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                CustomerInterfaceFrm CustFrm = new CustomerInterfaceFrm();
                                CustFrm.Show();
                                this.Hide();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Your Password is incorrect !", "Messages", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No account found ! ", "Messages", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while logging ! Please check your account name or refer the following details                " + ex, "Messages", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            
            WelcomeFrm WelcomeFrm = new WelcomeFrm();
            this.Close();
            WelcomeFrm.Show();
        }
    }
}
