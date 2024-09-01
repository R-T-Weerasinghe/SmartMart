namespace Esoft_last_project
{
    partial class CustomerInterfaceFrm
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
            this.BuyBtn = new System.Windows.Forms.Button();
            this.ManageBtn = new System.Windows.Forms.Button();
            this.WalletBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BuyBtn
            // 
            this.BuyBtn.Location = new System.Drawing.Point(77, 49);
            this.BuyBtn.Name = "BuyBtn";
            this.BuyBtn.Size = new System.Drawing.Size(127, 41);
            this.BuyBtn.TabIndex = 0;
            this.BuyBtn.Text = "Buy Items";
            this.BuyBtn.UseVisualStyleBackColor = true;
            this.BuyBtn.Click += new System.EventHandler(this.BuyBtn_Click);
            // 
            // ManageBtn
            // 
            this.ManageBtn.Location = new System.Drawing.Point(77, 141);
            this.ManageBtn.Name = "ManageBtn";
            this.ManageBtn.Size = new System.Drawing.Size(127, 39);
            this.ManageBtn.TabIndex = 2;
            this.ManageBtn.Text = "Manage Account";
            this.ManageBtn.UseVisualStyleBackColor = true;
            this.ManageBtn.Click += new System.EventHandler(this.ManageBtn_Click);
            // 
            // WalletBtn
            // 
            this.WalletBtn.Location = new System.Drawing.Point(77, 96);
            this.WalletBtn.Name = "WalletBtn";
            this.WalletBtn.Size = new System.Drawing.Size(127, 39);
            this.WalletBtn.TabIndex = 1;
            this.WalletBtn.Text = "My Wallet";
            this.WalletBtn.UseVisualStyleBackColor = true;
            this.WalletBtn.Click += new System.EventHandler(this.WalletBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(58, 210);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(74, 39);
            this.BackBtn.TabIndex = 3;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(138, 210);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(78, 39);
            this.ExitBtn.TabIndex = 4;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // CustomerInterfaceFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.WalletBtn);
            this.Controls.Add(this.ManageBtn);
            this.Controls.Add(this.BuyBtn);
            this.Name = "CustomerInterfaceFrm";
            this.Text = "Customer Interface";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BuyBtn;
        private System.Windows.Forms.Button ManageBtn;
        private System.Windows.Forms.Button WalletBtn;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button ExitBtn;
    }
}