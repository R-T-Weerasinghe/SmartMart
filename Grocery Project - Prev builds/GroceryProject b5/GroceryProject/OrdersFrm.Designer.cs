namespace GroceryProject
{
    partial class OrdersFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdersFrm));
            this.OrdersGrid = new System.Windows.Forms.DataGridView();
            this.orderNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placedByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderTBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groceryDBDataSet5 = new GroceryProject.GroceryDBDataSet5();
            this.SearchTxt = new System.Windows.Forms.TextBox();
            this.SearchCom = new System.Windows.Forms.ComboBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.orderTBLTableAdapter = new GroceryProject.GroceryDBDataSet5TableAdapters.OrderTBLTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderTBLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groceryDBDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // OrdersGrid
            // 
            this.OrdersGrid.AllowUserToAddRows = false;
            this.OrdersGrid.AllowUserToDeleteRows = false;
            this.OrdersGrid.AutoGenerateColumns = false;
            this.OrdersGrid.BackgroundColor = System.Drawing.Color.MintCream;
            this.OrdersGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.OrdersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderNumberDataGridViewTextBoxColumn,
            this.placedByDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.valueDataGridViewTextBoxColumn});
            this.OrdersGrid.DataSource = this.orderTBLBindingSource;
            this.OrdersGrid.Location = new System.Drawing.Point(12, 56);
            this.OrdersGrid.Name = "OrdersGrid";
            this.OrdersGrid.ReadOnly = true;
            this.OrdersGrid.Size = new System.Drawing.Size(457, 241);
            this.OrdersGrid.TabIndex = 0;
            this.OrdersGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrdersGrid_CellContentClick);
            // 
            // orderNumberDataGridViewTextBoxColumn
            // 
            this.orderNumberDataGridViewTextBoxColumn.DataPropertyName = "OrderNumber";
            this.orderNumberDataGridViewTextBoxColumn.HeaderText = "OrderNumber";
            this.orderNumberDataGridViewTextBoxColumn.Name = "orderNumberDataGridViewTextBoxColumn";
            this.orderNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // placedByDataGridViewTextBoxColumn
            // 
            this.placedByDataGridViewTextBoxColumn.DataPropertyName = "PlacedBy";
            this.placedByDataGridViewTextBoxColumn.HeaderText = "PlacedBy";
            this.placedByDataGridViewTextBoxColumn.Name = "placedByDataGridViewTextBoxColumn";
            this.placedByDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valueDataGridViewTextBoxColumn
            // 
            this.valueDataGridViewTextBoxColumn.DataPropertyName = "Value";
            this.valueDataGridViewTextBoxColumn.HeaderText = "Value";
            this.valueDataGridViewTextBoxColumn.Name = "valueDataGridViewTextBoxColumn";
            this.valueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderTBLBindingSource
            // 
            this.orderTBLBindingSource.DataMember = "OrderTBL";
            this.orderTBLBindingSource.DataSource = this.groceryDBDataSet5;
            // 
            // groceryDBDataSet5
            // 
            this.groceryDBDataSet5.DataSetName = "GroceryDBDataSet5";
            this.groceryDBDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SearchTxt
            // 
            this.SearchTxt.Location = new System.Drawing.Point(76, 12);
            this.SearchTxt.Name = "SearchTxt";
            this.SearchTxt.Size = new System.Drawing.Size(137, 20);
            this.SearchTxt.TabIndex = 1;
            this.SearchTxt.Text = "Not completed";
            // 
            // SearchCom
            // 
            this.SearchCom.FormattingEnabled = true;
            this.SearchCom.Items.AddRange(new object[] {
            "Account",
            "Date"});
            this.SearchCom.Location = new System.Drawing.Point(266, 12);
            this.SearchCom.Name = "SearchCom";
            this.SearchCom.Size = new System.Drawing.Size(79, 21);
            this.SearchCom.TabIndex = 2;
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SearchBtn.BackgroundImage")));
            this.SearchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SearchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.SearchBtn.Location = new System.Drawing.Point(351, 12);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(63, 23);
            this.SearchBtn.TabIndex = 3;
            this.SearchBtn.Text = "GO";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "using";
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RemoveBtn.BackgroundImage")));
            this.RemoveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RemoveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.RemoveBtn.Location = new System.Drawing.Point(168, 303);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(140, 30);
            this.RemoveBtn.TabIndex = 4;
            this.RemoveBtn.Text = "Remove All";
            this.RemoveBtn.UseVisualStyleBackColor = true;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BackBtn.BackgroundImage")));
            this.BackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.BackBtn.Location = new System.Drawing.Point(152, 339);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(80, 30);
            this.BackBtn.TabIndex = 5;
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
            this.ExitBtn.Location = new System.Drawing.Point(238, 339);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(80, 30);
            this.ExitBtn.TabIndex = 6;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // orderTBLTableAdapter
            // 
            this.orderTBLTableAdapter.ClearBeforeFill = true;
            // 
            // OrdersFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.CancelButton = this.BackBtn;
            this.ClientSize = new System.Drawing.Size(478, 382);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.RemoveBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.SearchCom);
            this.Controls.Add(this.SearchTxt);
            this.Controls.Add(this.OrdersGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OrdersFrm";
            this.Text = "Orders";
            this.Load += new System.EventHandler(this.OrdersFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderTBLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groceryDBDataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView OrdersGrid;
        private System.Windows.Forms.TextBox SearchTxt;
        private System.Windows.Forms.ComboBox SearchCom;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RemoveBtn;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button ExitBtn;
        private GroceryDBDataSet5 groceryDBDataSet5;
        private System.Windows.Forms.BindingSource orderTBLBindingSource;
        private GroceryDBDataSet5TableAdapters.OrderTBLTableAdapter orderTBLTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placedByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
    }
}