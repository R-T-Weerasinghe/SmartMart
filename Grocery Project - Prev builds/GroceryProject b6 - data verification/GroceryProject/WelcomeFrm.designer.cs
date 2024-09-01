namespace Esoft_last_project
{
    partial class WelcomeFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeFrm));
            this.LoginBtn = new System.Windows.Forms.Button();
            this.SignupBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LoginBtn.BackgroundImage")));
            this.LoginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.LoginBtn.Location = new System.Drawing.Point(85, 31);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(120, 40);
            this.LoginBtn.TabIndex = 1;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // SignupBtn
            // 
            this.SignupBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SignupBtn.BackgroundImage")));
            this.SignupBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignupBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignupBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignupBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.SignupBtn.Location = new System.Drawing.Point(85, 90);
            this.SignupBtn.Name = "SignupBtn";
            this.SignupBtn.Size = new System.Drawing.Size(120, 40);
            this.SignupBtn.TabIndex = 2;
            this.SignupBtn.Text = "Sign up";
            this.SignupBtn.UseVisualStyleBackColor = true;
            this.SignupBtn.Click += new System.EventHandler(this.SignupBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExitBtn.BackgroundImage")));
            this.ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.ExitBtn.Location = new System.Drawing.Point(98, 151);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(90, 40);
            this.ExitBtn.TabIndex = 3;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // WelcomeFrm
            // 
            this.AcceptButton = this.LoginBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.CancelButton = this.ExitBtn;
            this.ClientSize = new System.Drawing.Size(284, 232);
            this.Controls.Add(this.SignupBtn);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.ExitBtn);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WelcomeFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome ";
            this.Load += new System.EventHandler(this.AppWelcomeFrm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Button SignupBtn;
        private System.Windows.Forms.Button ExitBtn;
    }
}