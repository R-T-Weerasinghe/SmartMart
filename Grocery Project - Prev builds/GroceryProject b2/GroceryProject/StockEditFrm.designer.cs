﻿namespace Esoft_last_project
{
    partial class StockEditFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockEditFrm));
            this.NameChk = new System.Windows.Forms.CheckBox();
            this.ManuChk = new System.Windows.Forms.CheckBox();
            this.ExpChk = new System.Windows.Forms.CheckBox();
            this.QtyChk = new System.Windows.Forms.CheckBox();
            this.SoldChk = new System.Windows.Forms.CheckBox();
            this.QtyTxt = new System.Windows.Forms.TextBox();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.SoldTxt = new System.Windows.Forms.TextBox();
            this.ExpTxt = new System.Windows.Forms.TextBox();
            this.MfdTxt = new System.Windows.Forms.TextBox();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.SelectBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.UnselectBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.SearchTxt = new System.Windows.Forms.TextBox();
            this.SearchCom = new System.Windows.Forms.ComboBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ItemPictureBox = new System.Windows.Forms.PictureBox();
            this.DescChk = new System.Windows.Forms.CheckBox();
            this.DescTxt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NewRefIDTxt = new System.Windows.Forms.TextBox();
            this.NewRefIDChk = new System.Windows.Forms.CheckBox();
            this.RefIDTxt = new System.Windows.Forms.TextBox();
            this.RefidChk = new System.Windows.Forms.CheckBox();
            this.PrizeChk = new System.Windows.Forms.CheckBox();
            this.PrizeTxt = new System.Windows.Forms.TextBox();
            this.WeightVolumeTxt = new System.Windows.Forms.TextBox();
            this.SupTxt = new System.Windows.Forms.TextBox();
            this.SupChk = new System.Windows.Forms.CheckBox();
            this.WeightVolumeChk = new System.Windows.Forms.CheckBox();
            this.ImportBtn = new System.Windows.Forms.Button();
            this.PathChk = new System.Windows.Forms.CheckBox();
            this.PathTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ItemPictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameChk
            // 
            this.NameChk.AutoSize = true;
            this.NameChk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameChk.Location = new System.Drawing.Point(30, 77);
            this.NameChk.Name = "NameChk";
            this.NameChk.Size = new System.Drawing.Size(92, 20);
            this.NameChk.TabIndex = 1;
            this.NameChk.Text = "Item Name";
            this.NameChk.UseVisualStyleBackColor = true;
            // 
            // ManuChk
            // 
            this.ManuChk.AutoSize = true;
            this.ManuChk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManuChk.Location = new System.Drawing.Point(58, 410);
            this.ManuChk.Name = "ManuChk";
            this.ManuChk.Size = new System.Drawing.Size(93, 20);
            this.ManuChk.TabIndex = 5;
            this.ManuChk.Text = "Manu. date";
            this.ManuChk.UseVisualStyleBackColor = true;
            this.ManuChk.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // ExpChk
            // 
            this.ExpChk.AutoSize = true;
            this.ExpChk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpChk.Location = new System.Drawing.Point(58, 438);
            this.ExpChk.Name = "ExpChk";
            this.ExpChk.Size = new System.Drawing.Size(94, 20);
            this.ExpChk.TabIndex = 6;
            this.ExpChk.Text = "Expiry date";
            this.ExpChk.UseVisualStyleBackColor = true;
            // 
            // QtyChk
            // 
            this.QtyChk.AutoSize = true;
            this.QtyChk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QtyChk.Location = new System.Drawing.Point(387, 438);
            this.QtyChk.Name = "QtyChk";
            this.QtyChk.Size = new System.Drawing.Size(135, 20);
            this.QtyChk.TabIndex = 7;
            this.QtyChk.Text = "Available Quantity";
            this.QtyChk.UseVisualStyleBackColor = true;
            // 
            // SoldChk
            // 
            this.SoldChk.AutoSize = true;
            this.SoldChk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoldChk.Location = new System.Drawing.Point(387, 408);
            this.SoldChk.Name = "SoldChk";
            this.SoldChk.Size = new System.Drawing.Size(90, 20);
            this.SoldChk.TabIndex = 8;
            this.SoldChk.Text = "Sold Items";
            this.SoldChk.UseVisualStyleBackColor = true;
            // 
            // QtyTxt
            // 
            this.QtyTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QtyTxt.Location = new System.Drawing.Point(516, 436);
            this.QtyTxt.Name = "QtyTxt";
            this.QtyTxt.Size = new System.Drawing.Size(153, 22);
            this.QtyTxt.TabIndex = 11;
            // 
            // NameTxt
            // 
            this.NameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTxt.Location = new System.Drawing.Point(161, 75);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(153, 22);
            this.NameTxt.TabIndex = 12;
            // 
            // SoldTxt
            // 
            this.SoldTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoldTxt.Location = new System.Drawing.Point(516, 408);
            this.SoldTxt.Name = "SoldTxt";
            this.SoldTxt.Size = new System.Drawing.Size(153, 22);
            this.SoldTxt.TabIndex = 13;
            // 
            // ExpTxt
            // 
            this.ExpTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpTxt.Location = new System.Drawing.Point(188, 436);
            this.ExpTxt.Name = "ExpTxt";
            this.ExpTxt.Size = new System.Drawing.Size(153, 22);
            this.ExpTxt.TabIndex = 19;
            // 
            // MfdTxt
            // 
            this.MfdTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MfdTxt.Location = new System.Drawing.Point(188, 408);
            this.MfdTxt.Name = "MfdTxt";
            this.MfdTxt.Size = new System.Drawing.Size(153, 22);
            this.MfdTxt.TabIndex = 20;
            // 
            // ClearBtn
            // 
            this.ClearBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ClearBtn.BackgroundImage")));
            this.ClearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.ClearBtn.Location = new System.Drawing.Point(212, 487);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(140, 30);
            this.ClearBtn.TabIndex = 24;
            this.ClearBtn.Text = "Clear Selections";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // SelectBtn
            // 
            this.SelectBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SelectBtn.BackgroundImage")));
            this.SelectBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SelectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.SelectBtn.Location = new System.Drawing.Point(358, 487);
            this.SelectBtn.Name = "SelectBtn";
            this.SelectBtn.Size = new System.Drawing.Size(140, 30);
            this.SelectBtn.TabIndex = 25;
            this.SelectBtn.Text = "Select All";
            this.SelectBtn.UseVisualStyleBackColor = true;
            this.SelectBtn.Click += new System.EventHandler(this.SelectBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SaveBtn.BackgroundImage")));
            this.SaveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.SaveBtn.Location = new System.Drawing.Point(140, 523);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(140, 30);
            this.SaveBtn.TabIndex = 26;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UpdateBtn.BackgroundImage")));
            this.UpdateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.UpdateBtn.Location = new System.Drawing.Point(286, 523);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(140, 30);
            this.UpdateBtn.TabIndex = 27;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DeleteBtn.BackgroundImage")));
            this.DeleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.DeleteBtn.Location = new System.Drawing.Point(432, 523);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(140, 30);
            this.DeleteBtn.TabIndex = 28;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EditBtn.BackgroundImage")));
            this.EditBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.EditBtn.Location = new System.Drawing.Point(66, 487);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(140, 30);
            this.EditBtn.TabIndex = 29;
            this.EditBtn.Text = "Quick View Database";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExitBtn.BackgroundImage")));
            this.ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.ExitBtn.Location = new System.Drawing.Point(358, 559);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(80, 30);
            this.ExitBtn.TabIndex = 30;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // UnselectBtn
            // 
            this.UnselectBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UnselectBtn.BackgroundImage")));
            this.UnselectBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UnselectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UnselectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnselectBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.UnselectBtn.Location = new System.Drawing.Point(504, 487);
            this.UnselectBtn.Name = "UnselectBtn";
            this.UnselectBtn.Size = new System.Drawing.Size(140, 30);
            this.UnselectBtn.TabIndex = 32;
            this.UnselectBtn.Text = "Unselect All";
            this.UnselectBtn.UseVisualStyleBackColor = true;
            this.UnselectBtn.Click += new System.EventHandler(this.UnselectBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BackBtn.BackgroundImage")));
            this.BackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.BackBtn.Location = new System.Drawing.Point(272, 559);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(80, 30);
            this.BackBtn.TabIndex = 33;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // SearchTxt
            // 
            this.SearchTxt.Location = new System.Drawing.Point(195, 29);
            this.SearchTxt.Name = "SearchTxt";
            this.SearchTxt.Size = new System.Drawing.Size(100, 20);
            this.SearchTxt.TabIndex = 34;
            this.SearchTxt.TextChanged += new System.EventHandler(this.SearchTxt_TextChanged);
            // 
            // SearchCom
            // 
            this.SearchCom.FormattingEnabled = true;
            this.SearchCom.Items.AddRange(new object[] {
            "Ref. ID",
            "Item Name"});
            this.SearchCom.Location = new System.Drawing.Point(347, 29);
            this.SearchCom.Name = "SearchCom";
            this.SearchCom.Size = new System.Drawing.Size(84, 21);
            this.SearchCom.TabIndex = 35;
            this.SearchCom.SelectedIndexChanged += new System.EventHandler(this.SearchCom_SelectedIndexChanged);
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SearchBtn.BackgroundImage")));
            this.SearchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SearchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.SearchBtn.Location = new System.Drawing.Point(437, 28);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(75, 23);
            this.SearchBtn.TabIndex = 36;
            this.SearchBtn.Text = "GO";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(301, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 37;
            this.label1.Text = "using";
            // 
            // ItemPictureBox
            // 
            this.ItemPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ItemPictureBox.Location = new System.Drawing.Point(32, 26);
            this.ItemPictureBox.Name = "ItemPictureBox";
            this.ItemPictureBox.Size = new System.Drawing.Size(222, 222);
            this.ItemPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ItemPictureBox.TabIndex = 38;
            this.ItemPictureBox.TabStop = false;
            // 
            // DescChk
            // 
            this.DescChk.AutoSize = true;
            this.DescChk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescChk.Location = new System.Drawing.Point(30, 105);
            this.DescChk.Name = "DescChk";
            this.DescChk.Size = new System.Drawing.Size(123, 20);
            this.DescChk.TabIndex = 42;
            this.DescChk.Text = "Item Description";
            this.DescChk.UseVisualStyleBackColor = true;
            // 
            // DescTxt
            // 
            this.DescTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescTxt.Location = new System.Drawing.Point(30, 131);
            this.DescTxt.Multiline = true;
            this.DescTxt.Name = "DescTxt";
            this.DescTxt.Size = new System.Drawing.Size(284, 86);
            this.DescTxt.TabIndex = 43;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ImportBtn);
            this.groupBox1.Controls.Add(this.ItemPictureBox);
            this.groupBox1.Controls.Add(this.PathChk);
            this.groupBox1.Controls.Add(this.PathTxt);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(387, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 335);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Import Image";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PrizeChk);
            this.groupBox2.Controls.Add(this.PrizeTxt);
            this.groupBox2.Controls.Add(this.RefIDTxt);
            this.groupBox2.Controls.Add(this.WeightVolumeTxt);
            this.groupBox2.Controls.Add(this.NewRefIDTxt);
            this.groupBox2.Controls.Add(this.SupTxt);
            this.groupBox2.Controls.Add(this.RefidChk);
            this.groupBox2.Controls.Add(this.SupChk);
            this.groupBox2.Controls.Add(this.NewRefIDChk);
            this.groupBox2.Controls.Add(this.WeightVolumeChk);
            this.groupBox2.Controls.Add(this.DescChk);
            this.groupBox2.Controls.Add(this.NameChk);
            this.groupBox2.Controls.Add(this.NameTxt);
            this.groupBox2.Controls.Add(this.DescTxt);
            this.groupBox2.Location = new System.Drawing.Point(28, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(339, 334);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            // 
            // NewRefIDTxt
            // 
            this.NewRefIDTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewRefIDTxt.Location = new System.Drawing.Point(161, 47);
            this.NewRefIDTxt.Name = "NewRefIDTxt";
            this.NewRefIDTxt.Size = new System.Drawing.Size(153, 22);
            this.NewRefIDTxt.TabIndex = 44;
            // 
            // NewRefIDChk
            // 
            this.NewRefIDChk.AutoSize = true;
            this.NewRefIDChk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewRefIDChk.Location = new System.Drawing.Point(30, 49);
            this.NewRefIDChk.Name = "NewRefIDChk";
            this.NewRefIDChk.Size = new System.Drawing.Size(94, 20);
            this.NewRefIDChk.TabIndex = 43;
            this.NewRefIDChk.Text = "New Ref.ID";
            this.NewRefIDChk.UseVisualStyleBackColor = true;
            // 
            // RefIDTxt
            // 
            this.RefIDTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefIDTxt.Location = new System.Drawing.Point(161, 19);
            this.RefIDTxt.Name = "RefIDTxt";
            this.RefIDTxt.Size = new System.Drawing.Size(153, 22);
            this.RefIDTxt.TabIndex = 47;
            // 
            // RefidChk
            // 
            this.RefidChk.AutoSize = true;
            this.RefidChk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefidChk.Location = new System.Drawing.Point(30, 21);
            this.RefidChk.Name = "RefidChk";
            this.RefidChk.Size = new System.Drawing.Size(106, 20);
            this.RefidChk.TabIndex = 46;
            this.RefidChk.Text = "Reference ID";
            this.RefidChk.UseVisualStyleBackColor = true;
            // 
            // PrizeChk
            // 
            this.PrizeChk.AutoSize = true;
            this.PrizeChk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrizeChk.Location = new System.Drawing.Point(30, 227);
            this.PrizeChk.Name = "PrizeChk";
            this.PrizeChk.Size = new System.Drawing.Size(86, 20);
            this.PrizeChk.TabIndex = 46;
            this.PrizeChk.Text = "Item Price";
            this.PrizeChk.UseVisualStyleBackColor = true;
            // 
            // PrizeTxt
            // 
            this.PrizeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrizeTxt.Location = new System.Drawing.Point(161, 225);
            this.PrizeTxt.Name = "PrizeTxt";
            this.PrizeTxt.Size = new System.Drawing.Size(153, 22);
            this.PrizeTxt.TabIndex = 51;
            // 
            // WeightVolumeTxt
            // 
            this.WeightVolumeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightVolumeTxt.Location = new System.Drawing.Point(161, 253);
            this.WeightVolumeTxt.Name = "WeightVolumeTxt";
            this.WeightVolumeTxt.Size = new System.Drawing.Size(153, 22);
            this.WeightVolumeTxt.TabIndex = 50;
            // 
            // SupTxt
            // 
            this.SupTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupTxt.Location = new System.Drawing.Point(161, 281);
            this.SupTxt.Name = "SupTxt";
            this.SupTxt.Size = new System.Drawing.Size(153, 22);
            this.SupTxt.TabIndex = 49;
            // 
            // SupChk
            // 
            this.SupChk.AutoSize = true;
            this.SupChk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupChk.Location = new System.Drawing.Point(30, 283);
            this.SupChk.Name = "SupChk";
            this.SupChk.Size = new System.Drawing.Size(77, 20);
            this.SupChk.TabIndex = 48;
            this.SupChk.Text = "Supplier";
            this.SupChk.UseVisualStyleBackColor = true;
            // 
            // WeightVolumeChk
            // 
            this.WeightVolumeChk.AutoSize = true;
            this.WeightVolumeChk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightVolumeChk.Location = new System.Drawing.Point(30, 255);
            this.WeightVolumeChk.Name = "WeightVolumeChk";
            this.WeightVolumeChk.Size = new System.Drawing.Size(125, 20);
            this.WeightVolumeChk.TabIndex = 47;
            this.WeightVolumeChk.Text = "Weight / Volume";
            this.WeightVolumeChk.UseVisualStyleBackColor = true;
            // 
            // ImportBtn
            // 
            this.ImportBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ImportBtn.BackgroundImage")));
            this.ImportBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImportBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImportBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.ImportBtn.Location = new System.Drawing.Point(73, 291);
            this.ImportBtn.Name = "ImportBtn";
            this.ImportBtn.Size = new System.Drawing.Size(140, 30);
            this.ImportBtn.TabIndex = 48;
            this.ImportBtn.Text = "Import";
            this.ImportBtn.UseVisualStyleBackColor = true;
            // 
            // PathChk
            // 
            this.PathChk.AutoSize = true;
            this.PathChk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PathChk.Location = new System.Drawing.Point(32, 257);
            this.PathChk.Name = "PathChk";
            this.PathChk.Size = new System.Drawing.Size(51, 19);
            this.PathChk.TabIndex = 47;
            this.PathChk.Text = "Path";
            this.PathChk.UseVisualStyleBackColor = true;
            // 
            // PathTxt
            // 
            this.PathTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PathTxt.Location = new System.Drawing.Point(89, 255);
            this.PathTxt.Name = "PathTxt";
            this.PathTxt.Size = new System.Drawing.Size(165, 22);
            this.PathTxt.TabIndex = 46;
            // 
            // StockEditFrm
            // 
            this.AcceptButton = this.SearchBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(696, 604);
            this.Controls.Add(this.MfdTxt);
            this.Controls.Add(this.ExpTxt);
            this.Controls.Add(this.SoldTxt);
            this.Controls.Add(this.QtyTxt);
            this.Controls.Add(this.SoldChk);
            this.Controls.Add(this.QtyChk);
            this.Controls.Add(this.ExpChk);
            this.Controls.Add(this.ManuChk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.SearchCom);
            this.Controls.Add(this.SearchTxt);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.UnselectBtn);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.SelectBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StockEditFrm";
            this.Text = "Stock Edit Interface";
            this.Load += new System.EventHandler(this.StockEditFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ItemPictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox NameChk;
        private System.Windows.Forms.CheckBox ManuChk;
        private System.Windows.Forms.CheckBox ExpChk;
        private System.Windows.Forms.CheckBox QtyChk;
        private System.Windows.Forms.CheckBox SoldChk;
        private System.Windows.Forms.TextBox QtyTxt;
        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.TextBox SoldTxt;
        private System.Windows.Forms.TextBox ExpTxt;
        private System.Windows.Forms.TextBox MfdTxt;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button SelectBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button UnselectBtn;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.TextBox SearchTxt;
        private System.Windows.Forms.ComboBox SearchCom;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ItemPictureBox;
        private System.Windows.Forms.CheckBox DescChk;
        private System.Windows.Forms.TextBox DescTxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox NewRefIDTxt;
        private System.Windows.Forms.CheckBox NewRefIDChk;
        private System.Windows.Forms.Button ImportBtn;
        private System.Windows.Forms.CheckBox PathChk;
        private System.Windows.Forms.TextBox PathTxt;
        private System.Windows.Forms.CheckBox PrizeChk;
        private System.Windows.Forms.TextBox PrizeTxt;
        private System.Windows.Forms.TextBox RefIDTxt;
        private System.Windows.Forms.TextBox WeightVolumeTxt;
        private System.Windows.Forms.TextBox SupTxt;
        private System.Windows.Forms.CheckBox RefidChk;
        private System.Windows.Forms.CheckBox SupChk;
        private System.Windows.Forms.CheckBox WeightVolumeChk;
    }
}

