namespace GroceryProject
{
    partial class AdminInterfaceFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminInterfaceFrm));
            this.ExitBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.ViewBtn = new System.Windows.Forms.Button();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.PssBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExitBtn.BackgroundImage")));
            this.ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.ExitBtn.Location = new System.Drawing.Point(196, 247);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(90, 40);
            this.ExitBtn.TabIndex = 8;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BackBtn.BackgroundImage")));
            this.BackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.BackBtn.Location = new System.Drawing.Point(100, 247);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(90, 40);
            this.BackBtn.TabIndex = 7;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddBtn.BackgroundImage")));
            this.AddBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.AddBtn.Location = new System.Drawing.Point(126, 36);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(137, 40);
            this.AddBtn.TabIndex = 5;
            this.AddBtn.Text = "Add Account";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // ViewBtn
            // 
            this.ViewBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ViewBtn.BackgroundImage")));
            this.ViewBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ViewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.ViewBtn.Location = new System.Drawing.Point(126, 137);
            this.ViewBtn.Name = "ViewBtn";
            this.ViewBtn.Size = new System.Drawing.Size(137, 40);
            this.ViewBtn.TabIndex = 9;
            this.ViewBtn.Text = "View Accounts";
            this.ViewBtn.UseVisualStyleBackColor = true;
            this.ViewBtn.Click += new System.EventHandler(this.ViewBtn_Click);
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RemoveBtn.BackgroundImage")));
            this.RemoveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RemoveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.RemoveBtn.Location = new System.Drawing.Point(126, 82);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(137, 40);
            this.RemoveBtn.TabIndex = 10;
            this.RemoveBtn.Text = "Remove Account";
            this.RemoveBtn.UseVisualStyleBackColor = true;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // PssBtn
            // 
            this.PssBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PssBtn.BackgroundImage")));
            this.PssBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PssBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PssBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PssBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.PssBtn.Location = new System.Drawing.Point(126, 183);
            this.PssBtn.Name = "PssBtn";
            this.PssBtn.Size = new System.Drawing.Size(137, 40);
            this.PssBtn.TabIndex = 11;
            this.PssBtn.Text = "Change Password";
            this.PssBtn.UseVisualStyleBackColor = true;
            this.PssBtn.Click += new System.EventHandler(this.PssBtn_Click);
            // 
            // AdminInterfaceFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(373, 299);
            this.Controls.Add(this.PssBtn);
            this.Controls.Add(this.RemoveBtn);
            this.Controls.Add(this.ViewBtn);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.AddBtn);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminInterfaceFrm";
            this.Text = "Admin Interface";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button ViewBtn;
        private System.Windows.Forms.Button RemoveBtn;
        private System.Windows.Forms.Button PssBtn;
    }
}