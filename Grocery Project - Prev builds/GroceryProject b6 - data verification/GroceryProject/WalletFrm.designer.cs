namespace Esoft_last_project
{
    partial class WalletFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WalletFrm));
            this.label1 = new System.Windows.Forms.Label();
            this.BackBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.PrevLbl = new System.Windows.Forms.Label();
            this.BalLbl = new System.Windows.Forms.Label();
            this.PrevBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.AmountTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.P500Btn = new System.Windows.Forms.Button();
            this.P1000Btn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Available Balance :";
            // 
            // BackBtn
            // 
            this.BackBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BackBtn.BackgroundImage")));
            this.BackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.BackBtn.Location = new System.Drawing.Point(94, 224);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(80, 30);
            this.BackBtn.TabIndex = 6;
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
            this.ExitBtn.Location = new System.Drawing.Point(180, 225);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(80, 30);
            this.ExitBtn.TabIndex = 7;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Previous order value :";
            // 
            // PrevLbl
            // 
            this.PrevLbl.AutoSize = true;
            this.PrevLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrevLbl.Location = new System.Drawing.Point(217, 27);
            this.PrevLbl.Name = "PrevLbl";
            this.PrevLbl.Size = new System.Drawing.Size(39, 16);
            this.PrevLbl.TabIndex = 5;
            this.PrevLbl.Text = "00.00";
            this.PrevLbl.Click += new System.EventHandler(this.AccLbl_Click);
            // 
            // BalLbl
            // 
            this.BalLbl.AutoSize = true;
            this.BalLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalLbl.Location = new System.Drawing.Point(217, 62);
            this.BalLbl.Name = "BalLbl";
            this.BalLbl.Size = new System.Drawing.Size(39, 16);
            this.BalLbl.TabIndex = 6;
            this.BalLbl.Text = "00.00";
            this.BalLbl.Click += new System.EventHandler(this.BalLbl_Click);
            // 
            // PrevBtn
            // 
            this.PrevBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PrevBtn.BackgroundImage")));
            this.PrevBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PrevBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrevBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrevBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.PrevBtn.Location = new System.Drawing.Point(34, 152);
            this.PrevBtn.Name = "PrevBtn";
            this.PrevBtn.Size = new System.Drawing.Size(140, 30);
            this.PrevBtn.TabIndex = 2;
            this.PrevBtn.Text = "Payments";
            this.PrevBtn.UseVisualStyleBackColor = true;
            this.PrevBtn.Click += new System.EventHandler(this.PrevBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Enter the amount :";
            // 
            // AmountTxt
            // 
            this.AmountTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountTxt.Location = new System.Drawing.Point(187, 94);
            this.AmountTxt.Name = "AmountTxt";
            this.AmountTxt.Size = new System.Drawing.Size(109, 22);
            this.AmountTxt.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(183, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Rs.";
            this.label4.Click += new System.EventHandler(this.BalLbl_Click);
            // 
            // P500Btn
            // 
            this.P500Btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("P500Btn.BackgroundImage")));
            this.P500Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.P500Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.P500Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P500Btn.ForeColor = System.Drawing.SystemColors.Window;
            this.P500Btn.Location = new System.Drawing.Point(34, 188);
            this.P500Btn.Name = "P500Btn";
            this.P500Btn.Size = new System.Drawing.Size(140, 30);
            this.P500Btn.TabIndex = 4;
            this.P500Btn.Text = "+500";
            this.P500Btn.UseVisualStyleBackColor = true;
            this.P500Btn.Click += new System.EventHandler(this.P500Btn_Click);
            // 
            // P1000Btn
            // 
            this.P1000Btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("P1000Btn.BackgroundImage")));
            this.P1000Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.P1000Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.P1000Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P1000Btn.ForeColor = System.Drawing.SystemColors.Window;
            this.P1000Btn.Location = new System.Drawing.Point(180, 189);
            this.P1000Btn.Name = "P1000Btn";
            this.P1000Btn.Size = new System.Drawing.Size(140, 30);
            this.P1000Btn.TabIndex = 5;
            this.P1000Btn.Text = "+1000";
            this.P1000Btn.UseVisualStyleBackColor = true;
            this.P1000Btn.Click += new System.EventHandler(this.P1000Btn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddBtn.BackgroundImage")));
            this.AddBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.AddBtn.Location = new System.Drawing.Point(180, 152);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(140, 30);
            this.AddBtn.TabIndex = 3;
            this.AddBtn.Text = "Add ";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(184, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Rs.";
            // 
            // WalletFrm
            // 
            this.AcceptButton = this.AddBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.CancelButton = this.BackBtn;
            this.ClientSize = new System.Drawing.Size(363, 265);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.P1000Btn);
            this.Controls.Add(this.P500Btn);
            this.Controls.Add(this.BalLbl);
            this.Controls.Add(this.AmountTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PrevBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PrevLbl);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WalletFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Wallet";
            this.Load += new System.EventHandler(this.WalletFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label PrevLbl;
        private System.Windows.Forms.Label BalLbl;
        private System.Windows.Forms.Button PrevBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AmountTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button P500Btn;
        private System.Windows.Forms.Button P1000Btn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Label label5;
    }
}