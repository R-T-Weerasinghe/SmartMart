namespace GroceryProject
{
    partial class StaffQuickViewFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffQuickViewFrm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.QuickViewGrid = new System.Windows.Forms.DataGridView();
            this.stockTBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groceryDBDataSet4 = new GroceryProject.GroceryDBDataSet4();
            this.stockTBLTableAdapter = new GroceryProject.GroceryDBDataSet4TableAdapters.StockTBLTableAdapter();
            this.CloseBtn = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.QuickViewGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockTBLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groceryDBDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // QuickViewGrid
            // 
            this.QuickViewGrid.AllowUserToAddRows = false;
            this.QuickViewGrid.AllowUserToDeleteRows = false;
            this.QuickViewGrid.AutoGenerateColumns = false;
            this.QuickViewGrid.BackgroundColor = System.Drawing.Color.MintCream;
            this.QuickViewGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.QuickViewGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.QuickViewGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.QuickViewGrid.DataSource = this.stockTBLBindingSource;
            this.QuickViewGrid.Location = new System.Drawing.Point(12, 7);
            this.QuickViewGrid.Name = "QuickViewGrid";
            this.QuickViewGrid.ReadOnly = true;
            this.QuickViewGrid.RowTemplate.Height = 100;
            this.QuickViewGrid.Size = new System.Drawing.Size(894, 447);
            this.QuickViewGrid.TabIndex = 1;
            this.QuickViewGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StockViewGrid_CellContentClick);
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
            // stockTBLTableAdapter
            // 
            this.stockTBLTableAdapter.ClearBeforeFill = true;
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CloseBtn.BackgroundImage")));
            this.CloseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.CloseBtn.Location = new System.Drawing.Point(419, 465);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(80, 30);
            this.CloseBtn.TabIndex = 7;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // referenceIDDataGridViewTextBoxColumn
            // 
            this.referenceIDDataGridViewTextBoxColumn.DataPropertyName = "ReferenceID";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.referenceIDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.referenceIDDataGridViewTextBoxColumn.Frozen = true;
            this.referenceIDDataGridViewTextBoxColumn.HeaderText = "Reference ID";
            this.referenceIDDataGridViewTextBoxColumn.Name = "referenceIDDataGridViewTextBoxColumn";
            this.referenceIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.referenceIDDataGridViewTextBoxColumn.Width = 120;
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
            this.itemPictureDataGridViewImageColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // itemNameDataGridViewTextBoxColumn
            // 
            this.itemNameDataGridViewTextBoxColumn.DataPropertyName = "ItemName";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.itemNameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.itemNameDataGridViewTextBoxColumn.HeaderText = "Item Name";
            this.itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
            this.itemNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // itemDescriptionDataGridViewTextBoxColumn
            // 
            this.itemDescriptionDataGridViewTextBoxColumn.DataPropertyName = "ItemDescription";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
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
            this.itemPrizeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.itemPrizeDataGridViewTextBoxColumn.HeaderText = "Item Prize (Rs.)";
            this.itemPrizeDataGridViewTextBoxColumn.Name = "itemPrizeDataGridViewTextBoxColumn";
            this.itemPrizeDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemPrizeDataGridViewTextBoxColumn.Width = 110;
            // 
            // weightVolumeDataGridViewTextBoxColumn
            // 
            this.weightVolumeDataGridViewTextBoxColumn.DataPropertyName = "WeightVolume";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.weightVolumeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.weightVolumeDataGridViewTextBoxColumn.HeaderText = "Weight/Volume";
            this.weightVolumeDataGridViewTextBoxColumn.Name = "weightVolumeDataGridViewTextBoxColumn";
            this.weightVolumeDataGridViewTextBoxColumn.ReadOnly = true;
            this.weightVolumeDataGridViewTextBoxColumn.Width = 120;
            // 
            // manuDTDataGridViewTextBoxColumn
            // 
            this.manuDTDataGridViewTextBoxColumn.DataPropertyName = "ManuDT";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.manuDTDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.manuDTDataGridViewTextBoxColumn.HeaderText = "Mfd. Date";
            this.manuDTDataGridViewTextBoxColumn.Name = "manuDTDataGridViewTextBoxColumn";
            this.manuDTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expDTDataGridViewTextBoxColumn
            // 
            this.expDTDataGridViewTextBoxColumn.DataPropertyName = "ExpDT";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.expDTDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.expDTDataGridViewTextBoxColumn.HeaderText = "Exp. date";
            this.expDTDataGridViewTextBoxColumn.Name = "expDTDataGridViewTextBoxColumn";
            this.expDTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // availableQtyDataGridViewTextBoxColumn
            // 
            this.availableQtyDataGridViewTextBoxColumn.DataPropertyName = "AvailableQty";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.availableQtyDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.availableQtyDataGridViewTextBoxColumn.HeaderText = "Available Qty";
            this.availableQtyDataGridViewTextBoxColumn.Name = "availableQtyDataGridViewTextBoxColumn";
            this.availableQtyDataGridViewTextBoxColumn.ReadOnly = true;
            this.availableQtyDataGridViewTextBoxColumn.Width = 120;
            // 
            // soldItemsDataGridViewTextBoxColumn
            // 
            this.soldItemsDataGridViewTextBoxColumn.DataPropertyName = "SoldItems";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.soldItemsDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.soldItemsDataGridViewTextBoxColumn.HeaderText = "Sold Items";
            this.soldItemsDataGridViewTextBoxColumn.Name = "soldItemsDataGridViewTextBoxColumn";
            this.soldItemsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // supplierDataGridViewTextBoxColumn
            // 
            this.supplierDataGridViewTextBoxColumn.DataPropertyName = "Supplier";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.supplierDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle11;
            this.supplierDataGridViewTextBoxColumn.HeaderText = "Supplier";
            this.supplierDataGridViewTextBoxColumn.Name = "supplierDataGridViewTextBoxColumn";
            this.supplierDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // StaffQuickViewFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(921, 507);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.QuickViewGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StaffQuickViewFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quick View";
            this.Load += new System.EventHandler(this.StaffQuickView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QuickViewGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockTBLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groceryDBDataSet4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView QuickViewGrid;
        private GroceryDBDataSet4 groceryDBDataSet4;
        private System.Windows.Forms.BindingSource stockTBLBindingSource;
        private GroceryDBDataSet4TableAdapters.StockTBLTableAdapter stockTBLTableAdapter;
        private System.Windows.Forms.Button CloseBtn;
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

    }
}