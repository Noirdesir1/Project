
namespace ShopClient
{
    partial class ShopClient
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
            this.components = new System.ComponentModel.Container();
            this.comboBoxList = new System.Windows.Forms.ComboBox();
            this.buttonPurchase = new System.Windows.Forms.Button();
            this.timerGetOrder = new System.Windows.Forms.Timer(this.components);
            this.listBoxPurchase = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // comboBoxList
            // 
            this.comboBoxList.FormattingEnabled = true;
            this.comboBoxList.Items.AddRange(new object[] {
            "keyboard",
            "mouse",
            "CPU",
            "memory",
            "headset"});
            this.comboBoxList.Location = new System.Drawing.Point(253, 24);
            this.comboBoxList.Name = "comboBoxList";
            this.comboBoxList.Size = new System.Drawing.Size(149, 20);
            this.comboBoxList.TabIndex = 0;
            this.comboBoxList.SelectedIndexChanged += new System.EventHandler(this.comboBoxList_SelectedIndexChanged);
            // 
            // buttonPurchase
            // 
            this.buttonPurchase.Location = new System.Drawing.Point(312, 218);
            this.buttonPurchase.Name = "buttonPurchase";
            this.buttonPurchase.Size = new System.Drawing.Size(75, 23);
            this.buttonPurchase.TabIndex = 2;
            this.buttonPurchase.Text = "Purchase";
            this.buttonPurchase.UseVisualStyleBackColor = true;
            this.buttonPurchase.Click += new System.EventHandler(this.buttonPurchase_Click);
            // 
            // timerGetOrder
            // 
            this.timerGetOrder.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // listBoxPurchase
            // 
            this.listBoxPurchase.FormattingEnabled = true;
            this.listBoxPurchase.ItemHeight = 12;
            this.listBoxPurchase.Location = new System.Drawing.Point(12, 24);
            this.listBoxPurchase.Name = "listBoxPurchase";
            this.listBoxPurchase.Size = new System.Drawing.Size(221, 208);
            this.listBoxPurchase.TabIndex = 3;
            // 
            // ShopClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 252);
            this.Controls.Add(this.listBoxPurchase);
            this.Controls.Add(this.buttonPurchase);
            this.Controls.Add(this.comboBoxList);
            this.Name = "ShopClient";
            this.Text = "ShopClient";
            this.Load += new System.EventHandler(this.ShopClient_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxList;
        private System.Windows.Forms.Button buttonPurchase;
        private System.Windows.Forms.Timer timerGetOrder;
        private System.Windows.Forms.ListBox listBoxPurchase;
    }
}