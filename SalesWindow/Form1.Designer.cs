﻿namespace SalesWindow
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Clearbtn = new Guna.UI2.WinForms.Guna2Button();
            this.Databtn = new Guna.UI2.WinForms.Guna2Button();
            this.Createbtn = new Guna.UI2.WinForms.Guna2Button();
            this.Deletebtn = new Guna.UI2.WinForms.Guna2Button();
            this.Cancelbtn = new Guna.UI2.WinForms.Guna2Button();
            this.Purchasebtn = new Guna.UI2.WinForms.Guna2Button();
            this.Quantitytxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.ProductIdtxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Searchtxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.CategoryCombo = new System.Windows.Forms.ComboBox();
            this.productLBL = new System.Windows.Forms.Label();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Closebtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel5.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.TopPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 600);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 538);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.Clearbtn);
            this.panel4.Controls.Add(this.Databtn);
            this.panel4.Controls.Add(this.Createbtn);
            this.panel4.Controls.Add(this.Deletebtn);
            this.panel4.Controls.Add(this.Cancelbtn);
            this.panel4.Controls.Add(this.Purchasebtn);
            this.panel4.Controls.Add(this.Quantitytxt);
            this.panel4.Controls.Add(this.ProductIdtxt);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(560, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(240, 538);
            this.panel4.TabIndex = 1;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // Clearbtn
            // 
            this.Clearbtn.BorderRadius = 10;
            this.Clearbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Clearbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Clearbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Clearbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Clearbtn.FillColor = System.Drawing.Color.Lime;
            this.Clearbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clearbtn.ForeColor = System.Drawing.Color.White;
            this.Clearbtn.Location = new System.Drawing.Point(126, 87);
            this.Clearbtn.Name = "Clearbtn";
            this.Clearbtn.Size = new System.Drawing.Size(95, 32);
            this.Clearbtn.TabIndex = 7;
            this.Clearbtn.Text = "Clear";
            this.Clearbtn.Click += new System.EventHandler(this.Clearbtn_Click);
            // 
            // Databtn
            // 
            this.Databtn.BorderRadius = 10;
            this.Databtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Databtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Databtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Databtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Databtn.FillColor = System.Drawing.Color.Cyan;
            this.Databtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Databtn.ForeColor = System.Drawing.Color.White;
            this.Databtn.Location = new System.Drawing.Point(19, 87);
            this.Databtn.Name = "Databtn";
            this.Databtn.Size = new System.Drawing.Size(95, 32);
            this.Databtn.TabIndex = 6;
            this.Databtn.Text = "Data";
            this.Databtn.Click += new System.EventHandler(this.Databtn_Click);
            // 
            // Createbtn
            // 
            this.Createbtn.BorderRadius = 10;
            this.Createbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Createbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Createbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Createbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Createbtn.FillColor = System.Drawing.Color.Lime;
            this.Createbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Createbtn.ForeColor = System.Drawing.Color.White;
            this.Createbtn.Location = new System.Drawing.Point(126, 29);
            this.Createbtn.Name = "Createbtn";
            this.Createbtn.Size = new System.Drawing.Size(95, 32);
            this.Createbtn.TabIndex = 5;
            this.Createbtn.Text = "Create";
            this.Createbtn.Click += new System.EventHandler(this.Createbtn_Click);
            // 
            // Deletebtn
            // 
            this.Deletebtn.BorderRadius = 10;
            this.Deletebtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Deletebtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Deletebtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Deletebtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Deletebtn.FillColor = System.Drawing.Color.Red;
            this.Deletebtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Deletebtn.ForeColor = System.Drawing.Color.White;
            this.Deletebtn.Location = new System.Drawing.Point(19, 29);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(95, 32);
            this.Deletebtn.TabIndex = 4;
            this.Deletebtn.Text = "Delete";
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // Cancelbtn
            // 
            this.Cancelbtn.BackColor = System.Drawing.Color.Transparent;
            this.Cancelbtn.BorderRadius = 10;
            this.Cancelbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Cancelbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Cancelbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Cancelbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Cancelbtn.FillColor = System.Drawing.Color.Red;
            this.Cancelbtn.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.Cancelbtn.ForeColor = System.Drawing.Color.White;
            this.Cancelbtn.Location = new System.Drawing.Point(26, 430);
            this.Cancelbtn.Name = "Cancelbtn";
            this.Cancelbtn.Size = new System.Drawing.Size(180, 45);
            this.Cancelbtn.TabIndex = 3;
            this.Cancelbtn.Text = "Cancel";
            // 
            // Purchasebtn
            // 
            this.Purchasebtn.BorderRadius = 10;
            this.Purchasebtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Purchasebtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Purchasebtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Purchasebtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Purchasebtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Purchasebtn.ForeColor = System.Drawing.Color.White;
            this.Purchasebtn.Location = new System.Drawing.Point(26, 358);
            this.Purchasebtn.Name = "Purchasebtn";
            this.Purchasebtn.Size = new System.Drawing.Size(180, 45);
            this.Purchasebtn.TabIndex = 2;
            this.Purchasebtn.Text = "Purchase";
            this.Purchasebtn.Click += new System.EventHandler(this.Purchasebtn_Click);
            // 
            // Quantitytxt
            // 
            this.Quantitytxt.BorderRadius = 10;
            this.Quantitytxt.BorderThickness = 0;
            this.Quantitytxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Quantitytxt.DefaultText = "";
            this.Quantitytxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Quantitytxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Quantitytxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Quantitytxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Quantitytxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Quantitytxt.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.Quantitytxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Quantitytxt.Location = new System.Drawing.Point(8, 280);
            this.Quantitytxt.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Quantitytxt.Name = "Quantitytxt";
            this.Quantitytxt.PasswordChar = '\0';
            this.Quantitytxt.PlaceholderText = "Quantity...";
            this.Quantitytxt.SelectedText = "";
            this.Quantitytxt.Size = new System.Drawing.Size(224, 39);
            this.Quantitytxt.TabIndex = 1;
            // 
            // ProductIdtxt
            // 
            this.ProductIdtxt.BorderRadius = 10;
            this.ProductIdtxt.BorderThickness = 0;
            this.ProductIdtxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProductIdtxt.DefaultText = "";
            this.ProductIdtxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ProductIdtxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ProductIdtxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProductIdtxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProductIdtxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProductIdtxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductIdtxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProductIdtxt.Location = new System.Drawing.Point(8, 197);
            this.ProductIdtxt.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ProductIdtxt.Name = "ProductIdtxt";
            this.ProductIdtxt.PasswordChar = '\0';
            this.ProductIdtxt.PlaceholderText = "Product Id...";
            this.ProductIdtxt.SelectedText = "";
            this.ProductIdtxt.Size = new System.Drawing.Size(224, 39);
            this.ProductIdtxt.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(560, 538);
            this.panel3.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(560, 451);
            this.dataGridView1.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.Searchtxt);
            this.panel5.Controls.Add(this.CategoryCombo);
            this.panel5.Controls.Add(this.productLBL);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(560, 87);
            this.panel5.TabIndex = 2;
            // 
            // Searchtxt
            // 
            this.Searchtxt.BorderRadius = 10;
            this.Searchtxt.BorderThickness = 0;
            this.Searchtxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Searchtxt.DefaultText = "";
            this.Searchtxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Searchtxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Searchtxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Searchtxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Searchtxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Searchtxt.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.Searchtxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Searchtxt.Location = new System.Drawing.Point(175, 29);
            this.Searchtxt.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Searchtxt.Name = "Searchtxt";
            this.Searchtxt.PasswordChar = '\0';
            this.Searchtxt.PlaceholderText = "Search...";
            this.Searchtxt.SelectedText = "";
            this.Searchtxt.Size = new System.Drawing.Size(182, 33);
            this.Searchtxt.TabIndex = 4;
            this.Searchtxt.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // CategoryCombo
            // 
            this.CategoryCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CategoryCombo.FormattingEnabled = true;
            this.CategoryCombo.Items.AddRange(new object[] {
            "Gazli",
            "Mineral",
            "Tabiiy"});
            this.CategoryCombo.Location = new System.Drawing.Point(390, 29);
            this.CategoryCombo.Name = "CategoryCombo";
            this.CategoryCombo.Size = new System.Drawing.Size(147, 32);
            this.CategoryCombo.TabIndex = 3;
            this.CategoryCombo.SelectedIndexChanged += new System.EventHandler(this.CategoryCombo_SelectedIndexChanged_1);
            // 
            // productLBL
            // 
            this.productLBL.AutoSize = true;
            this.productLBL.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productLBL.Location = new System.Drawing.Point(33, 27);
            this.productLBL.Name = "productLBL";
            this.productLBL.Size = new System.Drawing.Size(100, 30);
            this.productLBL.TabIndex = 2;
            this.productLBL.Text = "Products";
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.label1);
            this.TopPanel.Controls.Add(this.Closebtn);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(800, 62);
            this.TopPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(31, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sales Window";
            // 
            // Closebtn
            // 
            this.Closebtn.BackColor = System.Drawing.Color.Transparent;
            this.Closebtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.Closebtn.FlatAppearance.BorderSize = 0;
            this.Closebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Closebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Closebtn.Location = new System.Drawing.Point(736, 0);
            this.Closebtn.Name = "Closebtn";
            this.Closebtn.Size = new System.Drawing.Size(64, 62);
            this.Closebtn.TabIndex = 0;
            this.Closebtn.Text = "X";
            this.Closebtn.UseVisualStyleBackColor = false;
            this.Closebtn.Click += new System.EventHandler(this.Closebtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashboardWindow";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Button Closebtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2Button Cancelbtn;
        private Guna.UI2.WinForms.Guna2Button Purchasebtn;
        private Guna.UI2.WinForms.Guna2TextBox Quantitytxt;
        private Guna.UI2.WinForms.Guna2TextBox ProductIdtxt;
        private Guna.UI2.WinForms.Guna2Button Deletebtn;
        private Guna.UI2.WinForms.Guna2Button Createbtn;
        private Guna.UI2.WinForms.Guna2Button Clearbtn;
        private Guna.UI2.WinForms.Guna2Button Databtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox CategoryCombo;
        private System.Windows.Forms.Label productLBL;
        private Guna.UI2.WinForms.Guna2TextBox Searchtxt;
    }
}

