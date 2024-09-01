namespace GroceryProject
{
    partial class EditDBFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditDBFrm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.groceryDBDataSet4 = new GroceryProject.GroceryDBDataSet4();
            this.stockTBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockTBLTableAdapter = new GroceryProject.GroceryDBDataSet4TableAdapters.StockTBLTableAdapter();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groceryDBDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockTBLBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MintCream;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridView1.DataSource = this.stockTBLBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 60;
            this.dataGridView1.Size = new System.Drawing.Size(743, 299);
            this.dataGridView1.TabIndex = 0;
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExitBtn.BackgroundImage")));
            this.ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.ExitBtn.Location = new System.Drawing.Point(294, 329);
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
            this.BackBtn.Location = new System.Drawing.Point(380, 329);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(80, 30);
            this.BackBtn.TabIndex = 30;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // groceryDBDataSet4
            // 
            this.groceryDBDataSet4.DataSetName = "GroceryDBDataSet4";
            this.groceryDBDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stockTBLBindingSource
            // 
            this.stockTBLBindingSource.DataMember = "StockTBL";
            this.stockTBLBindingSource.DataSource = this.groceryDBDataSet4;
            // 
            // stockTBLTableAdapter
            // 
            this.stockTBLTableAdapter.ClearBeforeFill = true;
            // 
            // referenceIDDataGridViewTextBoxColumn
            // 
            this.referenceIDDataGridViewTextBoxColumn.DataPropertyName = "ReferenceID";
            this.referenceIDDataGridViewTextBoxColumn.HeaderText = "ReferenceID";
            this.referenceIDDataGridViewTextBoxColumn.Name = "referenceIDDataGridViewTextBoxColumn";
            // 
            // itemPictureDataGridViewImageColumn
            // 
            this.itemPictureDataGridViewImageColumn.DataPropertyName = "ItemPicture";
            this.itemPictureDataGridViewImageColumn.HeaderText = "ItemPicture";
            this.itemPictureDataGridViewImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.itemPictureDataGridViewImageColumn.Name = "itemPictureDataGridViewImageColumn";
            // 
            // itemNameDataGridViewTextBoxColumn
            // 
            this.itemNameDataGridViewTextBoxColumn.DataPropertyName = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.HeaderText = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
            // 
            // itemDescriptionDataGridViewTextBoxColumn
            // 
            this.itemDescriptionDataGridViewTextBoxColumn.DataPropertyName = "ItemDescription";
            this.itemDescriptionDataGridViewTextBoxColumn.HeaderText = "ItemDescription";
            this.itemDescriptionDataGridViewTextBoxColumn.Name = "itemDescriptionDataGridViewTextBoxColumn";
            // 
            // itemPrizeDataGridViewTextBoxColumn
            // 
            this.itemPrizeDataGridViewTextBoxColumn.DataPropertyName = "ItemPrize";
            this.itemPrizeDataGridViewTextBoxColumn.HeaderText = "ItemPrize";
            this.itemPrizeDataGridViewTextBoxColumn.Name = "itemPrizeDataGridViewTextBoxColumn";
            // 
            // weightVolumeDataGridViewTextBoxColumn
            // 
            this.weightVolumeDataGridViewTextBoxColumn.DataPropertyName = "WeightVolume";
            this.weightVolumeDataGridViewTextBoxColumn.HeaderText = "WeightVolume";
            this.weightVolumeDataGridViewTextBoxColumn.Name = "weightVolumeDataGridViewTextBoxColumn";
            // 
            // manuDTDataGridViewTextBoxColumn
            // 
            this.manuDTDataGridViewTextBoxColumn.DataPropertyName = "ManuDT";
            this.manuDTDataGridViewTextBoxColumn.HeaderText = "ManuDT";
            this.manuDTDataGridViewTextBoxColumn.Name = "manuDTDataGridViewTextBoxColumn";
            // 
            // expDTDataGridViewTextBoxColumn
            // 
            this.expDTDataGridViewTextBoxColumn.DataPropertyName = "ExpDT";
            this.expDTDataGridViewTextBoxColumn.HeaderText = "ExpDT";
            this.expDTDataGridViewTextBoxColumn.Name = "expDTDataGridViewTextBoxColumn";
            // 
            // availableQtyDataGridViewTextBoxColumn
            // 
            this.availableQtyDataGridViewTextBoxColumn.DataPropertyName = "AvailableQty";
            this.availableQtyDataGridViewTextBoxColumn.HeaderText = "AvailableQty";
            this.availableQtyDataGridViewTextBoxColumn.Name = "availableQtyDataGridViewTextBoxColumn";
            // 
            // soldItemsDataGridViewTextBoxColumn
            // 
            this.soldItemsDataGridViewTextBoxColumn.DataPropertyName = "SoldItems";
            this.soldItemsDataGridViewTextBoxColumn.HeaderText = "SoldItems";
            this.soldItemsDataGridViewTextBoxColumn.Name = "soldItemsDataGridViewTextBoxColumn";
            // 
            // supplierDataGridViewTextBoxColumn
            // 
            this.supplierDataGridViewTextBoxColumn.DataPropertyName = "Supplier";
            this.supplierDataGridViewTextBoxColumn.HeaderText = "Supplier";
            this.supplierDataGridViewTextBoxColumn.Name = "supplierDataGridViewTextBoxColumn";
            // 
            // EditDBFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(767, 371);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditDBFrm";
            this.Text = "Edit Database";
            this.Load += new System.EventHandler(this.EditDBFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groceryDBDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockTBLBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
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