namespace SalesWindow.UserControls
{
    partial class CreateUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel = new System.Windows.Forms.Panel();
            this.Savebtn = new Guna.UI2.WinForms.Guna2Button();
            this.Nametxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.Quantitytxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.ProductMadetxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.Valumetxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.CategoryCombo = new System.Windows.Forms.ComboBox();
            this.Pricetxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 538);
            this.panel1.TabIndex = 0;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.Pricetxt);
            this.panel.Controls.Add(this.CategoryCombo);
            this.panel.Controls.Add(this.ProductMadetxt);
            this.panel.Controls.Add(this.Valumetxt);
            this.panel.Controls.Add(this.Quantitytxt);
            this.panel.Controls.Add(this.Savebtn);
            this.panel.Controls.Add(this.Nametxt);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(560, 538);
            this.panel.TabIndex = 1;
            // 
            // Savebtn
            // 
            this.Savebtn.BorderRadius = 10;
            this.Savebtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Savebtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Savebtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Savebtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Savebtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Savebtn.ForeColor = System.Drawing.Color.White;
            this.Savebtn.Location = new System.Drawing.Point(214, 436);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(143, 40);
            this.Savebtn.TabIndex = 5;
            this.Savebtn.Text = "Save";
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // Nametxt
            // 
            this.Nametxt.BorderRadius = 10;
            this.Nametxt.BorderThickness = 0;
            this.Nametxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Nametxt.DefaultText = "";
            this.Nametxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Nametxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Nametxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Nametxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Nametxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Nametxt.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.Nametxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Nametxt.Location = new System.Drawing.Point(168, 63);
            this.Nametxt.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Nametxt.Name = "Nametxt";
            this.Nametxt.PasswordChar = '\0';
            this.Nametxt.PlaceholderText = "Name..";
            this.Nametxt.SelectedText = "";
            this.Nametxt.Size = new System.Drawing.Size(224, 39);
            this.Nametxt.TabIndex = 4;
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
            this.Quantitytxt.Location = new System.Drawing.Point(168, 185);
            this.Quantitytxt.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Quantitytxt.Name = "Quantitytxt";
            this.Quantitytxt.PasswordChar = '\0';
            this.Quantitytxt.PlaceholderText = "Quantity...";
            this.Quantitytxt.SelectedText = "";
            this.Quantitytxt.Size = new System.Drawing.Size(224, 39);
            this.Quantitytxt.TabIndex = 6;
            // 
            // ProductMadetxt
            // 
            this.ProductMadetxt.BorderRadius = 10;
            this.ProductMadetxt.BorderThickness = 0;
            this.ProductMadetxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProductMadetxt.DefaultText = "";
            this.ProductMadetxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ProductMadetxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ProductMadetxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProductMadetxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProductMadetxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProductMadetxt.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.ProductMadetxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProductMadetxt.Location = new System.Drawing.Point(168, 308);
            this.ProductMadetxt.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ProductMadetxt.Name = "ProductMadetxt";
            this.ProductMadetxt.PasswordChar = '\0';
            this.ProductMadetxt.PlaceholderText = "Made...";
            this.ProductMadetxt.SelectedText = "";
            this.ProductMadetxt.Size = new System.Drawing.Size(224, 39);
            this.ProductMadetxt.TabIndex = 8;
            // 
            // Valumetxt
            // 
            this.Valumetxt.BorderRadius = 10;
            this.Valumetxt.BorderThickness = 0;
            this.Valumetxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Valumetxt.DefaultText = "";
            this.Valumetxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Valumetxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Valumetxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Valumetxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Valumetxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Valumetxt.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.Valumetxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Valumetxt.Location = new System.Drawing.Point(168, 245);
            this.Valumetxt.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Valumetxt.Name = "Valumetxt";
            this.Valumetxt.PasswordChar = '\0';
            this.Valumetxt.PlaceholderText = "Valume...";
            this.Valumetxt.SelectedText = "";
            this.Valumetxt.Size = new System.Drawing.Size(224, 39);
            this.Valumetxt.TabIndex = 7;
            // 
            // CategoryCombo
            // 
            this.CategoryCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CategoryCombo.FormattingEnabled = true;
            this.CategoryCombo.Items.AddRange(new object[] {
            "Gazli",
            "Mineral",
            "Tabiiy"});
            this.CategoryCombo.Location = new System.Drawing.Point(168, 372);
            this.CategoryCombo.Name = "CategoryCombo";
            this.CategoryCombo.Size = new System.Drawing.Size(224, 32);
            this.CategoryCombo.TabIndex = 9;
            // 
            // Pricetxt
            // 
            this.Pricetxt.BorderRadius = 10;
            this.Pricetxt.BorderThickness = 0;
            this.Pricetxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Pricetxt.DefaultText = "";
            this.Pricetxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Pricetxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Pricetxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Pricetxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Pricetxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Pricetxt.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.Pricetxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Pricetxt.Location = new System.Drawing.Point(168, 124);
            this.Pricetxt.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Pricetxt.Name = "Pricetxt";
            this.Pricetxt.PasswordChar = '\0';
            this.Pricetxt.PlaceholderText = "Price...";
            this.Pricetxt.SelectedText = "";
            this.Pricetxt.Size = new System.Drawing.Size(224, 39);
            this.Pricetxt.TabIndex = 10;
            // 
            // CreateUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Name = "CreateUserControl";
            this.Size = new System.Drawing.Size(560, 538);
            this.panel1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel;
        private Guna.UI2.WinForms.Guna2Button Savebtn;
        private Guna.UI2.WinForms.Guna2TextBox Nametxt;
        private Guna.UI2.WinForms.Guna2TextBox ProductMadetxt;
        private Guna.UI2.WinForms.Guna2TextBox Valumetxt;
        private Guna.UI2.WinForms.Guna2TextBox Quantitytxt;
        private System.Windows.Forms.ComboBox CategoryCombo;
        private Guna.UI2.WinForms.Guna2TextBox Pricetxt;
    }
}
