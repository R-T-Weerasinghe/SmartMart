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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerInterfaceFrm));
            this.BuyBtn = new System.Windows.Forms.Button();
            this.ManageBtn = new System.Windows.Forms.Button();
            this.WalletBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BuyBtn
            // 
            this.BuyBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BuyBtn.BackgroundImage")));
            this.BuyBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BuyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuyBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.BuyBtn.Location = new System.Drawing.Point(87, 20);
            this.BuyBtn.Name = "BuyBtn";
            this.BuyBtn.Size = new System.Drawing.Size(120, 40);
            this.BuyBtn.TabIndex = 0;
            this.BuyBtn.Text = "Buy Items";
            this.BuyBtn.UseVisualStyleBackColor = true;
            this.BuyBtn.Click += new System.EventHandler(this.BuyBtn_Click);
            // 
            // ManageBtn
            // 
            this.ManageBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ManageBtn.BackgroundImage")));
            this.ManageBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ManageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManageBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.ManageBtn.Location = new System.Drawing.Point(87, 129);
            this.ManageBtn.Name = "ManageBtn";
            this.ManageBtn.Size = new System.Drawing.Size(120, 40);
            this.ManageBtn.TabIndex = 2;
            this.ManageBtn.Text = "My Account";
            this.ManageBtn.UseVisualStyleBackColor = true;
            this.ManageBtn.Click += new System.EventHandler(this.ManageBtn_Click);
            // 
            // WalletBtn
            // 
            this.WalletBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("WalletBtn.BackgroundImage")));
            this.WalletBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WalletBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WalletBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WalletBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.WalletBtn.Location = new System.Drawing.Point(87, 83);
            this.WalletBtn.Name = "WalletBtn";
            this.WalletBtn.Size = new System.Drawing.Size(120, 40);
            this.WalletBtn.TabIndex = 1;
            this.WalletBtn.Text = "My Wallet";
            this.WalletBtn.UseVisualStyleBackColor = true;
            this.WalletBtn.Click += new System.EventHandler(this.WalletBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BackBtn.BackgroundImage")));
            this.BackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.BackBtn.Location = new System.Drawing.Point(54, 192);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(90, 40);
            this.BackBtn.TabIndex = 3;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExitBtn.BackgroundImage")));
            this.ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.ExitBtn.Location = new System.Drawing.Point(150, 192);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(90, 40);
            this.ExitBtn.TabIndex = 4;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // CustomerInterfaceFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(285, 256);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.WalletBtn);
            this.Controls.Add(this.ManageBtn);
            this.Controls.Add(this.BuyBtn);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomerInterfaceFrm";
            this.Text = "Customer Interface";
            this.Load += new System.EventHandler(this.CustomerInterfaceFrm_Load);
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