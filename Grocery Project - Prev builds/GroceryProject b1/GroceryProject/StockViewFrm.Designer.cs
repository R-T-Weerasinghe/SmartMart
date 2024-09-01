namespace GroceryProject
{
    partial class StockViewFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockViewFrm));
            this.searchtxt = new System.Windows.Forms.TextBox();
            this.searchbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.RefidTxt = new System.Windows.Forms.TextBox();
            this.stockTBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groceryDBDataSet = new GroceryProject.GroceryDBDataSet();
            this.volumeTxt = new System.Windows.Forms.TextBox();
            this.mdtTxt = new System.Windows.Forms.TextBox();
            this.edtTxt = new System.Windows.Forms.TextBox();
            this.aQtyTxt = new System.Windows.Forms.TextBox();
            this.rQtyTxt = new System.Windows.Forms.TextBox();
            this.tAmountTxt = new System.Windows.Forms.TextBox();
            this.weightTxt = new System.Windows.Forms.TextBox();
            this.prizeTxt = new System.Windows.Forms.TextBox();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.CartBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.dbViewBtn = new System.Windows.Forms.Button();
            this.stockTBLTableAdapter = new GroceryProject.GroceryDBDataSetTableAdapters.StockTBLTableAdapter();
            this.stockTBLBindingNavigater = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.BackBtn = new System.Windows.Forms.Button();
            this.CartViewBtn = new System.Windows.Forms.Button();
            this.SearchCom = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stockTBLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groceryDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockTBLBindingNavigater)).BeginInit();
            this.stockTBLBindingNavigater.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchtxt
            // 
            this.searchtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchtxt.Location = new System.Drawing.Point(235, 24);
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.Size = new System.Drawing.Size(142, 21);
            this.searchtxt.TabIndex = 0;
            this.searchtxt.Text = "Search here";
            this.searchtxt.TextChanged += new System.EventHandler(this.searchtxt_TextChanged);
            // 
            // searchbtn
            // 
            this.searchbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchbtn.BackgroundImage")));
            this.searchbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbtn.ForeColor = System.Drawing.SystemColors.Window;
            this.searchbtn.Location = new System.Drawing.Point(502, 24);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(56, 23);
            this.searchbtn.TabIndex = 1;
            this.searchbtn.Text = "GO";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Reference ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Item Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Item Prize";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Weight";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Volume";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(384, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Manufactured Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(383, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Expire Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(383, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Available Quantity";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(383, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 16);
            this.label9.TabIndex = 10;
            this.label9.Text = "Required Quantity";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(383, 191);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 16);
            this.label10.TabIndex = 11;
            this.label10.Text = "Total amount";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // RefidTxt
            // 
            this.RefidTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stockTBLBindingSource, "ReferenceID", true));
            this.RefidTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefidTxt.Location = new System.Drawing.Point(159, 76);
            this.RefidTxt.Name = "RefidTxt";
            this.RefidTxt.Size = new System.Drawing.Size(172, 22);
            this.RefidTxt.TabIndex = 12;
            // 
            // stockTBLBindingSource
            // 
            this.stockTBLBindingSource.DataMember = "StockTBL";
            this.stockTBLBindingSource.DataSource = this.groceryDBDataSet;
            // 
            // groceryDBDataSet
            // 
            this.groceryDBDataSet.DataSetName = "GroceryDBDataSet";
            this.groceryDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // volumeTxt
            // 
            this.volumeTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stockTBLBindingSource, "Volume", true));
            this.volumeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volumeTxt.Location = new System.Drawing.Point(159, 188);
            this.volumeTxt.Name = "volumeTxt";
            this.volumeTxt.Size = new System.Drawing.Size(172, 22);
            this.volumeTxt.TabIndex = 13;
            // 
            // mdtTxt
            // 
            this.mdtTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stockTBLBindingSource, "ManuDT", true));
            this.mdtTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdtTxt.Location = new System.Drawing.Point(553, 76);
            this.mdtTxt.Name = "mdtTxt";
            this.mdtTxt.Size = new System.Drawing.Size(172, 22);
            this.mdtTxt.TabIndex = 14;
            // 
            // edtTxt
            // 
            this.edtTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stockTBLBindingSource, "ExpDT", true));
            this.edtTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtTxt.Location = new System.Drawing.Point(553, 104);
            this.edtTxt.Name = "edtTxt";
            this.edtTxt.Size = new System.Drawing.Size(172, 22);
            this.edtTxt.TabIndex = 16;
            // 
            // aQtyTxt
            // 
            this.aQtyTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stockTBLBindingSource, "AvailableQty", true));
            this.aQtyTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aQtyTxt.Location = new System.Drawing.Point(553, 132);
            this.aQtyTxt.Name = "aQtyTxt";
            this.aQtyTxt.Size = new System.Drawing.Size(172, 22);
            this.aQtyTxt.TabIndex = 17;
            // 
            // rQtyTxt
            // 
            this.rQtyTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rQtyTxt.Location = new System.Drawing.Point(553, 160);
            this.rQtyTxt.Name = "rQtyTxt";
            this.rQtyTxt.Size = new System.Drawing.Size(172, 22);
            this.rQtyTxt.TabIndex = 18;
            this.rQtyTxt.TextChanged += new System.EventHandler(this.rQtyTxt_TextChanged);
            // 
            // tAmountTxt
            // 
            this.tAmountTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tAmountTxt.Location = new System.Drawing.Point(553, 188);
            this.tAmountTxt.Name = "tAmountTxt";
            this.tAmountTxt.Size = new System.Drawing.Size(172, 22);
            this.tAmountTxt.TabIndex = 19;
            // 
            // weightTxt
            // 
            this.weightTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stockTBLBindingSource, "Weight", true));
            this.weightTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightTxt.Location = new System.Drawing.Point(159, 160);
            this.weightTxt.Name = "weightTxt";
            this.weightTxt.Size = new System.Drawing.Size(172, 22);
            this.weightTxt.TabIndex = 20;
            // 
            // prizeTxt
            // 
            this.prizeTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stockTBLBindingSource, "ItemPrize", true));
            this.prizeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prizeTxt.Location = new System.Drawing.Point(159, 132);
            this.prizeTxt.Name = "prizeTxt";
            this.prizeTxt.Size = new System.Drawing.Size(172, 22);
            this.prizeTxt.TabIndex = 21;
            // 
            // nameTxt
            // 
            this.nameTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stockTBLBindingSource, "ItemName", true));
            this.nameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTxt.Location = new System.Drawing.Point(159, 104);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(172, 22);
            this.nameTxt.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(337, 163);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 16);
            this.label11.TabIndex = 23;
            this.label11.Text = "g";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(337, 191);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(22, 16);
            this.label12.TabIndex = 24;
            this.label12.Text = "ml";
            // 
            // CartBtn
            // 
            this.CartBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CartBtn.BackgroundImage")));
            this.CartBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CartBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.CartBtn.Location = new System.Drawing.Point(455, 296);
            this.CartBtn.Name = "CartBtn";
            this.CartBtn.Size = new System.Drawing.Size(140, 30);
            this.CartBtn.TabIndex = 26;
            this.CartBtn.Text = "Add to Cart";
            this.CartBtn.UseVisualStyleBackColor = true;
            this.CartBtn.Click += new System.EventHandler(this.CartBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExitBtn.BackgroundImage")));
            this.ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.ExitBtn.Location = new System.Drawing.Point(381, 348);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(80, 30);
            this.ExitBtn.TabIndex = 27;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // dbViewBtn
            // 
            this.dbViewBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dbViewBtn.BackgroundImage")));
            this.dbViewBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dbViewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dbViewBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbViewBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.dbViewBtn.Location = new System.Drawing.Point(163, 296);
            this.dbViewBtn.Name = "dbViewBtn";
            this.dbViewBtn.Size = new System.Drawing.Size(140, 30);
            this.dbViewBtn.TabIndex = 28;
            this.dbViewBtn.Text = "Quick View Database";
            this.dbViewBtn.UseVisualStyleBackColor = true;
            this.dbViewBtn.Click += new System.EventHandler(this.dbViewBtn_Click);
            // 
            // stockTBLTableAdapter
            // 
            this.stockTBLTableAdapter.ClearBeforeFill = true;
            // 
            // stockTBLBindingNavigater
            // 
            this.stockTBLBindingNavigater.AddNewItem = null;
            this.stockTBLBindingNavigater.BackColor = System.Drawing.SystemColors.Window;
            this.stockTBLBindingNavigater.BindingSource = this.stockTBLBindingSource;
            this.stockTBLBindingNavigater.CountItem = this.bindingNavigatorCountItem;
            this.stockTBLBindingNavigater.DeleteItem = null;
            this.stockTBLBindingNavigater.Dock = System.Windows.Forms.DockStyle.None;
            this.stockTBLBindingNavigater.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.stockTBLBindingNavigater.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem});
            this.stockTBLBindingNavigater.Location = new System.Drawing.Point(284, 255);
            this.stockTBLBindingNavigater.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.stockTBLBindingNavigater.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.stockTBLBindingNavigater.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.stockTBLBindingNavigater.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.stockTBLBindingNavigater.Name = "stockTBLBindingNavigater";
            this.stockTBLBindingNavigater.PositionItem = this.bindingNavigatorPositionItem;
            this.stockTBLBindingNavigater.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.stockTBLBindingNavigater.Size = new System.Drawing.Size(194, 25);
            this.stockTBLBindingNavigater.TabIndex = 29;
            this.stockTBLBindingNavigater.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // BackBtn
            // 
            this.BackBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BackBtn.BackgroundImage")));
            this.BackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.BackBtn.Location = new System.Drawing.Point(297, 348);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(80, 30);
            this.BackBtn.TabIndex = 30;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // CartViewBtn
            // 
            this.CartViewBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CartViewBtn.BackgroundImage")));
            this.CartViewBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CartViewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CartViewBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CartViewBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.CartViewBtn.Location = new System.Drawing.Point(309, 296);
            this.CartViewBtn.Name = "CartViewBtn";
            this.CartViewBtn.Size = new System.Drawing.Size(140, 30);
            this.CartViewBtn.TabIndex = 31;
            this.CartViewBtn.Text = "View Cart";
            this.CartViewBtn.UseVisualStyleBackColor = true;
            this.CartViewBtn.Click += new System.EventHandler(this.CartViewBtn_Click);
            // 
            // SearchCom
            // 
            this.SearchCom.FormattingEnabled = true;
            this.SearchCom.Items.AddRange(new object[] {
            "Ref. ID",
            "Item Name"});
            this.SearchCom.Location = new System.Drawing.Point(429, 24);
            this.SearchCom.Name = "SearchCom";
            this.SearchCom.Size = new System.Drawing.Size(67, 21);
            this.SearchCom.TabIndex = 32;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(383, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 16);
            this.label13.TabIndex = 38;
            this.label13.Text = "using";
            // 
            // StockViewFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(773, 390);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.SearchCom);
            this.Controls.Add(this.CartViewBtn);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.stockTBLBindingNavigater);
            this.Controls.Add(this.dbViewBtn);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.CartBtn);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.prizeTxt);
            this.Controls.Add(this.weightTxt);
            this.Controls.Add(this.tAmountTxt);
            this.Controls.Add(this.rQtyTxt);
            this.Controls.Add(this.aQtyTxt);
            this.Controls.Add(this.edtTxt);
            this.Controls.Add(this.mdtTxt);
            this.Controls.Add(this.volumeTxt);
            this.Controls.Add(this.RefidTxt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.searchtxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StockViewFrm";
            this.Text = "Customer Interface";
            this.Load += new System.EventHandler(this.customerfrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stockTBLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groceryDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockTBLBindingNavigater)).EndInit();
            this.stockTBLBindingNavigater.ResumeLayout(false);
            this.stockTBLBindingNavigater.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchtxt;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox RefidTxt;
        private System.Windows.Forms.TextBox volumeTxt;
        private System.Windows.Forms.TextBox mdtTxt;
        private System.Windows.Forms.TextBox edtTxt;
        private System.Windows.Forms.TextBox aQtyTxt;
        private System.Windows.Forms.TextBox rQtyTxt;
        private System.Windows.Forms.TextBox tAmountTxt;
        private System.Windows.Forms.TextBox weightTxt;
        private System.Windows.Forms.TextBox prizeTxt;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button CartBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button dbViewBtn;
        private GroceryDBDataSet groceryDBDataSet;
        private System.Windows.Forms.BindingSource stockTBLBindingSource;
        private GroceryDBDataSetTableAdapters.StockTBLTableAdapter stockTBLTableAdapter;
        private System.Windows.Forms.BindingNavigator stockTBLBindingNavigater;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button CartViewBtn;
        private System.Windows.Forms.ComboBox SearchCom;
        private System.Windows.Forms.Label label13;
    }
}

