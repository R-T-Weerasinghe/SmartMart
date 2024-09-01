using Esoft_last_project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroceryProject
{
    public partial class StockViewFrm : Form
    {
        public StockViewFrm()
        {
            InitializeComponent();
        }

        public static string RefID;

        private void StockViewFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'groceryDBDataSet3.StockTBL' table. You can move, or remove it, as needed.
            this.stockTBLTableAdapter.Fill(this.groceryDBDataSet3.StockTBL);

            //changing the selection mode
            this.StockViewGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.StockViewGrid.MultiSelect = false;
        }

        private void StockViewGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (StockViewGrid.SelectedCells.Count > 0)
            {
                RefID = StockViewGrid.SelectedCells[1].Value.ToString();               
                ItemPreviewFrm ItemPreview = new ItemPreviewFrm();
                ItemPreview.Show();
                this.Hide();
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            CustomerInterfaceFrm CustomerInterface = new CustomerInterfaceFrm();
            CustomerInterface.Show();
            this.Close();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ViewBtn_Click(object sender, EventArgs e)
        {
            CartFrm Cart = new CartFrm();
            Cart.Show();
            this.Close();
        }
    }
}
