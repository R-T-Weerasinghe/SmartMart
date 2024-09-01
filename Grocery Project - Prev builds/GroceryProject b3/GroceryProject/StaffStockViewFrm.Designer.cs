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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffStockViewFrm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
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
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.referenceIDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle12;
            this.referenceIDDataGridViewTextBoxColumn.HeaderText = "Reference ID";
            this.referenceIDDataGridViewTextBoxColumn.Name = "referenceIDDataGridViewTextBoxColumn";
            this.referenceIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemPictureDataGridViewImageColumn
            // 
            this.itemPictureDataGridViewImageColumn.DataPropertyName = "ItemPicture";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle13.NullValue")));
            dataGridViewCellStyle13.Padding = new System.Windows.Forms.Padding(5);
            this.itemPictureDataGridViewImageColumn.DefaultCellStyle = dataGridViewCellStyle13;
            this.itemPictureDataGridViewImageColumn.HeaderText = "Item Picture";
            this.itemPictureDataGridViewImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.itemPictureDataGridViewImageColumn.Name = "itemPictureDataGridViewImageColumn";
            this.itemPictureDataGridViewImageColumn.ReadOnly = true;
            // 
            // itemNameDataGridViewTextBoxColumn
            // 
            this.itemNameDataGridViewTextBoxColumn.DataPropertyName = "ItemName";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemNameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle14;
            this.itemNameDataGridViewTextBoxColumn.HeaderText = "Item Name";
            this.itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
            this.itemNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemDescriptionDataGridViewTextBoxColumn
            // 
            this.itemDescriptionDataGridViewTextBoxColumn.DataPropertyName = "ItemDescription";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.itemDescriptionDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle15;
            this.itemDescriptionDataGridViewTextBoxColumn.HeaderText = "Item Description";
            this.itemDescriptionDataGridViewTextBoxColumn.Name = "itemDescriptionDataGridViewTextBoxColumn";
            this.itemDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemDescriptionDataGridViewTextBoxColumn.Width = 150;
            // 
            // itemPrizeDataGridViewTextBoxColumn
            // 
            this.itemPrizeDataGridViewTextBoxColumn.DataPropertyName = "ItemPrize";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemPrizeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle16;
            this.itemPrizeDataGridViewTextBoxColumn.HeaderText = "Item Prize";
            this.itemPrizeDataGridViewTextBoxColumn.Name = "itemPrizeDataGridViewTextBoxColumn";
            this.itemPrizeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // weightVolumeDataGridViewTextBoxColumn
            // 
            this.weightVolumeDataGridViewTextBoxColumn.DataPropertyName = "WeightVolume";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightVolumeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle17;
            this.weightVolumeDataGridViewTextBoxColumn.HeaderText = "Weight/Volume";
            this.weightVolumeDataGridViewTextBoxColumn.Name = "weightVolumeDataGridViewTextBoxColumn";
            this.weightVolumeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // manuDTDataGridViewTextBoxColumn
            // 
            this.manuDTDataGridViewTextBoxColumn.DataPropertyName = "ManuDT";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manuDTDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle18;
            this.manuDTDataGridViewTextBoxColumn.HeaderText = "Mfd. Date";
            this.manuDTDataGridViewTextBoxColumn.Name = "manuDTDataGridViewTextBoxColumn";
            this.manuDTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expDTDataGridViewTextBoxColumn
            // 
            this.expDTDataGridViewTextBoxColumn.DataPropertyName = "ExpDT";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expDTDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle19;
            this.expDTDataGridViewTextBoxColumn.HeaderText = "Exp. Date";
            this.expDTDataGridViewTextBoxColumn.Name = "expDTDataGridViewTextBoxColumn";
            this.expDTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // availableQtyDataGridViewTextBoxColumn
            // 
            this.availableQtyDataGridViewTextBoxColumn.DataPropertyName = "AvailableQty";
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availableQtyDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle20;
            this.availableQtyDataGridViewTextBoxColumn.HeaderText = "Available Qty";
            this.availableQtyDataGridViewTextBoxColumn.Name = "availableQtyDataGridViewTextBoxColumn";
            this.availableQtyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soldItemsDataGridViewTextBoxColumn
            // 
            this.soldItemsDataGridViewTextBoxColumn.DataPropertyName = "SoldItems";
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soldItemsDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle21;
            this.soldItemsDataGridViewTextBoxColumn.HeaderText = "Sold Items";
            this.soldItemsDataGridViewTextBoxColumn.Name = "soldItemsDataGridViewTextBoxColumn";
            this.soldItemsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // supplierDataGridViewTextBoxColumn
            // 
            this.supplierDataGridViewTextBoxColumn.DataPropertyName = "Supplier";
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.supplierDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle22;
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
            this.ExitBtn.Location = new System.Drawing.Point(470, 342);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(80, 30);
            this.ExitBtn.TabIndex = 29;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BackBtn.BackgroundImage")));
            this.BackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.BackBtn.Location = new System.Drawing.Point(384, 342);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(80, 30);
            this.BackBtn.TabIndex = 30;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // stockTBLTableAdapter
            // 
            this.stockTBLTableAdapter.ClearBeforeFill = true;
            // 
            // StaffStockViewFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(920, 384);
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
    }
}