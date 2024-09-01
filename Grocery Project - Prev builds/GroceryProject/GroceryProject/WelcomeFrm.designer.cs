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
            this.LoginBtn = new System.Windows.Forms.Button();
            this.SignupBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(85, 31);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(114, 43);
            this.LoginBtn.TabIndex = 0;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // SignupBtn
            // 
            this.SignupBtn.Location = new System.Drawing.Point(85, 99);
            this.SignupBtn.Name = "SignupBtn";
            this.SignupBtn.Size = new System.Drawing.Size(114, 43);
            this.SignupBtn.TabIndex = 1;
            this.SignupBtn.Text = "Sign up";
            this.SignupBtn.UseVisualStyleBackColor = true;
            this.SignupBtn.Click += new System.EventHandler(this.SignupBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(98, 176);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(89, 35);
            this.ExitBtn.TabIndex = 2;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // WelcomeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 232);
            this.Controls.Add(this.SignupBtn);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.ExitBtn);
            this.Name = "WelcomeFrm";
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