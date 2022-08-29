namespace ShadowApplication
{
    partial class ShadowForm
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
            this.SuspendLayout();
            // 
            // ShadowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ShadowForm";
            this.Text = "Shadow Application";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ShadowForm_FormClosing);
            this.Load += new System.EventHandler(this.ShadowForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ShadowForm_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ShadowForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ShadowForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ShadowForm_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion
    }
}

