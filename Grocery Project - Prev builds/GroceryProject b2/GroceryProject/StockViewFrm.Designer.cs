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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockViewFrm));
            this.StockViewGrid = new System.Windows.Forms.DataGridView();
            this.itemPictureDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.referenceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemPrizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockTBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groceryDBDataSet3 = new GroceryProject.GroceryDBDataSet3();
            this.stockTBLTableAdapter = new GroceryProject.GroceryDBDataSet3TableAdapters.StockTBLTableAdapter();
            this.BackBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StockViewGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockTBLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groceryDBDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // StockViewGrid
            // 
            this.StockViewGrid.AllowUserToAddRows = false;
            this.StockViewGrid.AllowUserToDeleteRows = false;
            this.StockViewGrid.AutoGenerateColumns = false;
            this.StockViewGrid.BackgroundColor = System.Drawing.Color.MintCream;
            this.StockViewGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StockViewGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemPictureDataGridViewImageColumn,
            this.referenceIDDataGridViewTextBoxColumn,
            this.itemNameDataGridViewTextBoxColumn,
            this.itemPrizeDataGridViewTextBoxColumn});
            this.StockViewGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StockViewGrid.DataSource = this.stockTBLBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StockViewGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.StockViewGrid.Location = new System.Drawing.Point(13, 13);
            this.StockViewGrid.Name = "StockViewGrid";
            this.StockViewGrid.ReadOnly = true;
            this.StockViewGrid.RowHeadersWidth = 21;
            this.StockViewGrid.RowTemplate.Height = 90;
            this.StockViewGrid.Size = new System.Drawing.Size(519, 345);
            this.StockViewGrid.TabIndex = 0;
            this.StockViewGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StockViewGrid_CellContentClick);
            // 
            // itemPictureDataGridViewImageColumn
            // 
            this.itemPictureDataGridViewImageColumn.DataPropertyName = "ItemPicture";
            this.itemPictureDataGridViewImageColumn.HeaderText = "Preview";
            this.itemPictureDataGridViewImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.itemPictureDataGridViewImageColumn.Name = "itemPictureDataGridViewImageColumn";
            this.itemPictureDataGridViewImageColumn.ReadOnly = true;
            // 
            // referenceIDDataGridViewTextBoxColumn
            // 
            this.referenceIDDataGridViewTextBoxColumn.DataPropertyName = "ReferenceID";
            this.referenceIDDataGridViewTextBoxColumn.HeaderText = "Reference ID";
            this.referenceIDDataGridViewTextBoxColumn.Name = "referenceIDDataGridViewTextBoxColumn";
            this.referenceIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemNameDataGridViewTextBoxColumn
            // 
            this.itemNameDataGridViewTextBoxColumn.DataPropertyName = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
            this.itemNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // itemPrizeDataGridViewTextBoxColumn
            // 
            this.itemPrizeDataGridViewTextBoxColumn.DataPropertyName = "ItemPrize";
            this.itemPrizeDataGridViewTextBoxColumn.HeaderText = "Prize";
            this.itemPrizeDataGridViewTextBoxColumn.Name = "itemPrizeDataGridViewTextBoxColumn";
            this.itemPrizeDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemPrizeDataGridViewTextBoxColumn.Width = 70;
            // 
            // stockTBLBindingSource
            // 
            this.stockTBLBindingSource.DataMember = "StockTBL";
            this.stockTBLBindingSource.DataSource = this.groceryDBDataSet3;
            // 
            // groceryDBDataSet3
            // 
            this.groceryDBDataSet3.DataSetName = "GroceryDBDataSet3";
            this.groceryDBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stockTBLTableAdapter
            // 
            this.stockTBLTableAdapter.ClearBeforeFill = true;
            // 
            // BackBtn
            // 
            this.BackBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BackBtn.BackgroundImage")));
            this.BackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.BackBtn.Location = new System.Drawing.Point(187, 364);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(80, 30);
            this.BackBtn.TabIndex = 46;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExitBtn.BackgroundImage")));
            this.ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.ExitBtn.Location = new System.Drawing.Point(273, 364);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(80, 30);
            this.ExitBtn.TabIndex = 45;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // StockViewFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(544, 406);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.StockViewGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "StockViewFrm";
            this.Text = "StockViewFrm";
            this.Load += new System.EventHandler(this.StockViewFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StockViewGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockTBLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groceryDBDataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView StockViewGrid;
        private GroceryDBDataSet3 groceryDBDataSet3;
        private System.Windows.Forms.BindingSource stockTBLBindingSource;
        private GroceryDBDataSet3TableAdapters.StockTBLTableAdapter stockTBLTableAdapter;
        private System.Windows.Forms.DataGridViewImageColumn itemPictureDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn referenceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemPrizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button ExitBtn;
    }
}