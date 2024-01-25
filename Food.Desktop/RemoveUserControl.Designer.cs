namespace Food.Desktop
{
    partial class RemoveUserControl
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
            this.Cancelbtn = new System.Windows.Forms.Button();
            this.Savebtn = new System.Windows.Forms.Button();
            this.ProductIdTxt = new System.Windows.Forms.TextBox();
            this.ProductIdLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Cancelbtn
            // 
            this.Cancelbtn.BackColor = System.Drawing.Color.Red;
            this.Cancelbtn.FlatAppearance.BorderSize = 0;
            this.Cancelbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancelbtn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cancelbtn.Location = new System.Drawing.Point(211, 198);
            this.Cancelbtn.Name = "Cancelbtn";
            this.Cancelbtn.Size = new System.Drawing.Size(104, 47);
            this.Cancelbtn.TabIndex = 13;
            this.Cancelbtn.Text = "Cancel";
            this.Cancelbtn.UseVisualStyleBackColor = false;
            this.Cancelbtn.Click += new System.EventHandler(this.Cancelbtn_Click);
            // 
            // Savebtn
            // 
            this.Savebtn.BackColor = System.Drawing.Color.Yellow;
            this.Savebtn.FlatAppearance.BorderSize = 0;
            this.Savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Savebtn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Savebtn.Location = new System.Drawing.Point(333, 198);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(104, 47);
            this.Savebtn.TabIndex = 12;
            this.Savebtn.Text = "Save";
            this.Savebtn.UseVisualStyleBackColor = false;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // ProductIdTxt
            // 
            this.ProductIdTxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductIdTxt.Location = new System.Drawing.Point(211, 136);
            this.ProductIdTxt.Multiline = true;
            this.ProductIdTxt.Name = "ProductIdTxt";
            this.ProductIdTxt.Size = new System.Drawing.Size(226, 34);
            this.ProductIdTxt.TabIndex = 11;
            // 
            // ProductIdLbl
            // 
            this.ProductIdLbl.AutoSize = true;
            this.ProductIdLbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductIdLbl.Location = new System.Drawing.Point(169, 139);
            this.ProductIdLbl.Name = "ProductIdLbl";
            this.ProductIdLbl.Size = new System.Drawing.Size(28, 25);
            this.ProductIdLbl.TabIndex = 10;
            this.ProductIdLbl.Text = "Id";
            // 
            // RemoveUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Cancelbtn);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.ProductIdTxt);
            this.Controls.Add(this.ProductIdLbl);
            this.Name = "RemoveUserControl";
            this.Size = new System.Drawing.Size(606, 380);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancelbtn;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.TextBox ProductIdTxt;
        private System.Windows.Forms.Label ProductIdLbl;
    }
}
