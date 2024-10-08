﻿namespace GroceryProject
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
            this.OrdersGrid = new System.Windows.Forms.DataGridView();
            this.SearchTxt = new System.Windows.Forms.TextBox();
            this.SearchCom = new System.Windows.Forms.ComboBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.groceryDBDataSet2 = new GroceryProject.GroceryDBDataSet2();
            this.orderTBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderTBLTableAdapter = new GroceryProject.GroceryDBDataSet2TableAdapters.OrderTBLTableAdapter();
            this.orderNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placedByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groceryDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderTBLBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // OrdersGrid
            // 
            this.OrdersGrid.AutoGenerateColumns = false;
            this.OrdersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderNumberDataGridViewTextBoxColumn,
            this.placedByDataGridViewTextBoxColumn,
            this.itemsDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.valueDataGridViewTextBoxColumn});
            this.OrdersGrid.DataSource = this.orderTBLBindingSource;
            this.OrdersGrid.Location = new System.Drawing.Point(12, 56);
            this.OrdersGrid.Name = "OrdersGrid";
            this.OrdersGrid.Size = new System.Drawing.Size(483, 241);
            this.OrdersGrid.TabIndex = 0;
            // 
            // SearchTxt
            // 
            this.SearchTxt.Location = new System.Drawing.Point(93, 14);
            this.SearchTxt.Name = "SearchTxt";
            this.SearchTxt.Size = new System.Drawing.Size(137, 20);
            this.SearchTxt.TabIndex = 1;
            // 
            // SearchCom
            // 
            this.SearchCom.FormattingEnabled = true;
            this.SearchCom.Items.AddRange(new object[] {
            "Account",
            "Date"});
            this.SearchCom.Location = new System.Drawing.Point(274, 14);
            this.SearchCom.Name = "SearchCom";
            this.SearchCom.Size = new System.Drawing.Size(79, 21);
            this.SearchCom.TabIndex = 2;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(369, 12);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(63, 23);
            this.SearchBtn.TabIndex = 3;
            this.SearchBtn.Text = "GO";
            this.SearchBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "using";
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Location = new System.Drawing.Point(210, 303);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(75, 23);
            this.RemoveBtn.TabIndex = 5;
            this.RemoveBtn.Text = "Remove All";
            this.RemoveBtn.UseVisualStyleBackColor = true;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(175, 332);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(75, 23);
            this.BackBtn.TabIndex = 6;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(256, 332);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(75, 23);
            this.ExitBtn.TabIndex = 7;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // groceryDBDataSet2
            // 
            this.groceryDBDataSet2.DataSetName = "GroceryDBDataSet2";
            this.groceryDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderTBLBindingSource
            // 
            this.orderTBLBindingSource.DataMember = "OrderTBL";
            this.orderTBLBindingSource.DataSource = this.groceryDBDataSet2;
            // 
            // orderTBLTableAdapter
            // 
            this.orderTBLTableAdapter.ClearBeforeFill = true;
            // 
            // orderNumberDataGridViewTextBoxColumn
            // 
            this.orderNumberDataGridViewTextBoxColumn.DataPropertyName = "OrderNumber";
            this.orderNumberDataGridViewTextBoxColumn.HeaderText = "OrderNumber";
            this.orderNumberDataGridViewTextBoxColumn.Name = "orderNumberDataGridViewTextBoxColumn";
            // 
            // placedByDataGridViewTextBoxColumn
            // 
            this.placedByDataGridViewTextBoxColumn.DataPropertyName = "PlacedBy";
            this.placedByDataGridViewTextBoxColumn.HeaderText = "PlacedBy";
            this.placedByDataGridViewTextBoxColumn.Name = "placedByDataGridViewTextBoxColumn";
            // 
            // itemsDataGridViewTextBoxColumn
            // 
            this.itemsDataGridViewTextBoxColumn.DataPropertyName = "Items";
            this.itemsDataGridViewTextBoxColumn.HeaderText = "Items";
            this.itemsDataGridViewTextBoxColumn.Name = "itemsDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // valueDataGridViewTextBoxColumn
            // 
            this.valueDataGridViewTextBoxColumn.DataPropertyName = "Value";
            this.valueDataGridViewTextBoxColumn.HeaderText = "Value";
            this.valueDataGridViewTextBoxColumn.Name = "valueDataGridViewTextBoxColumn";
            // 
            // OrdersFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 367);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.RemoveBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.SearchCom);
            this.Controls.Add(this.SearchTxt);
            this.Controls.Add(this.OrdersGrid);
            this.Name = "OrdersFrm";
            this.Text = "OrdersFrm";
            this.Load += new System.EventHandler(this.OrdersFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groceryDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderTBLBindingSource)).EndInit();
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
        private GroceryDBDataSet2 groceryDBDataSet2;
        private System.Windows.Forms.BindingSource orderTBLBindingSource;
        private GroceryDBDataSet2TableAdapters.OrderTBLTableAdapter orderTBLTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placedByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
    }
}