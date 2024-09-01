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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Available Balance :";
            // 
            // BackBtn
            // 
            this.BackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.Location = new System.Drawing.Point(33, 224);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(113, 35);
            this.BackBtn.TabIndex = 6;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.Location = new System.Drawing.Point(152, 224);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(114, 35);
            this.ExitBtn.TabIndex = 7;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Previous order value :";
            // 
            // PrevLbl
            // 
            this.PrevLbl.AutoSize = true;
            this.PrevLbl.Location = new System.Drawing.Point(177, 32);
            this.PrevLbl.Name = "PrevLbl";
            this.PrevLbl.Size = new System.Drawing.Size(103, 13);
            this.PrevLbl.TabIndex = 5;
            this.PrevLbl.Text = "( not completed yet )";
            this.PrevLbl.Click += new System.EventHandler(this.AccLbl_Click);
            // 
            // BalLbl
            // 
            this.BalLbl.AutoSize = true;
            this.BalLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalLbl.Location = new System.Drawing.Point(190, 62);
            this.BalLbl.Name = "BalLbl";
            this.BalLbl.Size = new System.Drawing.Size(76, 20);
            this.BalLbl.TabIndex = 6;
            this.BalLbl.Text = "00000.00";
            this.BalLbl.Click += new System.EventHandler(this.BalLbl_Click);
            // 
            // PrevBtn
            // 
            this.PrevBtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrevBtn.Location = new System.Drawing.Point(33, 185);
            this.PrevBtn.Name = "PrevBtn";
            this.PrevBtn.Size = new System.Drawing.Size(234, 33);
            this.PrevBtn.TabIndex = 5;
            this.PrevBtn.Text = "Previous Payments";
            this.PrevBtn.UseVisualStyleBackColor = true;
            this.PrevBtn.Click += new System.EventHandler(this.PrevBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Enter the amount :";
            // 
            // AmountTxt
            // 
            this.AmountTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountTxt.Location = new System.Drawing.Point(167, 91);
            this.AmountTxt.Name = "AmountTxt";
            this.AmountTxt.Size = new System.Drawing.Size(100, 26);
            this.AmountTxt.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(161, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Rs.";
            this.label4.Click += new System.EventHandler(this.BalLbl_Click);
            // 
            // P500Btn
            // 
            this.P500Btn.Location = new System.Drawing.Point(33, 146);
            this.P500Btn.Name = "P500Btn";
            this.P500Btn.Size = new System.Drawing.Size(64, 33);
            this.P500Btn.TabIndex = 2;
            this.P500Btn.Text = "+500";
            this.P500Btn.UseVisualStyleBackColor = true;
            this.P500Btn.Click += new System.EventHandler(this.P500Btn_Click);
            // 
            // P1000Btn
            // 
            this.P1000Btn.Location = new System.Drawing.Point(104, 146);
            this.P1000Btn.Name = "P1000Btn";
            this.P1000Btn.Size = new System.Drawing.Size(67, 33);
            this.P1000Btn.TabIndex = 3;
            this.P1000Btn.Text = "+1000";
            this.P1000Btn.UseVisualStyleBackColor = true;
            this.P1000Btn.Click += new System.EventHandler(this.P1000Btn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(180, 146);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(86, 33);
            this.AddBtn.TabIndex = 4;
            this.AddBtn.Text = "Add ";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // WalletFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 271);
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
            this.Name = "WalletFrm";
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
    }
}