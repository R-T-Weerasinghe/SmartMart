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
    public partial class AdminViewFrm : Form
    {
        public AdminViewFrm()
        {
            InitializeComponent();

            SqlConnection con = new SqlConnection(@"Data Source=RAVINDU-PC;Initial Catalog=GroceryDB;Integrated Security=True");


            try
            {
                string querySelect = "SELECT UserID,AccountName,Email,TelNum FROM AccountTBL WHERE AccountType='Staff'";
                string queryCount = "SELECT COUNT(*) FROM AccountTBL WHERE AccountType='Staff'";

                SqlCommand cmndSelect = new SqlCommand(querySelect, con);
                SqlCommand cmndCount = new SqlCommand(queryCount, con);

                con.Open();
                int count = (int)cmndCount.ExecuteScalar(); //using a scalar coz we only need a single value(means count)
                con.Close();                                //we can get multiple values(or objects) if we use ExecuteReader BUT it is not necessary here

                AccountGrid.Columns.Add("UserID", "User ID");   //first one is the columnname. Second one is the header name
                AccountGrid.Columns.Add("Name", "Name");
                AccountGrid.Columns.Add("Email", "Email");
                AccountGrid.Columns.Add("TP", "Telephone No.");

                con.Open();
                SqlDataReader r = cmndSelect.ExecuteReader();
                while (r.Read())
                {
                    for (int i = 0; i < count; i = i + 4)
                    {
                        AccountGrid.Rows.Add(new object[] { r[i], r[i + 1], r[i + 2], r[i + 3] });   //assigning datareader array values to rows

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while retrieving data ! " + ex, "Messages", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        public static int SelectedID;


        private void AdminViewFrm_Load(object sender, EventArgs e)
        {
            this.AccountGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.AccountGrid.MultiSelect = false;

            //Increasing the font size
            this.AccountGrid.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);
        }

        private void AccountGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (AccountGrid.SelectedCells.Count > 0)
            {
                SelectedID = (int)AccountGrid.SelectedCells[0].Value;
                AdminRemoveFrm AdminRemove = new AdminRemoveFrm();
                AdminRemove.Show();
                this.Hide();
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            AdminInterfaceFrm AdminInterface = new AdminInterfaceFrm();
            AdminInterface.Show();
            this.Close();

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
