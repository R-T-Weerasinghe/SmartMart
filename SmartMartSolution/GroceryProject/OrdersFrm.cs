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
    public partial class OrdersFrm : Form
    {
        public OrdersFrm()
        {
            InitializeComponent();
        }
        SqlConnection con1 = new SqlConnection(@"Data Source=RAVINDU-PC;Initial Catalog=GroceryDB;Integrated Security=True");

        private void OrdersFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'groceryDBDataSet5.OrderTBL' table. You can move, or remove it, as needed.
            this.orderTBLTableAdapter.Fill(this.groceryDBDataSet5.OrderTBL);

        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Are you sure ? ", "Messages", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    con1.Open();
                    string queryRemove = "DELETE FROM OrderTBL";
                    SqlCommand Remove = new SqlCommand(queryRemove, con1);
                    Remove.ExecuteNonQuery();
                    MessageBox.Show("All items were removed ! ", "Messages", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //updating the grid

                    this.orderTBLTableAdapter.Fill(this.groceryDBDataSet5.OrderTBL);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while removing ! "+ex, "Messages", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {

        }

        private void OrdersGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
