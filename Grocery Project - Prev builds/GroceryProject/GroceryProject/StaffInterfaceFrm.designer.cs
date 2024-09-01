namespace Esoft_last_project
{
    partial class StaffInterfaceFrm
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
            this.EditBtn = new System.Windows.Forms.Button();
            this.ManageBtn = new System.Windows.Forms.Button();
            this.OrderBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(89, 35);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(132, 34);
            this.EditBtn.TabIndex = 0;
            this.EditBtn.Text = "Edit Items";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // ManageBtn
            // 
            this.ManageBtn.Location = new System.Drawing.Point(89, 150);
            this.ManageBtn.Name = "ManageBtn";
            this.ManageBtn.Size = new System.Drawing.Size(132, 34);
            this.ManageBtn.TabIndex = 1;
            this.ManageBtn.Text = "Manage Account";
            this.ManageBtn.UseVisualStyleBackColor = true;
            this.ManageBtn.Click += new System.EventHandler(this.ManageBtn_Click);
            // 
            // OrderBtn
            // 
            this.OrderBtn.Location = new System.Drawing.Point(89, 92);
            this.OrderBtn.Name = "OrderBtn";
            this.OrderBtn.Size = new System.Drawing.Size(132, 34);
            this.OrderBtn.TabIndex = 2;
            this.OrderBtn.Text = "Orders";
            this.OrderBtn.UseVisualStyleBackColor = true;
            this.OrderBtn.Click += new System.EventHandler(this.OrderBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(21, 290);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(132, 34);
            this.BackBtn.TabIndex = 3;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(179, 290);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(132, 34);
            this.ExitBtn.TabIndex = 4;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // StaffInterfaceFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 347);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.OrderBtn);
            this.Controls.Add(this.ManageBtn);
            this.Controls.Add(this.EditBtn);
            this.Name = "StaffInterfaceFrm";
            this.Text = "Staff Interface";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button ManageBtn;
        private System.Windows.Forms.Button OrderBtn;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button ExitBtn;
    }
}