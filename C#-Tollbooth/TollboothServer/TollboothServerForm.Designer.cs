namespace TollboothServer
{
    partial class TollboothServerForm
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
            this.lstTollbooths = new System.Windows.Forms.ListBox();
            this.lblTollbooths = new System.Windows.Forms.Label();
            this.lblNumTollbooths = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstTollbooths
            // 
            this.lstTollbooths.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstTollbooths.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTollbooths.FormattingEnabled = true;
            this.lstTollbooths.ItemHeight = 27;
            this.lstTollbooths.Location = new System.Drawing.Point(16, 35);
            this.lstTollbooths.Name = "lstTollbooths";
            this.lstTollbooths.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstTollbooths.Size = new System.Drawing.Size(534, 517);
            this.lstTollbooths.TabIndex = 0;
            // 
            // lblTollbooths
            // 
            this.lblTollbooths.AutoSize = true;
            this.lblTollbooths.Location = new System.Drawing.Point(16, 12);
            this.lblTollbooths.Name = "lblTollbooths";
            this.lblTollbooths.Size = new System.Drawing.Size(82, 20);
            this.lblTollbooths.TabIndex = 1;
            this.lblTollbooths.Text = "&Tollbooths";
            // 
            // lblNumTollbooths
            // 
            this.lblNumTollbooths.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNumTollbooths.AutoSize = true;
            this.lblNumTollbooths.Location = new System.Drawing.Point(36, 694);
            this.lblNumTollbooths.Name = "lblNumTollbooths";
            this.lblNumTollbooths.Size = new System.Drawing.Size(246, 20);
            this.lblNumTollbooths.TabIndex = 2;
            this.lblNumTollbooths.Text = "There are 0 tollbooths connected.";
            // 
            // TollboothServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 583);
            this.Controls.Add(this.lblNumTollbooths);
            this.Controls.Add(this.lblTollbooths);
            this.Controls.Add(this.lstTollbooths);
            this.Name = "TollboothServerForm";
            this.Text = "Tollbooth Server";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TollboothServerForm_FormClosed);
            this.Load += new System.EventHandler(this.TollboothServerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lstTollbooths;
        private System.Windows.Forms.Label lblTollbooths;
        private System.Windows.Forms.Label lblNumTollbooths;
    }
}

