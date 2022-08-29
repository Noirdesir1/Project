
namespace ShopClient
{
    partial class FormLogin
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
            this.labelhostname = new System.Windows.Forms.Label();
            this.labelaccountno = new System.Windows.Forms.Label();
            this.textBoxhostname = new System.Windows.Forms.TextBox();
            this.textBoxaccountno = new System.Windows.Forms.TextBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelhostname
            // 
            this.labelhostname.AutoSize = true;
            this.labelhostname.Location = new System.Drawing.Point(12, 35);
            this.labelhostname.Name = "labelhostname";
            this.labelhostname.Size = new System.Drawing.Size(59, 12);
            this.labelhostname.TabIndex = 0;
            this.labelhostname.Text = "Host Name";
            // 
            // labelaccountno
            // 
            this.labelaccountno.AutoSize = true;
            this.labelaccountno.Location = new System.Drawing.Point(12, 69);
            this.labelaccountno.Name = "labelaccountno";
            this.labelaccountno.Size = new System.Drawing.Size(71, 12);
            this.labelaccountno.TabIndex = 1;
            this.labelaccountno.Text = "Account No.";
            // 
            // textBoxhostname
            // 
            this.textBoxhostname.Location = new System.Drawing.Point(95, 35);
            this.textBoxhostname.Name = "textBoxhostname";
            this.textBoxhostname.Size = new System.Drawing.Size(152, 21);
            this.textBoxhostname.TabIndex = 2;
            this.textBoxhostname.TextChanged += new System.EventHandler(this.textBoxhostname_TextChanged);
            // 
            // textBoxaccountno
            // 
            this.textBoxaccountno.Location = new System.Drawing.Point(95, 69);
            this.textBoxaccountno.Name = "textBoxaccountno";
            this.textBoxaccountno.Size = new System.Drawing.Size(152, 21);
            this.textBoxaccountno.TabIndex = 3;
            this.textBoxaccountno.TextChanged += new System.EventHandler(this.textBoxaccountno_TextChanged);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(172, 100);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(75, 23);
            this.buttonConnect.TabIndex = 4;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 135);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.textBoxaccountno);
            this.Controls.Add(this.textBoxhostname);
            this.Controls.Add(this.labelaccountno);
            this.Controls.Add(this.labelhostname);
            this.Name = "FormLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelhostname;
        private System.Windows.Forms.Label labelaccountno;
        private System.Windows.Forms.TextBox textBoxhostname;
        private System.Windows.Forms.TextBox textBoxaccountno;
        private System.Windows.Forms.Button buttonConnect;
    }
}

