namespace TollboothClient
{
    partial class SetHostForm
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
            this.lblHostName = new System.Windows.Forms.Label();
            this.txtHostName = new System.Windows.Forms.TextBox();
            this.btnSetHost = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHostName
            // 
            this.lblHostName.AutoSize = true;
            this.lblHostName.Location = new System.Drawing.Point(13, 23);
            this.lblHostName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHostName.Name = "lblHostName";
            this.lblHostName.Size = new System.Drawing.Size(89, 20);
            this.lblHostName.TabIndex = 2;
            this.lblHostName.Text = "&Host Name";
            // 
            // txtHostName
            // 
            this.txtHostName.Location = new System.Drawing.Point(136, 19);
            this.txtHostName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHostName.Name = "txtHostName";
            this.txtHostName.Size = new System.Drawing.Size(248, 26);
            this.txtHostName.TabIndex = 3;
            this.txtHostName.Text = "localhost";
            this.txtHostName.TextChanged += new System.EventHandler(this.txtHostName_TextChanged);
            // 
            // btnSetHost
            // 
            this.btnSetHost.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSetHost.Location = new System.Drawing.Point(17, 65);
            this.btnSetHost.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSetHost.Name = "btnSetHost";
            this.btnSetHost.Size = new System.Drawing.Size(112, 35);
            this.btnSetHost.TabIndex = 4;
            this.btnSetHost.Text = "Set Host";
            this.btnSetHost.UseVisualStyleBackColor = true;
            this.btnSetHost.Click += new System.EventHandler(this.btnSetHost_Click);
            // 
            // SetHostForm
            // 
            this.AcceptButton = this.btnSetHost;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 119);
            this.Controls.Add(this.btnSetHost);
            this.Controls.Add(this.txtHostName);
            this.Controls.Add(this.lblHostName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "SetHostForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHostName;
        private System.Windows.Forms.TextBox txtHostName;
        private System.Windows.Forms.Button btnSetHost;
    }
}

