namespace SalesWindow.UserControls
{
    partial class DeleteUserControl
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
            this.Purchasebtn = new Guna.UI2.WinForms.Guna2Button();
            this.ProductIdtxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
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
            this.Purchasebtn.Location = new System.Drawing.Point(186, 287);
            this.Purchasebtn.Name = "Purchasebtn";
            this.Purchasebtn.Size = new System.Drawing.Size(180, 45);
            this.Purchasebtn.TabIndex = 4;
            this.Purchasebtn.Text = "Delete";
            this.Purchasebtn.Click += new System.EventHandler(this.Purchasebtn_Click);
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
            this.ProductIdtxt.Location = new System.Drawing.Point(168, 207);
            this.ProductIdtxt.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ProductIdtxt.Name = "ProductIdtxt";
            this.ProductIdtxt.PasswordChar = '\0';
            this.ProductIdtxt.PlaceholderText = "Product Id...";
            this.ProductIdtxt.SelectedText = "";
            this.ProductIdtxt.Size = new System.Drawing.Size(224, 39);
            this.ProductIdtxt.TabIndex = 3;
            // 
            // DeleteUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Purchasebtn);
            this.Controls.Add(this.ProductIdtxt);
            this.Name = "DeleteUserControl";
            this.Size = new System.Drawing.Size(560, 538);
            this.Load += new System.EventHandler(this.DeleteUserControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button Purchasebtn;
        private Guna.UI2.WinForms.Guna2TextBox ProductIdtxt;
    }
}
