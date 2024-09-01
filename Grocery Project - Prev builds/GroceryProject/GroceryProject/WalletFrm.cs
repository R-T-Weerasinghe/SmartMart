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
    public partial class WalletFrm : Form
    {
        public WalletFrm()
        {
            InitializeComponent();
        }
        SqlConnection con1 = new SqlConnection(@"Data Source=DESKTOP-QGUNALP;Initial Catalog=GroceryDB;Integrated Security=True");
        SqlConnection con2 = new SqlConnection(@"Data Source=DESKTOP-QGUNALP;Initial Catalog=GroceryDB;Integrated Security=True");



        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            CustomerInterfaceFrm CustomerInterface = new CustomerInterfaceFrm();
            CustomerInterface.Show();
            this.Close();


        }

        private void WalletFrm_Load(object sender, EventArgs e)
        {
            try
            {
                con1.Open();
                string Acc = LoginFrm.Acc;
                //string Pre;
                //string PrevBal;
                string GotBal;

                //Fetching data for the balance 
                string querySelectBalance = "SELECT AvailableBalance FROM AccountTBL WHERE AccountName='" + Acc + "'";
                SqlCommand cmndSelectBalance = new SqlCommand(querySelectBalance, con1);
                SqlDataReader ReadBalance = cmndSelectBalance.ExecuteReader();
                while (ReadBalance.Read())
                {
                    GotBal = ReadBalance[0].ToString();
                    BalLbl.Text = GotBal;
                }

                //Fetching data for the previous order
                //string querySelectPrevOrder = "SELECT Value FROM OrderTBL WHERE PlacedBy='" + Acc + "'";
                //SqlCommand cmndSelectPrevOrder = new SqlCommand(querySelectPrevOrder, con2);
                //SqlDataReader ReadPrevOrder = cmndSelectPrevOrder.ExecuteReader();

                //NOT COMPLETED !!!

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error while fetching data ! " + ex, "Messages", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con1.Close();
                
            }
        }

        private void AccLbl_Click(object sender, EventArgs e)
        {

        }

        private void BalLbl_Click(object sender, EventArgs e)
        {

        }

        private void P500Btn_Click(object sender, EventArgs e)
        {
            try
            {
                con1.Open();               
                string Acc = LoginFrm.Acc;
                int Bal = int.Parse(BalLbl.Text);
                Bal = Bal + 500;
                string queryUpdate = "UPDATE AccountTBL SET AvailableBalance = " + Bal + " WHERE AccountName='" + Acc + "'";
                SqlCommand cmndUpdateBal = new SqlCommand(queryUpdate, con1);
                cmndUpdateBal.ExecuteNonQuery();
                MessageBox.Show("Rs.500 has been added to your account !", "Messages", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                MessageBox.Show("Your available balance is " + Bal, "Messages", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                BalLbl.Text = Bal.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while adding credits ! " + ex, "Messages", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con1.Close();
            }
        }

        private void P1000Btn_Click(object sender, EventArgs e)
        {
            try
            {
                con1.Open();
                string Acc = LoginFrm.Acc;
                int Bal = int.Parse(BalLbl.Text);
                Bal = Bal + 1000;
                string queryUpdate = "UPDATE AccountTBL SET AvailableBalance = " + Bal + " WHERE AccountName='" + Acc + "'";
                SqlCommand cmndUpdateBal = new SqlCommand(queryUpdate, con1);
                cmndUpdateBal.ExecuteNonQuery();
                MessageBox.Show("Rs.1000 has been added to your account !", "Messages", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                MessageBox.Show("Your available balance is " + Bal, "Messages", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                BalLbl.Text = Bal.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while adding credits ! " + ex, "Messages", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con1.Close();
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {

            try
            {
                con1.Open();
                string Acc = LoginFrm.Acc;
                int Bal = int.Parse(BalLbl.Text);
                int Amount = int.Parse(AmountTxt.Text);
                Bal = Bal + Amount;
                string queryUpdate = "UPDATE AccountTBL SET AvailableBalance = " + Bal + " WHERE AccountName='" + Acc + "'";
                SqlCommand cmndUpdateBal = new SqlCommand(queryUpdate, con1);
                cmndUpdateBal.ExecuteNonQuery();
                MessageBox.Show("Rs."+Amount+" has been added to your account !", "Messages", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                MessageBox.Show("Your available balance is " + Bal, "Messages", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                BalLbl.Text = Bal.ToString();
                AmountTxt.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while adding credits ! " + ex, "Messages", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con1.Close();
            }
        }

        private void PrevBtn_Click(object sender, EventArgs e)
        {
            PreviousPaymentsFrm PreviousPayments = new PreviousPaymentsFrm();
            PreviousPayments.Show();
            this.Hide();
        }

      
            
    }
}
