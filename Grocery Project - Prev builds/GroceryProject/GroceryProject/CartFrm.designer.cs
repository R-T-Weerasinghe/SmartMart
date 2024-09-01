namespace Esoft_last_project
{
    partial class CartFrm
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
            this.CartGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RemoveAllBtn = new System.Windows.Forms.Button();
            this.RemoveSelBtn = new System.Windows.Forms.Button();
            this.PurchaseBtn = new System.Windows.Forms.Button();
            this.Backbtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.OrderLbl = new System.Windows.Forms.Label();
            this.ItemsLbl = new System.Windows.Forms.Label();
            this.ValueLbl = new System.Windows.Forms.Label();
            this.ItemNameTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.CartGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // CartGrid
            // 
            this.CartGrid.AllowUserToAddRows = false;
            this.CartGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.CartGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CartGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CartGrid.Location = new System.Drawing.Point(37, 12);
            this.CartGrid.Name = "CartGrid";
            this.CartGrid.ReadOnly = true;
            this.CartGrid.Size = new System.Drawing.Size(454, 287);
            this.CartGrid.TabIndex = 0;
            this.CartGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Order Name    :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "No . Of Items  :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(93, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Total Value   :";
            // 
            // RemoveAllBtn
            // 
            this.RemoveAllBtn.Location = new System.Drawing.Point(151, 441);
            this.RemoveAllBtn.Name = "RemoveAllBtn";
            this.RemoveAllBtn.Size = new System.Drawing.Size(75, 23);
            this.RemoveAllBtn.TabIndex = 7;
            this.RemoveAllBtn.Text = "Remove All";
            this.RemoveAllBtn.UseVisualStyleBackColor = true;
            this.RemoveAllBtn.Click += new System.EventHandler(this.RemoveAllBtn_Click);
            // 
            // RemoveSelBtn
            // 
            this.RemoveSelBtn.Location = new System.Drawing.Point(271, 412);
            this.RemoveSelBtn.Name = "RemoveSelBtn";
            this.RemoveSelBtn.Size = new System.Drawing.Size(118, 23);
            this.RemoveSelBtn.TabIndex = 8;
            this.RemoveSelBtn.Text = "Remove This Item";
            this.RemoveSelBtn.UseVisualStyleBackColor = true;
            this.RemoveSelBtn.Click += new System.EventHandler(this.RemoveSelBtn_Click);
            // 
            // PurchaseBtn
            // 
            this.PurchaseBtn.Location = new System.Drawing.Point(231, 441);
            this.PurchaseBtn.Name = "PurchaseBtn";
            this.PurchaseBtn.Size = new System.Drawing.Size(75, 23);
            this.PurchaseBtn.TabIndex = 9;
            this.PurchaseBtn.Text = "Purchase";
            this.PurchaseBtn.UseVisualStyleBackColor = true;
            this.PurchaseBtn.Click += new System.EventHandler(this.PurchaseBtn_Click);
            // 
            // Backbtn
            // 
            this.Backbtn.Location = new System.Drawing.Point(151, 480);
            this.Backbtn.Name = "Backbtn";
            this.Backbtn.Size = new System.Drawing.Size(75, 23);
            this.Backbtn.TabIndex = 10;
            this.Backbtn.Text = "BACK";
            this.Backbtn.UseVisualStyleBackColor = true;
            this.Backbtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(231, 480);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(75, 23);
            this.ExitBtn.TabIndex = 11;
            this.ExitBtn.Text = "EXIT";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // OrderLbl
            // 
            this.OrderLbl.AutoSize = true;
            this.OrderLbl.Location = new System.Drawing.Point(228, 315);
            this.OrderLbl.Name = "OrderLbl";
            this.OrderLbl.Size = new System.Drawing.Size(35, 13);
            this.OrderLbl.TabIndex = 12;
            this.OrderLbl.Text = "label4";
            // 
            // ItemsLbl
            // 
            this.ItemsLbl.AutoSize = true;
            this.ItemsLbl.Location = new System.Drawing.Point(228, 348);
            this.ItemsLbl.Name = "ItemsLbl";
            this.ItemsLbl.Size = new System.Drawing.Size(35, 13);
            this.ItemsLbl.TabIndex = 13;
            this.ItemsLbl.Text = "label5";
            // 
            // ValueLbl
            // 
            this.ValueLbl.AutoSize = true;
            this.ValueLbl.Location = new System.Drawing.Point(228, 380);
            this.ValueLbl.Name = "ValueLbl";
            this.ValueLbl.Size = new System.Drawing.Size(35, 13);
            this.ValueLbl.TabIndex = 14;
            this.ValueLbl.Text = "label6";
            // 
            // ItemNameTxt
            // 
            this.ItemNameTxt.Location = new System.Drawing.Point(124, 412);
            this.ItemNameTxt.Name = "ItemNameTxt";
            this.ItemNameTxt.Size = new System.Drawing.Size(141, 20);
            this.ItemNameTxt.TabIndex = 15;
            // 
            // CartFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 514);
            this.Controls.Add(this.ItemNameTxt);
            this.Controls.Add(this.ValueLbl);
            this.Controls.Add(this.ItemsLbl);
            this.Controls.Add(this.OrderLbl);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.Backbtn);
            this.Controls.Add(this.PurchaseBtn);
            this.Controls.Add(this.RemoveSelBtn);
            this.Controls.Add(this.RemoveAllBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CartGrid);
            this.Name = "CartFrm";
            this.Text = "Form14";
            this.Load += new System.EventHandler(this.CartFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CartGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CartGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button RemoveAllBtn;
        private System.Windows.Forms.Button RemoveSelBtn;
        private System.Windows.Forms.Button PurchaseBtn;
        private System.Windows.Forms.Button Backbtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Label OrderLbl;
        private System.Windows.Forms.Label ItemsLbl;
        private System.Windows.Forms.Label ValueLbl;
        private System.Windows.Forms.TextBox ItemNameTxt;
    }
}