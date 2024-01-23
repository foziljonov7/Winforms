namespace Food.Desktop
{
    partial class UpdateUserControl
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
            this.GreenPharm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GreenPharm
            // 
            this.GreenPharm.AutoSize = true;
            this.GreenPharm.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GreenPharm.Location = new System.Drawing.Point(170, 172);
            this.GreenPharm.Name = "GreenPharm";
            this.GreenPharm.Size = new System.Drawing.Size(267, 37);
            this.GreenPharm.TabIndex = 5;
            this.GreenPharm.Text = "UpdateUserControl";
            // 
            // UpdateUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.GreenPharm);
            this.Name = "UpdateUserControl";
            this.Size = new System.Drawing.Size(606, 380);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GreenPharm;
    }
}
