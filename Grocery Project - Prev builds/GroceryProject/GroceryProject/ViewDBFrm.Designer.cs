namespace GroceryProject
{
    partial class ViewDBFrm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groceryDBDataSet = new GroceryProject.GroceryDBDataSet();
            this.stockTBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockTBLTableAdapter = new GroceryProject.GroceryDBDataSetTableAdapters.StockTBLTableAdapter();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.referenceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemPrizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.volumeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manuDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availableQtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groceryDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockTBLBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.referenceIDDataGridViewTextBoxColumn,
            this.itemNameDataGridViewTextBoxColumn,
            this.itemPrizeDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn,
            this.volumeDataGridViewTextBoxColumn,
            this.manuDTDataGridViewTextBoxColumn,
            this.expDTDataGridViewTextBoxColumn,
            this.availableQtyDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.stockTBLBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(844, 344);
            this.dataGridView1.TabIndex = 0;
            // 
            // groceryDBDataSet
            // 
            this.groceryDBDataSet.DataSetName = "GroceryDBDataSet";
            this.groceryDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stockTBLBindingSource
            // 
            this.stockTBLBindingSource.DataMember = "StockTBL";
            this.stockTBLBindingSource.DataSource = this.groceryDBDataSet;
            // 
            // stockTBLTableAdapter
            // 
            this.stockTBLTableAdapter.ClearBeforeFill = true;
            // 
            // ExitBtn
            // 
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.Location = new System.Drawing.Point(302, 364);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(101, 30);
            this.ExitBtn.TabIndex = 28;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.Location = new System.Drawing.Point(425, 364);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(101, 30);
            this.BackBtn.TabIndex = 29;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // referenceIDDataGridViewTextBoxColumn
            // 
            this.referenceIDDataGridViewTextBoxColumn.DataPropertyName = "ReferenceID";
            this.referenceIDDataGridViewTextBoxColumn.HeaderText = "ReferenceID";
            this.referenceIDDataGridViewTextBoxColumn.Name = "referenceIDDataGridViewTextBoxColumn";
            this.referenceIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemNameDataGridViewTextBoxColumn
            // 
            this.itemNameDataGridViewTextBoxColumn.DataPropertyName = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.HeaderText = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
            this.itemNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemPrizeDataGridViewTextBoxColumn
            // 
            this.itemPrizeDataGridViewTextBoxColumn.DataPropertyName = "ItemPrize";
            this.itemPrizeDataGridViewTextBoxColumn.HeaderText = "ItemPrize";
            this.itemPrizeDataGridViewTextBoxColumn.Name = "itemPrizeDataGridViewTextBoxColumn";
            this.itemPrizeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
            this.weightDataGridViewTextBoxColumn.HeaderText = "Weight";
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            this.weightDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // volumeDataGridViewTextBoxColumn
            // 
            this.volumeDataGridViewTextBoxColumn.DataPropertyName = "Volume";
            this.volumeDataGridViewTextBoxColumn.HeaderText = "Volume";
            this.volumeDataGridViewTextBoxColumn.Name = "volumeDataGridViewTextBoxColumn";
            this.volumeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // manuDTDataGridViewTextBoxColumn
            // 
            this.manuDTDataGridViewTextBoxColumn.DataPropertyName = "ManuDT";
            this.manuDTDataGridViewTextBoxColumn.HeaderText = "ManuDT";
            this.manuDTDataGridViewTextBoxColumn.Name = "manuDTDataGridViewTextBoxColumn";
            this.manuDTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expDTDataGridViewTextBoxColumn
            // 
            this.expDTDataGridViewTextBoxColumn.DataPropertyName = "ExpDT";
            this.expDTDataGridViewTextBoxColumn.HeaderText = "ExpDT";
            this.expDTDataGridViewTextBoxColumn.Name = "expDTDataGridViewTextBoxColumn";
            this.expDTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // availableQtyDataGridViewTextBoxColumn
            // 
            this.availableQtyDataGridViewTextBoxColumn.DataPropertyName = "AvailableQty";
            this.availableQtyDataGridViewTextBoxColumn.HeaderText = "AvailableQty";
            this.availableQtyDataGridViewTextBoxColumn.Name = "availableQtyDataGridViewTextBoxColumn";
            this.availableQtyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // QuickViewDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 406);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "QuickViewDB";
            this.Text = "QuickViewDB";
            this.Load += new System.EventHandler(this.QuickViewDB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groceryDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockTBLBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private GroceryDBDataSet groceryDBDataSet;
        private System.Windows.Forms.BindingSource stockTBLBindingSource;
        private GroceryDBDataSetTableAdapters.StockTBLTableAdapter stockTBLTableAdapter;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn referenceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemPrizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn volumeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manuDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn availableQtyDataGridViewTextBoxColumn;
    }
}