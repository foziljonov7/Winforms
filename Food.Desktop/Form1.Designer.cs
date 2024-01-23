namespace Food.Desktop
{
    partial class Dashboard
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
            this.UserControlPanel = new System.Windows.Forms.Panel();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.GreenPharm = new System.Windows.Forms.Label();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.Closebtn = new System.Windows.Forms.Button();
            this.Updatebtn = new System.Windows.Forms.Button();
            this.Removebtn = new System.Windows.Forms.Button();
            this.Createbtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.MenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.UserControlPanel);
            this.panel1.Controls.Add(this.TopPanel);
            this.panel1.Controls.Add(this.MenuPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 461);
            this.panel1.TabIndex = 0;
            // 
            // UserControlPanel
            // 
            this.UserControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserControlPanel.Location = new System.Drawing.Point(178, 81);
            this.UserControlPanel.Name = "UserControlPanel";
            this.UserControlPanel.Size = new System.Drawing.Size(606, 380);
            this.UserControlPanel.TabIndex = 2;
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.GreenPharm);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(178, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(606, 81);
            this.TopPanel.TabIndex = 1;
            // 
            // GreenPharm
            // 
            this.GreenPharm.AutoSize = true;
            this.GreenPharm.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GreenPharm.Location = new System.Drawing.Point(27, 22);
            this.GreenPharm.Name = "GreenPharm";
            this.GreenPharm.Size = new System.Drawing.Size(184, 37);
            this.GreenPharm.TabIndex = 4;
            this.GreenPharm.Text = "Green Pharm";
            // 
            // MenuPanel
            // 
            this.MenuPanel.Controls.Add(this.Closebtn);
            this.MenuPanel.Controls.Add(this.Updatebtn);
            this.MenuPanel.Controls.Add(this.Removebtn);
            this.MenuPanel.Controls.Add(this.Createbtn);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(178, 461);
            this.MenuPanel.TabIndex = 0;
            // 
            // Closebtn
            // 
            this.Closebtn.FlatAppearance.BorderSize = 0;
            this.Closebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Closebtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Closebtn.Location = new System.Drawing.Point(0, 329);
            this.Closebtn.Name = "Closebtn";
            this.Closebtn.Size = new System.Drawing.Size(178, 55);
            this.Closebtn.TabIndex = 3;
            this.Closebtn.Text = "Close";
            this.Closebtn.UseVisualStyleBackColor = true;
            this.Closebtn.Click += new System.EventHandler(this.Closebtn_Click);
            // 
            // Updatebtn
            // 
            this.Updatebtn.FlatAppearance.BorderSize = 0;
            this.Updatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Updatebtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Updatebtn.Location = new System.Drawing.Point(0, 243);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(178, 55);
            this.Updatebtn.TabIndex = 2;
            this.Updatebtn.Text = "Update";
            this.Updatebtn.UseVisualStyleBackColor = true;
            this.Updatebtn.Click += new System.EventHandler(this.Updatebtn_Click);
            // 
            // Removebtn
            // 
            this.Removebtn.FlatAppearance.BorderSize = 0;
            this.Removebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Removebtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Removebtn.Location = new System.Drawing.Point(0, 158);
            this.Removebtn.Name = "Removebtn";
            this.Removebtn.Size = new System.Drawing.Size(178, 55);
            this.Removebtn.TabIndex = 1;
            this.Removebtn.Text = "Remove";
            this.Removebtn.UseVisualStyleBackColor = true;
            this.Removebtn.Click += new System.EventHandler(this.Removebtn_Click);
            // 
            // Createbtn
            // 
            this.Createbtn.FlatAppearance.BorderSize = 0;
            this.Createbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Createbtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Createbtn.Location = new System.Drawing.Point(0, 76);
            this.Createbtn.Name = "Createbtn";
            this.Createbtn.Size = new System.Drawing.Size(178, 55);
            this.Createbtn.TabIndex = 0;
            this.Createbtn.Text = "Add";
            this.Createbtn.UseVisualStyleBackColor = true;
            this.Createbtn.Click += new System.EventHandler(this.Createbtn_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pharmacy";
            this.panel1.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.MenuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Button Createbtn;
        private System.Windows.Forms.Label GreenPharm;
        private System.Windows.Forms.Button Closebtn;
        private System.Windows.Forms.Button Updatebtn;
        private System.Windows.Forms.Button Removebtn;
        private System.Windows.Forms.Panel UserControlPanel;
        private System.Windows.Forms.Panel TopPanel;
    }
}

