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
    public partial class EditDBFrm : Form
    {
        public EditDBFrm()
        {
            InitializeComponent();
        }
        SqlConnection con1 = new SqlConnection(@"Data Source=DESKTOP-QGUNALP;Initial Catalog=GroceryDB;Integrated Security=True");

        private void EditDBFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'groceryDBDataSet4.StockTBL' table. You can move, or remove it, as needed.
            this.stockTBLTableAdapter.Fill(this.groceryDBDataSet4.StockTBL);


        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            StockEditFrm StockEdit = new StockEditFrm();
            StockEdit.Show();
            this.Close();
        }


    }
}
