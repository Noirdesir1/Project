namespace TollboothClient
{
    partial class TollboothClientForm
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
            this.btnClose = new System.Windows.Forms.Button();
            this.lblCash = new System.Windows.Forms.Label();
            this.lblCars = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnNonPayingCar = new System.Windows.Forms.Button();
            this.btnPayingCar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(17, 112);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(192, 35);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "&Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblCash
            // 
            this.lblCash.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCash.Location = new System.Drawing.Point(217, 112);
            this.lblCash.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCash.Name = "lblCash";
            this.lblCash.Size = new System.Drawing.Size(192, 35);
            this.lblCash.TabIndex = 12;
            this.lblCash.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCars
            // 
            this.lblCars.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCars.Location = new System.Drawing.Point(217, 63);
            this.lblCars.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCars.Name = "lblCars";
            this.lblCars.Size = new System.Drawing.Size(192, 35);
            this.lblCars.TabIndex = 10;
            this.lblCars.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(13, 63);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(192, 35);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "&Reset";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnNonPayingCar
            // 
            this.btnNonPayingCar.Location = new System.Drawing.Point(217, 14);
            this.btnNonPayingCar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNonPayingCar.Name = "btnNonPayingCar";
            this.btnNonPayingCar.Size = new System.Drawing.Size(192, 35);
            this.btnNonPayingCar.TabIndex = 8;
            this.btnNonPayingCar.Text = "&Non-Paying Car";
            this.btnNonPayingCar.Click += new System.EventHandler(this.btnNonPayingCar_Click);
            // 
            // btnPayingCar
            // 
            this.btnPayingCar.Location = new System.Drawing.Point(13, 14);
            this.btnPayingCar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPayingCar.Name = "btnPayingCar";
            this.btnPayingCar.Size = new System.Drawing.Size(192, 35);
            this.btnPayingCar.TabIndex = 7;
            this.btnPayingCar.Text = "&Paying Car";
            this.btnPayingCar.Click += new System.EventHandler(this.btnPayingCar_Click);
            // 
            // TollboothClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 164);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblCash);
            this.Controls.Add(this.lblCars);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnNonPayingCar);
            this.Controls.Add(this.btnPayingCar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "TollboothClientForm";
            this.Text = "Tollbooth";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TollboothClientForm_FormClosed);
            this.Load += new System.EventHandler(this.TollboothClientForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btnClose;
        internal System.Windows.Forms.Label lblCash;
        internal System.Windows.Forms.Label lblCars;
        internal System.Windows.Forms.Button btnReset;
        internal System.Windows.Forms.Button btnNonPayingCar;
        internal System.Windows.Forms.Button btnPayingCar;
    }
}

