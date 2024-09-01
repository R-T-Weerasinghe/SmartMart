namespace GroceryProject
{
    partial class StaffStockViewFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffStockViewFrm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.StockViewGrid = new System.Windows.Forms.DataGridView();
            this.referenceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemPictureDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemPrizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightVolumeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manuDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availableQtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soldItemsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockTBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groceryDBDataSet4 = new GroceryProject.GroceryDBDataSet4();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.stockTBLTableAdapter = new GroceryProject.GroceryDBDataSet4TableAdapters.StockTBLTableAdapter();
            this.NewBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StockViewGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockTBLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groceryDBDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // StockViewGrid
            // 
            this.StockViewGrid.AllowUserToAddRows = false;
            this.StockViewGrid.AllowUserToDeleteRows = false;
            this.StockViewGrid.AutoGenerateColumns = false;
            this.StockViewGrid.BackgroundColor = System.Drawing.Color.MintCream;
            this.StockViewGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.StockViewGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StockViewGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.referenceIDDataGridViewTextBoxColumn,
            this.itemPictureDataGridViewImageColumn,
            this.itemNameDataGridViewTextBoxColumn,
            this.itemDescriptionDataGridViewTextBoxColumn,
            this.itemPrizeDataGridViewTextBoxColumn,
            this.weightVolumeDataGridViewTextBoxColumn,
            this.manuDTDataGridViewTextBoxColumn,
            this.expDTDataGridViewTextBoxColumn,
            this.availableQtyDataGridViewTextBoxColumn,
            this.soldItemsDataGridViewTextBoxColumn,
            this.supplierDataGridViewTextBoxColumn});
            this.StockViewGrid.DataSource = this.stockTBLBindingSource;
            this.StockViewGrid.Location = new System.Drawing.Point(12, 12);
            this.StockViewGrid.Name = "StockViewGrid";
            this.StockViewGrid.ReadOnly = true;
            this.StockViewGrid.RowTemplate.Height = 90;
            this.StockViewGrid.Size = new System.Drawing.Size(894, 300);
            this.StockViewGrid.TabIndex = 0;
            this.StockViewGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StockViewGrid_CellContentClick);
            // 
            // referenceIDDataGridViewTextBoxColumn
            // 
            this.referenceIDDataGridViewTextBoxColumn.DataPropertyName = "ReferenceID";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.referenceIDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.referenceIDDataGridViewTextBoxColumn.HeaderText = "Reference ID";
            this.referenceIDDataGridViewTextBoxColumn.Name = "referenceIDDataGridViewTextBoxColumn";
            this.referenceIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemPictureDataGridViewImageColumn
            // 
            this.itemPictureDataGridViewImageColumn.DataPropertyName = "ItemPicture";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle2.NullValue")));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            this.itemPictureDataGridViewImageColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.itemPictureDataGridViewImageColumn.HeaderText = "Item Picture";
            this.itemPictureDataGridViewImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.itemPictureDataGridViewImageColumn.Name = "itemPictureDataGridViewImageColumn";
            this.itemPictureDataGridViewImageColumn.ReadOnly = true;
            // 
            // itemNameDataGridViewTextBoxColumn
            // 
            this.itemNameDataGridViewTextBoxColumn.DataPropertyName = "ItemName";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemNameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.itemNameDataGridViewTextBoxColumn.HeaderText = "Item Name";
            this.itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
            this.itemNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemDescriptionDataGridViewTextBoxColumn
            // 
            this.itemDescriptionDataGridViewTextBoxColumn.DataPropertyName = "ItemDescription";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.itemDescriptionDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.itemDescriptionDataGridViewTextBoxColumn.HeaderText = "Item Description";
            this.itemDescriptionDataGridViewTextBoxColumn.Name = "itemDescriptionDataGridViewTextBoxColumn";
            this.itemDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemDescriptionDataGridViewTextBoxColumn.Width = 150;
            // 
            // itemPrizeDataGridViewTextBoxColumn
            // 
            this.itemPrizeDataGridViewTextBoxColumn.DataPropertyName = "ItemPrize";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemPrizeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.itemPrizeDataGridViewTextBoxColumn.HeaderText = "Item Prize";
            this.itemPrizeDataGridViewTextBoxColumn.Name = "itemPrizeDataGridViewTextBoxColumn";
            this.itemPrizeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // weightVolumeDataGridViewTextBoxColumn
            // 
            this.weightVolumeDataGridViewTextBoxColumn.DataPropertyName = "WeightVolume";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightVolumeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.weightVolumeDataGridViewTextBoxColumn.HeaderText = "Weight/Volume";
            this.weightVolumeDataGridViewTextBoxColumn.Name = "weightVolumeDataGridViewTextBoxColumn";
            this.weightVolumeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // manuDTDataGridViewTextBoxColumn
            // 
            this.manuDTDataGridViewTextBoxColumn.DataPropertyName = "ManuDT";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manuDTDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.manuDTDataGridViewTextBoxColumn.HeaderText = "Mfd. Date";
            this.manuDTDataGridViewTextBoxColumn.Name = "manuDTDataGridViewTextBoxColumn";
            this.manuDTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expDTDataGridViewTextBoxColumn
            // 
            this.expDTDataGridViewTextBoxColumn.DataPropertyName = "ExpDT";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expDTDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.expDTDataGridViewTextBoxColumn.HeaderText = "Exp. Date";
            this.expDTDataGridViewTextBoxColumn.Name = "expDTDataGridViewTextBoxColumn";
            this.expDTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // availableQtyDataGridViewTextBoxColumn
            // 
            this.availableQtyDataGridViewTextBoxColumn.DataPropertyName = "AvailableQty";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availableQtyDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.availableQtyDataGridViewTextBoxColumn.HeaderText = "Available Qty";
            this.availableQtyDataGridViewTextBoxColumn.Name = "availableQtyDataGridViewTextBoxColumn";
            this.availableQtyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soldItemsDataGridViewTextBoxColumn
            // 
            this.soldItemsDataGridViewTextBoxColumn.DataPropertyName = "SoldItems";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soldItemsDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.soldItemsDataGridViewTextBoxColumn.HeaderText = "Sold Items";
            this.soldItemsDataGridViewTextBoxColumn.Name = "soldItemsDataGridViewTextBoxColumn";
            this.soldItemsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // supplierDataGridViewTextBoxColumn
            // 
            this.supplierDataGridViewTextBoxColumn.DataPropertyName = "Supplier";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.supplierDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle11;
            this.supplierDataGridViewTextBoxColumn.HeaderText = "Supplier";
            this.supplierDataGridViewTextBoxColumn.Name = "supplierDataGridViewTextBoxColumn";
            this.supplierDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockTBLBindingSource
            // 
            this.stockTBLBindingSource.DataMember = "StockTBL";
            this.stockTBLBindingSource.DataSource = this.groceryDBDataSet4;
            // 
            // groceryDBDataSet4
            // 
            this.groceryDBDataSet4.DataSetName = "GroceryDBDataSet4";
            this.groceryDBDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExitBtn.BackgroundImage")));
            this.ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.ExitBtn.Location = new System.Drawing.Point(469, 357);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(80, 30);
            this.ExitBtn.TabIndex = 3;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BackBtn.BackgroundImage")));
            this.BackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.BackBtn.Location = new System.Drawing.Point(383, 357);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(80, 30);
            this.BackBtn.TabIndex = 2;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // stockTBLTableAdapter
            // 
            this.stockTBLTableAdapter.ClearBeforeFill = true;
            // 
            // NewBtn
            // 
            this.NewBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NewBtn.BackgroundImage")));
            this.NewBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.NewBtn.Location = new System.Drawing.Point(396, 321);
            this.NewBtn.Name = "NewBtn";
            this.NewBtn.Size = new System.Drawing.Size(140, 30);
            this.NewBtn.TabIndex = 1;
            this.NewBtn.Text = "New Item";
            this.NewBtn.UseVisualStyleBackColor = true;
            this.NewBtn.Click += new System.EventHandler(this.NewBtn_Click);
            // 
            // StaffStockViewFrm
            // 
            this.AcceptButton = this.NewBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.CancelButton = this.BackBtn;
            this.ClientSize = new System.Drawing.Size(920, 399);
            this.Controls.Add(this.NewBtn);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.StockViewGrid);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StaffStockViewFrm";
            this.Text = "Stock View";
            this.Load += new System.EventHandler(this.EditDBFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StockViewGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockTBLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groceryDBDataSet4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView StockViewGrid;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button BackBtn;
        private GroceryDBDataSet4 groceryDBDataSet4;
        private System.Windows.Forms.BindingSource stockTBLBindingSource;
        private GroceryDBDataSet4TableAdapters.StockTBLTableAdapter stockTBLTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn referenceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn itemPictureDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemPrizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightVolumeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manuDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn availableQtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soldItemsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button NewBtn;
    }
}