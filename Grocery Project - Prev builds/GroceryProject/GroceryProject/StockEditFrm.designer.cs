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
            ((System.ComponentModel.ISupportInitialize)(this.stockTBLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groceryDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RefidChk
            // 
            this.RefidChk.AutoSize = true;
            this.RefidChk.Location = new System.Drawing.Point(45, 42);
            this.RefidChk.Name = "RefidChk";
            this.RefidChk.Size = new System.Drawing.Size(90, 17);
            this.RefidChk.TabIndex = 0;
            this.RefidChk.Text = "Reference ID";
            this.RefidChk.UseVisualStyleBackColor = true;
            // 
            // NameChk
            // 
            this.NameChk.AutoSize = true;
            this.NameChk.Location = new System.Drawing.Point(45, 82);
            this.NameChk.Name = "NameChk";
            this.NameChk.Size = new System.Drawing.Size(77, 17);
            this.NameChk.TabIndex = 1;
            this.NameChk.Text = "Item Name";
            this.NameChk.UseVisualStyleBackColor = true;
            // 
            // PrizeChk
            // 
            this.PrizeChk.AutoSize = true;
            this.PrizeChk.Location = new System.Drawing.Point(45, 118);
            this.PrizeChk.Name = "PrizeChk";
            this.PrizeChk.Size = new System.Drawing.Size(73, 17);
            this.PrizeChk.TabIndex = 2;
            this.PrizeChk.Text = "Item Price";
            this.PrizeChk.UseVisualStyleBackColor = true;
            // 
            // WeightChk
            // 
            this.WeightChk.AutoSize = true;
            this.WeightChk.Location = new System.Drawing.Point(45, 151);
            this.WeightChk.Name = "WeightChk";
            this.WeightChk.Size = new System.Drawing.Size(60, 17);
            this.WeightChk.TabIndex = 3;
            this.WeightChk.Text = "Weight";
            this.WeightChk.UseVisualStyleBackColor = true;
            // 
            // VolumeChk
            // 
            this.VolumeChk.AutoSize = true;
            this.VolumeChk.Location = new System.Drawing.Point(45, 187);
            this.VolumeChk.Name = "VolumeChk";
            this.VolumeChk.Size = new System.Drawing.Size(61, 17);
            this.VolumeChk.TabIndex = 4;
            this.VolumeChk.Text = "Volume";
            this.VolumeChk.UseVisualStyleBackColor = true;
            // 
            // ManuChk
            // 
            this.ManuChk.AutoSize = true;
            this.ManuChk.Location = new System.Drawing.Point(45, 224);
            this.ManuChk.Name = "ManuChk";
            this.ManuChk.Size = new System.Drawing.Size(116, 17);
            this.ManuChk.TabIndex = 5;
            this.ManuChk.Text = "Manufactured date";
            this.ManuChk.UseVisualStyleBackColor = true;
            this.ManuChk.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // ExpChk
            // 
            this.ExpChk.AutoSize = true;
            this.ExpChk.Location = new System.Drawing.Point(45, 264);
            this.ExpChk.Name = "ExpChk";
            this.ExpChk.Size = new System.Drawing.Size(78, 17);
            this.ExpChk.TabIndex = 6;
            this.ExpChk.Text = "Expiry date";
            this.ExpChk.UseVisualStyleBackColor = true;
            // 
            // QtyChk
            // 
            this.QtyChk.AutoSize = true;
            this.QtyChk.Location = new System.Drawing.Point(45, 308);
            this.QtyChk.Name = "QtyChk";
            this.QtyChk.Size = new System.Drawing.Size(111, 17);
            this.QtyChk.TabIndex = 7;
            this.QtyChk.Text = "Available Quantity";
            this.QtyChk.UseVisualStyleBackColor = true;
            // 
            // SoldChk
            // 
            this.SoldChk.AutoSize = true;
            this.SoldChk.Location = new System.Drawing.Point(45, 349);
            this.SoldChk.Name = "SoldChk";
            this.SoldChk.Size = new System.Drawing.Size(75, 17);
            this.SoldChk.TabIndex = 8;
            this.SoldChk.Text = "Sold Items";
            this.SoldChk.UseVisualStyleBackColor = true;
            // 
            // SupChk
            // 
            this.SupChk.AutoSize = true;
            this.SupChk.Location = new System.Drawing.Point(45, 388);
            this.SupChk.Name = "SupChk";
            this.SupChk.Size = new System.Drawing.Size(64, 17);
            this.SupChk.TabIndex = 9;
            this.SupChk.Text = "Supplier";
            this.SupChk.UseVisualStyleBackColor = true;
            this.SupChk.CheckedChanged += new System.EventHandler(this.checkBox10_CheckedChanged);
            // 
            // RefIDTxt
            // 
            this.RefIDTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stockTBLBindingSource, "ReferenceID", true));
            this.RefIDTxt.Location = new System.Drawing.Point(224, 39);
            this.RefIDTxt.Name = "RefIDTxt";
            this.RefIDTxt.Size = new System.Drawing.Size(153, 20);
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
            this.QtyTxt.Location = new System.Drawing.Point(224, 305);
            this.QtyTxt.Name = "QtyTxt";
            this.QtyTxt.Size = new System.Drawing.Size(153, 20);
            this.QtyTxt.TabIndex = 11;
            // 
            // NameTxt
            // 
            this.NameTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stockTBLBindingSource, "ItemName", true));
            this.NameTxt.Location = new System.Drawing.Point(224, 80);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(153, 20);
            this.NameTxt.TabIndex = 12;
            // 
            // SoldTxt
            // 
            this.SoldTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stockTBLBindingSource, "SoldItems", true));
            this.SoldTxt.Location = new System.Drawing.Point(224, 349);
            this.SoldTxt.Name = "SoldTxt";
            this.SoldTxt.Size = new System.Drawing.Size(153, 20);
            this.SoldTxt.TabIndex = 13;
            // 
            // SupTxt
            // 
            this.SupTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stockTBLBindingSource, "Supplier", true));
            this.SupTxt.Location = new System.Drawing.Point(224, 388);
            this.SupTxt.Name = "SupTxt";
            this.SupTxt.Size = new System.Drawing.Size(153, 20);
            this.SupTxt.TabIndex = 15;
            // 
            // ExpTxt
            // 
            this.ExpTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stockTBLBindingSource, "ExpDT", true));
            this.ExpTxt.Location = new System.Drawing.Point(226, 264);
            this.ExpTxt.Name = "ExpTxt";
            this.ExpTxt.Size = new System.Drawing.Size(153, 20);
            this.ExpTxt.TabIndex = 19;
            // 
            // MfdTxt
            // 
            this.MfdTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stockTBLBindingSource, "ManuDT", true));
            this.MfdTxt.Location = new System.Drawing.Point(224, 224);
            this.MfdTxt.Name = "MfdTxt";
            this.MfdTxt.Size = new System.Drawing.Size(153, 20);
            this.MfdTxt.TabIndex = 20;
            // 
            // VolumeTxt
            // 
            this.VolumeTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stockTBLBindingSource, "Volume", true));
            this.VolumeTxt.Location = new System.Drawing.Point(224, 187);
            this.VolumeTxt.Name = "VolumeTxt";
            this.VolumeTxt.Size = new System.Drawing.Size(153, 20);
            this.VolumeTxt.TabIndex = 21;
            // 
            // WeightTxt
            // 
            this.WeightTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stockTBLBindingSource, "Weight", true));
            this.WeightTxt.Location = new System.Drawing.Point(224, 151);
            this.WeightTxt.Name = "WeightTxt";
            this.WeightTxt.Size = new System.Drawing.Size(153, 20);
            this.WeightTxt.TabIndex = 22;
            // 
            // PrizeTxt
            // 
            this.PrizeTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stockTBLBindingSource, "ItemPrize", true));
            this.PrizeTxt.Location = new System.Drawing.Point(224, 118);
            this.PrizeTxt.Name = "PrizeTxt";
            this.PrizeTxt.Size = new System.Drawing.Size(153, 20);
            this.PrizeTxt.TabIndex = 23;
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(68, 461);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(88, 55);
            this.ClearBtn.TabIndex = 24;
            this.ClearBtn.Text = "Clear Selections";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // SelectBtn
            // 
            this.SelectBtn.Location = new System.Drawing.Point(181, 461);
            this.SelectBtn.Name = "SelectBtn";
            this.SelectBtn.Size = new System.Drawing.Size(95, 55);
            this.SelectBtn.TabIndex = 25;
            this.SelectBtn.Text = "Select All";
            this.SelectBtn.UseVisualStyleBackColor = true;
            this.SelectBtn.Click += new System.EventHandler(this.SelectBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(93, 546);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(54, 29);
            this.SaveBtn.TabIndex = 26;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(204, 546);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(54, 29);
            this.UpdateBtn.TabIndex = 27;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(312, 546);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(54, 29);
            this.DeleteBtn.TabIndex = 28;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(151, 591);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(153, 29);
            this.EditBtn.TabIndex = 29;
            this.EditBtn.Text = "Quick View Database";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(125, 637);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(90, 29);
            this.ExitBtn.TabIndex = 30;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
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
            this.bindingNavigator1.Location = new System.Drawing.Point(125, 421);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
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
            this.UnselectBtn.Location = new System.Drawing.Point(287, 461);
            this.UnselectBtn.Name = "UnselectBtn";
            this.UnselectBtn.Size = new System.Drawing.Size(110, 55);
            this.UnselectBtn.TabIndex = 32;
            this.UnselectBtn.Text = "Unselect All";
            this.UnselectBtn.UseVisualStyleBackColor = true;
            this.UnselectBtn.Click += new System.EventHandler(this.UnselectBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(243, 637);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(90, 29);
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
            this.SearchTxt.Location = new System.Drawing.Point(125, 12);
            this.SearchTxt.Name = "SearchTxt";
            this.SearchTxt.Size = new System.Drawing.Size(100, 20);
            this.SearchTxt.TabIndex = 34;
            // 
            // SearchCom
            // 
            this.SearchCom.FormattingEnabled = true;
            this.SearchCom.Items.AddRange(new object[] {
            "Ref. ID",
            "Item Name"});
            this.SearchCom.Location = new System.Drawing.Point(232, 11);
            this.SearchCom.Name = "SearchCom";
            this.SearchCom.Size = new System.Drawing.Size(84, 21);
            this.SearchCom.TabIndex = 35;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(322, 9);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(75, 23);
            this.SearchBtn.TabIndex = 36;
            this.SearchBtn.Text = "GO";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // StockEditFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 690);
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
    }
}

