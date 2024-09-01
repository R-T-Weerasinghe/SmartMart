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
    public partial class StaffStockViewFrm : Form
    {
        public StaffStockViewFrm()
        {
            InitializeComponent();
        }

        public static string SelectedRefID;

        private void EditDBFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'groceryDBDataSet4.StockTBL' table. You can move, or remove it, as needed.
            this.stockTBLTableAdapter.Fill(this.groceryDBDataSet4.StockTBL);

            //changing the selection mode
            this.StockViewGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.StockViewGrid.MultiSelect = false;

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            StaffInterfaceFrm StaffInterface = new StaffInterfaceFrm();
            StaffInterface.Show();
            this.Close();
        }

        private void StockViewGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (StockViewGrid.SelectedCells.Count > 0)
            {
                SelectedRefID = StockViewGrid.SelectedCells[0].Value.ToString();
                StockEditFrm StockEdit = new StockEditFrm();
                StockEdit.Show();
                this.Hide();
            }
        }

        private void NewBtn_Click(object sender, EventArgs e)
        {
            SelectedRefID = "";
            StockEditFrm StockEdit = new StockEditFrm();
            StockEdit.Show();
            this.Close();
        }


    }
}
