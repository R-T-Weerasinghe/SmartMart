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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CartFrm));
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
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CartGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // CartGrid
            // 
            this.CartGrid.AllowUserToAddRows = false;
            this.CartGrid.AllowUserToDeleteRows = false;
            this.CartGrid.BackgroundColor = System.Drawing.Color.MintCream;
            this.CartGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CartGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CartGrid.Location = new System.Drawing.Point(37, 12);
            this.CartGrid.Name = "CartGrid";
            this.CartGrid.ReadOnly = true;
            this.CartGrid.Size = new System.Drawing.Size(454, 233);
            this.CartGrid.TabIndex = 0;
            this.CartGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(154, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Order Name    :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(159, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "No . Of Items  :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(162, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Total Value   :";
            // 
            // RemoveAllBtn
            // 
            this.RemoveAllBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RemoveAllBtn.BackgroundImage")));
            this.RemoveAllBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RemoveAllBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveAllBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveAllBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.RemoveAllBtn.Location = new System.Drawing.Point(257, 397);
            this.RemoveAllBtn.Name = "RemoveAllBtn";
            this.RemoveAllBtn.Size = new System.Drawing.Size(140, 30);
            this.RemoveAllBtn.TabIndex = 2;
            this.RemoveAllBtn.Text = "Remove All";
            this.RemoveAllBtn.UseVisualStyleBackColor = true;
            this.RemoveAllBtn.Click += new System.EventHandler(this.RemoveAllBtn_Click);
            // 
            // RemoveSelBtn
            // 
            this.RemoveSelBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RemoveSelBtn.BackgroundImage")));
            this.RemoveSelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RemoveSelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveSelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveSelBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.RemoveSelBtn.Location = new System.Drawing.Point(111, 397);
            this.RemoveSelBtn.Name = "RemoveSelBtn";
            this.RemoveSelBtn.Size = new System.Drawing.Size(140, 30);
            this.RemoveSelBtn.TabIndex = 1;
            this.RemoveSelBtn.Text = "Remove This Item";
            this.RemoveSelBtn.UseVisualStyleBackColor = true;
            this.RemoveSelBtn.Click += new System.EventHandler(this.RemoveSelBtn_Click);
            // 
            // PurchaseBtn
            // 
            this.PurchaseBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PurchaseBtn.BackgroundImage")));
            this.PurchaseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PurchaseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PurchaseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PurchaseBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.PurchaseBtn.Location = new System.Drawing.Point(186, 444);
            this.PurchaseBtn.Name = "PurchaseBtn";
            this.PurchaseBtn.Size = new System.Drawing.Size(140, 30);
            this.PurchaseBtn.TabIndex = 3;
            this.PurchaseBtn.Text = "Purchase All";
            this.PurchaseBtn.UseVisualStyleBackColor = true;
            this.PurchaseBtn.Click += new System.EventHandler(this.PurchaseBtn_Click);
            // 
            // Backbtn
            // 
            this.Backbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Backbtn.BackgroundImage")));
            this.Backbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Backbtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Backbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backbtn.ForeColor = System.Drawing.SystemColors.Window;
            this.Backbtn.Location = new System.Drawing.Point(171, 494);
            this.Backbtn.Name = "Backbtn";
            this.Backbtn.Size = new System.Drawing.Size(80, 30);
            this.Backbtn.TabIndex = 4;
            this.Backbtn.Text = "Back";
            this.Backbtn.UseVisualStyleBackColor = true;
            this.Backbtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExitBtn.BackgroundImage")));
            this.ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.ExitBtn.Location = new System.Drawing.Point(257, 494);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(80, 30);
            this.ExitBtn.TabIndex = 5;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // OrderLbl
            // 
            this.OrderLbl.AutoSize = true;
            this.OrderLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderLbl.Location = new System.Drawing.Point(276, 280);
            this.OrderLbl.Name = "OrderLbl";
            this.OrderLbl.Size = new System.Drawing.Size(45, 16);
            this.OrderLbl.TabIndex = 12;
            this.OrderLbl.Text = "label4";
            // 
            // ItemsLbl
            // 
            this.ItemsLbl.AutoSize = true;
            this.ItemsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemsLbl.Location = new System.Drawing.Point(287, 313);
            this.ItemsLbl.Name = "ItemsLbl";
            this.ItemsLbl.Size = new System.Drawing.Size(45, 16);
            this.ItemsLbl.TabIndex = 13;
            this.ItemsLbl.Text = "label5";
            // 
            // ValueLbl
            // 
            this.ValueLbl.AutoSize = true;
            this.ValueLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValueLbl.Location = new System.Drawing.Point(287, 345);
            this.ValueLbl.Name = "ValueLbl";
            this.ValueLbl.Size = new System.Drawing.Size(45, 16);
            this.ValueLbl.TabIndex = 14;
            this.ValueLbl.Text = "label6";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(263, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Rs.";
            // 
            // CartFrm
            // 
            this.AcceptButton = this.PurchaseBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.CancelButton = this.Backbtn;
            this.ClientSize = new System.Drawing.Size(528, 540);
            this.Controls.Add(this.label4);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CartFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cart";
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
        private System.Windows.Forms.Label label4;
    }
}