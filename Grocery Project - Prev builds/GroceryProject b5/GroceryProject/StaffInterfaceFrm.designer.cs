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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffInterfaceFrm));
            this.EditBtn = new System.Windows.Forms.Button();
            this.ManageBtn = new System.Windows.Forms.Button();
            this.OrderBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EditBtn
            // 
            this.EditBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EditBtn.BackgroundImage")));
            this.EditBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.EditBtn.Location = new System.Drawing.Point(89, 35);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(120, 40);
            this.EditBtn.TabIndex = 1;
            this.EditBtn.Text = "Edit Items";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // ManageBtn
            // 
            this.ManageBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ManageBtn.BackgroundImage")));
            this.ManageBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ManageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManageBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.ManageBtn.Location = new System.Drawing.Point(89, 150);
            this.ManageBtn.Name = "ManageBtn";
            this.ManageBtn.Size = new System.Drawing.Size(120, 40);
            this.ManageBtn.TabIndex = 3;
            this.ManageBtn.Text = "My Account";
            this.ManageBtn.UseVisualStyleBackColor = true;
            this.ManageBtn.Click += new System.EventHandler(this.ManageBtn_Click);
            // 
            // OrderBtn
            // 
            this.OrderBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OrderBtn.BackgroundImage")));
            this.OrderBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OrderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.OrderBtn.Location = new System.Drawing.Point(89, 104);
            this.OrderBtn.Name = "OrderBtn";
            this.OrderBtn.Size = new System.Drawing.Size(120, 40);
            this.OrderBtn.TabIndex = 2;
            this.OrderBtn.Text = "Orders";
            this.OrderBtn.UseVisualStyleBackColor = true;
            this.OrderBtn.Click += new System.EventHandler(this.OrderBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BackBtn.BackgroundImage")));
            this.BackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.BackBtn.Location = new System.Drawing.Point(57, 213);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(90, 40);
            this.BackBtn.TabIndex = 4;
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
            this.ExitBtn.Location = new System.Drawing.Point(153, 213);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(90, 40);
            this.ExitBtn.TabIndex = 5;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // StaffInterfaceFrm
            // 
            this.AcceptButton = this.EditBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.CancelButton = this.BackBtn;
            this.ClientSize = new System.Drawing.Size(302, 280);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.OrderBtn);
            this.Controls.Add(this.ManageBtn);
            this.Controls.Add(this.EditBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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