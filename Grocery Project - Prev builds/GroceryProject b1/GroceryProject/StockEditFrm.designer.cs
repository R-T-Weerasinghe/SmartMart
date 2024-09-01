namespace Esoft_last_project
{
    partial class StockEditFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockEditFrm));
            this.RefidChk = new System.Windows.Forms.CheckBox();
            this.NameChk = new System.Windows.Forms.CheckBox();
            this.PrizeChk = new System.Windows.Forms.CheckBox();
            this.WeightChk = new System.Windows.Forms.CheckBox();
            this.VolumeChk = new System.Windows.Forms.CheckBox();
            this.ManuChk = new System.Windows.Forms.CheckBox();
            this.ExpChk = new System.Windows.Forms.CheckBox();
            this.QtyChk = new System.Windows.Forms.CheckBox();
            this.SoldChk = new System.Windows.Forms.CheckBox();
            this.SupChk = new System.Windows.Forms.CheckBox();
            this.RefIDTxt = new System.Windows.Forms.TextBox();
            this.stockTBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groceryDBDataSet1 = new GroceryProject.GroceryDBDataSet1();
            this.QtyTxt = new System.Windows.Forms.TextBox();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.SoldTxt = new System.Windows.Forms.TextBox();
            this.SupTxt = new System.Windows.Forms.TextBox();
            this.ExpTxt = new System.Windows.Forms.TextBox();
            this.MfdTxt = new System.Windows.Forms.TextBox();
            this.VolumeTxt = new System.Windows.Forms.TextBox();
            this.WeightTxt = new System.Windows.Forms.TextBox();
            this.PrizeTxt = new System.Windows.Forms.TextBox();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.SelectBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.UnselectBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.stockTBLTableAdapter = new GroceryProject.GroceryDBDataSet1TableAdapters.StockTBLTableAdapter();
            this.SearchTxt = new System.Windows.Forms.TextBox();
            this.SearchCom = new System.Windows.Forms.ComboBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stockTBLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groceryDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RefidChk
            // 
            this.RefidChk.AutoSize = true;
            this.RefidChk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefidChk.Location = new System.Drawing.Point(77, 68);
            this.RefidChk.Name = "RefidChk";
            this.RefidChk.Size = new System.Drawing.Size(106, 20);
            this.RefidChk.TabIndex = 0;
            this.RefidChk.Text = "Reference ID";
            this.RefidChk.UseVisualStyleBackColor = true;
            // 
            // NameChk
            // 
            this.NameChk.AutoSize = true;
            this.NameChk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameChk.Location = new System.Drawing.Point(77, 96);
            this.NameChk.Name = "NameChk";
            this.NameChk.Size = new System.Drawing.Size(92, 20);
            this.NameChk.TabIndex = 1;
            this.NameChk.Text = "Item Name";
            this.NameChk.UseVisualStyleBackColor = true;
            // 
            // PrizeChk
            // 
            this.PrizeChk.AutoSize = true;
            this.PrizeChk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrizeChk.Location = new System.Drawing.Point(77, 124);
            this.PrizeChk.Name = "PrizeChk";
            this.PrizeChk.Size = new System.Drawing.Size(86, 20);
            this.PrizeChk.TabIndex = 2;
            this.PrizeChk.Text = "Item Price";
            this.PrizeChk.UseVisualStyleBackColor = true;
            // 
            // WeightChk
            // 
            this.WeightChk.AutoSize = true;
            this.WeightChk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightChk.Location = new System.Drawing.Point(77, 152);
            this.WeightChk.Name = "WeightChk";
            this.WeightChk.Size = new System.Drawing.Size(69, 20);
            this.WeightChk.TabIndex = 3;
            this.WeightChk.Text = "Weight";
            this.WeightChk.UseVisualStyleBackColor = true;
            // 
            // VolumeChk
            // 
            this.VolumeChk.AutoSize = true;
            this.VolumeChk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VolumeChk.Location = new System.Drawing.Point(77, 180);
            this.VolumeChk.Name = "VolumeChk";
            this.VolumeChk.Size = new System.Drawing.Size(73, 20);
            this.VolumeChk.TabIndex = 4;
            this.VolumeChk.Text = "Volume";
            this.VolumeChk.UseVisualStyleBackColor = true;
            // 
            // ManuChk
            // 
            this.ManuChk.AutoSize = true;
            this.ManuChk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManuChk.Location = new System.Drawing.Point(77, 208);
            this.ManuChk.Name = "ManuChk";
            this.ManuChk.Size = new System.Drawing.Size(138, 20);
            this.ManuChk.TabIndex = 5;
            this.ManuChk.Text = "Manufactured date";
            this.ManuChk.UseVisualStyleBackColor = true;
            this.ManuChk.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // ExpChk
            // 
            this.ExpChk.AutoSize = true;
            this.ExpChk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpChk.Location = new System.Drawing.Point(77, 236);
            this.ExpChk.Name = "ExpChk";
            this.ExpChk.Size = new System.Drawing.Size(94, 20);
            this.ExpChk.TabIndex = 6;
            this.ExpChk.Text = "Expiry date";
            this.ExpChk.UseVisualStyleBackColor = true;
            // 
            // QtyChk
            // 
            this.QtyChk.AutoSize = true;
            this.QtyChk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QtyChk.Location = new System.Drawing.Point(77, 266);
            this.QtyChk.Name = "QtyChk";
            this.QtyChk.Size = new System.Drawing.Size(135, 20);
            this.QtyChk.TabIndex = 7;
            this.QtyChk.Text = "Available Quantity";
            this.QtyChk.UseVisualStyleBackColor = true;
            // 
            // SoldChk
            // 
            this.SoldChk.AutoSize = true;
            this.SoldChk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoldChk.Location = new System.Drawing.Point(77, 294);
            this.SoldChk.Name = "SoldChk";
            this.SoldChk.Size = new System.Drawing.Size(90, 20);
            this.SoldChk.TabIndex = 8;
            this.SoldChk.Text = "Sold Items";
            this.SoldChk.UseVisualStyleBackColor = true;
            // 
            // SupChk
            // 
            this.SupChk.AutoSize = true;
            this.SupChk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupChk.Location = new System.Drawing.Point(77, 322);
            this.SupChk.Name = "SupChk";
            this.SupChk.Size = new System.Drawing.Size(77, 20);
            this.SupChk.TabIndex = 9;
            this.SupChk.Text = "Supplier";
            this.SupChk.UseVisualStyleBackColor = true;
            this.SupChk.CheckedChanged += new System.EventHandler(this.checkBox10_CheckedChanged);
            // 
            // RefIDTxt
            // 
            this.RefIDTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stockTBLBindingSource, "ReferenceID", true));
            this.RefIDTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefIDTxt.Location = new System.Drawing.Point(234, 66);
            this.RefIDTxt.Name = "RefIDTxt";
            this.RefIDTxt.Size = new System.Drawing.Size(153, 22);
            this.RefIDTxt.TabIndex = 10;
            // 
            // stockTBLBindingSource
            // 
            this.stockTBLBindingSource.DataMember = "StockTBL";
            this.stockTBLBindingSource.DataSource = this.groceryDBDataSet1;
            // 
            // groceryDBDataSet1
            // 
            this.groceryDBDataSet1.DataSetName = "GroceryDBDataSet1";
            this.groceryDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // QtyTxt
            // 
            this.QtyTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stockTBLBindingSource, "AvailableQty", true));
            this.QtyTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QtyTxt.Location = new System.Drawing.Point(234, 264);
            this.QtyTxt.Name = "QtyTxt";
            this.QtyTxt.Size = new System.Drawing.Size(153, 22);
            this.QtyTxt.TabIndex = 11;
            // 
            // NameTxt
            // 
            this.NameTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stockTBLBindingSource, "ItemName", true));
            this.NameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTxt.Location = new System.Drawing.Point(234, 94);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(153, 22);
            this.NameTxt.TabIndex = 12;
            // 
            // SoldTxt
            // 
            this.SoldTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stockTBLBindingSource, "SoldItems", true));
            this.SoldTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoldTxt.Location = new System.Drawing.Point(234, 292);
            this.SoldTxt.Name = "SoldTxt";
            this.SoldTxt.Size = new System.Drawing.Size(153, 22);
            this.SoldTxt.TabIndex = 13;
            // 
            // SupTxt
            // 
            this.SupTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stockTBLBindingSource, "Supplier", true));
            this.SupTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupTxt.Location = new System.Drawing.Point(234, 320);
            this.SupTxt.Name = "SupTxt";
            this.SupTxt.Size = new System.Drawing.Size(153, 22);
            this.SupTxt.TabIndex = 15;
            // 
            // ExpTxt
            // 
            this.ExpTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stockTBLBindingSource, "ExpDT", true));
            this.ExpTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpTxt.Location = new System.Drawing.Point(234, 234);
            this.ExpTxt.Name = "ExpTxt";
            this.ExpTxt.Size = new System.Drawing.Size(153, 22);
            this.ExpTxt.TabIndex = 19;
            // 
            // MfdTxt
            // 
            this.MfdTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stockTBLBindingSource, "ManuDT", true));
            this.MfdTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MfdTxt.Location = new System.Drawing.Point(234, 206);
            this.MfdTxt.Name = "MfdTxt";
            this.MfdTxt.Size = new System.Drawing.Size(153, 22);
            this.MfdTxt.TabIndex = 20;
            // 
            // VolumeTxt
            // 
            this.VolumeTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stockTBLBindingSource, "Volume", true));
            this.VolumeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VolumeTxt.Location = new System.Drawing.Point(234, 178);
            this.VolumeTxt.Name = "VolumeTxt";
            this.VolumeTxt.Size = new System.Drawing.Size(153, 22);
            this.VolumeTxt.TabIndex = 21;
            // 
            // WeightTxt
            // 
            this.WeightTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stockTBLBindingSource, "Weight", true));
            this.WeightTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightTxt.Location = new System.Drawing.Point(234, 150);
            this.WeightTxt.Name = "WeightTxt";
            this.WeightTxt.Size = new System.Drawing.Size(153, 22);
            this.WeightTxt.TabIndex = 22;
            // 
            // PrizeTxt
            // 
            this.PrizeTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stockTBLBindingSource, "ItemPrize", true));
            this.PrizeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrizeTxt.Location = new System.Drawing.Point(234, 122);
            this.PrizeTxt.Name = "PrizeTxt";
            this.PrizeTxt.Size = new System.Drawing.Size(153, 22);
            this.PrizeTxt.TabIndex = 23;
            // 
            // ClearBtn
            // 
            this.ClearBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ClearBtn.BackgroundImage")));
            this.ClearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.ClearBtn.Location = new System.Drawing.Point(16, 417);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(140, 30);
            this.ClearBtn.TabIndex = 24;
            this.ClearBtn.Text = "Clear Selections";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // SelectBtn
            // 
            this.SelectBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SelectBtn.BackgroundImage")));
            this.SelectBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SelectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.SelectBtn.Location = new System.Drawing.Point(162, 417);
            this.SelectBtn.Name = "SelectBtn";
            this.SelectBtn.Size = new System.Drawing.Size(140, 30);
            this.SelectBtn.TabIndex = 25;
            this.SelectBtn.Text = "Select All";
            this.SelectBtn.UseVisualStyleBackColor = true;
            this.SelectBtn.Click += new System.EventHandler(this.SelectBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SaveBtn.BackgroundImage")));
            this.SaveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.SaveBtn.Location = new System.Drawing.Point(16, 453);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(140, 30);
            this.SaveBtn.TabIndex = 26;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UpdateBtn.BackgroundImage")));
            this.UpdateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.UpdateBtn.Location = new System.Drawing.Point(162, 453);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(140, 30);
            this.UpdateBtn.TabIndex = 27;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DeleteBtn.BackgroundImage")));
            this.DeleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.DeleteBtn.Location = new System.Drawing.Point(308, 453);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(140, 30);
            this.DeleteBtn.TabIndex = 28;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EditBtn.BackgroundImage")));
            this.EditBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.EditBtn.Location = new System.Drawing.Point(162, 489);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(140, 30);
            this.EditBtn.TabIndex = 29;
            this.EditBtn.Text = "Quick View Database";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExitBtn.BackgroundImage")));
            this.ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.ExitBtn.Location = new System.Drawing.Point(234, 546);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(80, 30);
            this.ExitBtn.TabIndex = 30;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BackColor = System.Drawing.SystemColors.Window;
            this.bindingNavigator1.BindingSource = this.stockTBLBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(135, 380);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.bindingNavigator1.Size = new System.Drawing.Size(194, 25);
            this.bindingNavigator1.TabIndex = 31;
            this.bindingNavigator1.Text = "bindingNavigator1";
            this.bindingNavigator1.RefreshItems += new System.EventHandler(this.bindingNavigator1_RefreshItems);
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
            // UnselectBtn
            // 
            this.UnselectBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UnselectBtn.BackgroundImage")));
            this.UnselectBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UnselectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UnselectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnselectBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.UnselectBtn.Location = new System.Drawing.Point(308, 417);
            this.UnselectBtn.Name = "UnselectBtn";
            this.UnselectBtn.Size = new System.Drawing.Size(140, 30);
            this.UnselectBtn.TabIndex = 32;
            this.UnselectBtn.Text = "Unselect All";
            this.UnselectBtn.UseVisualStyleBackColor = true;
            this.UnselectBtn.Click += new System.EventHandler(this.UnselectBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BackBtn.BackgroundImage")));
            this.BackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.BackBtn.Location = new System.Drawing.Point(148, 546);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(80, 30);
            this.BackBtn.TabIndex = 33;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // stockTBLTableAdapter
            // 
            this.stockTBLTableAdapter.ClearBeforeFill = true;
            // 
            // SearchTxt
            // 
            this.SearchTxt.Location = new System.Drawing.Point(77, 22);
            this.SearchTxt.Name = "SearchTxt";
            this.SearchTxt.Size = new System.Drawing.Size(100, 20);
            this.SearchTxt.TabIndex = 34;
            this.SearchTxt.TextChanged += new System.EventHandler(this.SearchTxt_TextChanged);
            // 
            // SearchCom
            // 
            this.SearchCom.FormattingEnabled = true;
            this.SearchCom.Items.AddRange(new object[] {
            "Ref. ID",
            "Item Name"});
            this.SearchCom.Location = new System.Drawing.Point(229, 22);
            this.SearchCom.Name = "SearchCom";
            this.SearchCom.Size = new System.Drawing.Size(84, 21);
            this.SearchCom.TabIndex = 35;
            this.SearchCom.SelectedIndexChanged += new System.EventHandler(this.SearchCom_SelectedIndexChanged);
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SearchBtn.BackgroundImage")));
            this.SearchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SearchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.SearchBtn.Location = new System.Drawing.Point(319, 21);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(75, 23);
            this.SearchBtn.TabIndex = 36;
            this.SearchBtn.Text = "GO";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(183, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 37;
            this.label1.Text = "using";
            // 
            // StockEditFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(466, 587);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.SearchCom);
            this.Controls.Add(this.SearchTxt);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.UnselectBtn);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.SelectBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.PrizeTxt);
            this.Controls.Add(this.WeightTxt);
            this.Controls.Add(this.VolumeTxt);
            this.Controls.Add(this.MfdTxt);
            this.Controls.Add(this.ExpTxt);
            this.Controls.Add(this.SupTxt);
            this.Controls.Add(this.SoldTxt);
            this.Controls.Add(this.NameTxt);
            this.Controls.Add(this.QtyTxt);
            this.Controls.Add(this.RefIDTxt);
            this.Controls.Add(this.SupChk);
            this.Controls.Add(this.SoldChk);
            this.Controls.Add(this.QtyChk);
            this.Controls.Add(this.ExpChk);
            this.Controls.Add(this.ManuChk);
            this.Controls.Add(this.VolumeChk);
            this.Controls.Add(this.WeightChk);
            this.Controls.Add(this.PrizeChk);
            this.Controls.Add(this.NameChk);
            this.Controls.Add(this.RefidChk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StockEditFrm";
            this.Text = "Stock Edit Interface";
            this.Load += new System.EventHandler(this.StockEditFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stockTBLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groceryDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox RefidChk;
        private System.Windows.Forms.CheckBox NameChk;
        private System.Windows.Forms.CheckBox PrizeChk;
        private System.Windows.Forms.CheckBox WeightChk;
        private System.Windows.Forms.CheckBox VolumeChk;
        private System.Windows.Forms.CheckBox ManuChk;
        private System.Windows.Forms.CheckBox ExpChk;
        private System.Windows.Forms.CheckBox QtyChk;
        private System.Windows.Forms.CheckBox SoldChk;
        private System.Windows.Forms.CheckBox SupChk;
        private System.Windows.Forms.TextBox RefIDTxt;
        private System.Windows.Forms.TextBox QtyTxt;
        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.TextBox SoldTxt;
        private System.Windows.Forms.TextBox SupTxt;
        private System.Windows.Forms.TextBox ExpTxt;
        private System.Windows.Forms.TextBox MfdTxt;
        private System.Windows.Forms.TextBox VolumeTxt;
        private System.Windows.Forms.TextBox WeightTxt;
        private System.Windows.Forms.TextBox PrizeTxt;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button SelectBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.Button UnselectBtn;
        private System.Windows.Forms.Button BackBtn;
        private GroceryProject.GroceryDBDataSet1 groceryDBDataSet1;
        private System.Windows.Forms.BindingSource stockTBLBindingSource;
        private GroceryProject.GroceryDBDataSet1TableAdapters.StockTBLTableAdapter stockTBLTableAdapter;
        private System.Windows.Forms.TextBox SearchTxt;
        private System.Windows.Forms.ComboBox SearchCom;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Label label1;
    }
}

