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
    public partial class StaffQuickViewFrm : Form
    {
        public StaffQuickViewFrm()
        {
            InitializeComponent();
        }


        private void StaffQuickView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'groceryDBDataSet4.StockTBL' table. You can move, or remove it, as needed.
            this.stockTBLTableAdapter.Fill(this.groceryDBDataSet4.StockTBL);
            QuickViewGrid.Font = new Font("Microsoft Sans Serif", 10);
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StockViewGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
