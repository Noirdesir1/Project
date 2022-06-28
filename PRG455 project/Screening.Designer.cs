
namespace PRG455_project
{
    partial class Screening
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
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label travelledLabel;
            System.Windows.Forms.Label symptomsLabel;
            System.Windows.Forms.Label closeContactLabel;
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.screeningBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userAndScreeningDataSet = new PRG455_project.UserAndScreeningDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.closeContactComboBox = new System.Windows.Forms.ComboBox();
            this.travelledComboBox = new System.Windows.Forms.ComboBox();
            this.symptomsComboBox = new System.Windows.Forms.ComboBox();
            this.screeningTableAdapter = new PRG455_project.UserAndScreeningDataSetTableAdapters.ScreeningTableAdapter();
            this.tableAdapterManager = new PRG455_project.UserAndScreeningDataSetTableAdapters.TableAdapterManager();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userTableAdapter = new PRG455_project.UserAndScreeningDataSetTableAdapters.UserTableAdapter();
            dateLabel = new System.Windows.Forms.Label();
            travelledLabel = new System.Windows.Forms.Label();
            symptomsLabel = new System.Windows.Forms.Label();
            closeContactLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.screeningBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userAndScreeningDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dateLabel.Location = new System.Drawing.Point(26, 278);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(40, 18);
            dateLabel.TabIndex = 8;
            dateLabel.Text = "Date:";
            // 
            // travelledLabel
            // 
            travelledLabel.AutoSize = true;
            travelledLabel.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            travelledLabel.Location = new System.Drawing.Point(26, 159);
            travelledLabel.Name = "travelledLabel";
            travelledLabel.Size = new System.Drawing.Size(68, 18);
            travelledLabel.TabIndex = 17;
            travelledLabel.Text = "Travelled:";
            // 
            // symptomsLabel
            // 
            symptomsLabel.AutoSize = true;
            symptomsLabel.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            symptomsLabel.Location = new System.Drawing.Point(26, 228);
            symptomsLabel.Name = "symptomsLabel";
            symptomsLabel.Size = new System.Drawing.Size(74, 18);
            symptomsLabel.TabIndex = 18;
            symptomsLabel.Text = "Symptoms:";
            // 
            // closeContactLabel
            // 
            closeContactLabel.AutoSize = true;
            closeContactLabel.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            closeContactLabel.Location = new System.Drawing.Point(26, 100);
            closeContactLabel.Name = "closeContactLabel";
            closeContactLabel.Size = new System.Drawing.Size(93, 18);
            closeContactLabel.TabIndex = 16;
            closeContactLabel.Text = "Close Contact:";
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.screeningBindingSource, "Date", true));
            this.dateDateTimePicker.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDateTimePicker.Location = new System.Drawing.Point(132, 274);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(147, 23);
            this.dateDateTimePicker.TabIndex = 9;
            // 
            // screeningBindingSource
            // 
            this.screeningBindingSource.DataMember = "Screening";
            this.screeningBindingSource.DataSource = this.userAndScreeningDataSet;
            // 
            // userAndScreeningDataSet
            // 
            this.userAndScreeningDataSet.DataSetName = "UserAndScreeningDataSet";
            this.userAndScreeningDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("STHupo", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(112, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Self Screening";
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("STHupo", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonClose.ForeColor = System.Drawing.Color.Red;
            this.buttonClose.Location = new System.Drawing.Point(307, 319);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(64, 58);
            this.buttonClose.TabIndex = 11;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("STHupo", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonSave.Location = new System.Drawing.Point(28, 321);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(66, 58);
            this.buttonSave.TabIndex = 13;
            this.buttonSave.Text = "Submit";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(366, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Have you ever been in close contact with a COVID-19 patient?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(279, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "Have you travelled abroad in the past 14 days?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(253, 18);
            this.label4.TabIndex = 16;
            this.label4.Text = "Do you have COVID-19 related symptoms?";
            // 
            // closeContactComboBox
            // 
            this.closeContactComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.screeningBindingSource, "CloseContact", true));
            this.closeContactComboBox.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeContactComboBox.FormattingEnabled = true;
            this.closeContactComboBox.Items.AddRange(new object[] {
            "True",
            "False"});
            this.closeContactComboBox.Location = new System.Drawing.Point(132, 97);
            this.closeContactComboBox.Name = "closeContactComboBox";
            this.closeContactComboBox.Size = new System.Drawing.Size(121, 26);
            this.closeContactComboBox.TabIndex = 17;
            // 
            // travelledComboBox
            // 
            this.travelledComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.screeningBindingSource, "Travelled", true));
            this.travelledComboBox.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.travelledComboBox.FormattingEnabled = true;
            this.travelledComboBox.Items.AddRange(new object[] {
            "True",
            "False"});
            this.travelledComboBox.Location = new System.Drawing.Point(132, 156);
            this.travelledComboBox.Name = "travelledComboBox";
            this.travelledComboBox.Size = new System.Drawing.Size(121, 26);
            this.travelledComboBox.TabIndex = 18;
            // 
            // symptomsComboBox
            // 
            this.symptomsComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.screeningBindingSource, "Symptoms", true));
            this.symptomsComboBox.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.symptomsComboBox.FormattingEnabled = true;
            this.symptomsComboBox.Items.AddRange(new object[] {
            "True",
            "False"});
            this.symptomsComboBox.Location = new System.Drawing.Point(132, 225);
            this.symptomsComboBox.Name = "symptomsComboBox";
            this.symptomsComboBox.Size = new System.Drawing.Size(121, 26);
            this.symptomsComboBox.TabIndex = 19;
            // 
            // screeningTableAdapter
            // 
            this.screeningTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ScreeningTableAdapter = this.screeningTableAdapter;
            this.tableAdapterManager.UpdateOrder = PRG455_project.UserAndScreeningDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "User";
            this.userBindingSource.DataSource = this.userAndScreeningDataSet;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // Screening
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 389);
            this.Controls.Add(symptomsLabel);
            this.Controls.Add(this.symptomsComboBox);
            this.Controls.Add(travelledLabel);
            this.Controls.Add(this.travelledComboBox);
            this.Controls.Add(closeContactLabel);
            this.Controls.Add(this.closeContactComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.dateDateTimePicker);
            this.Name = "Screening";
            this.Text = "Screening";
            this.Load += new System.EventHandler(this.Screening_Load);
            ((System.ComponentModel.ISupportInitialize)(this.screeningBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userAndScreeningDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserAndScreeningDataSet userAndScreeningDataSet;
        private System.Windows.Forms.BindingSource screeningBindingSource;
        private UserAndScreeningDataSetTableAdapters.ScreeningTableAdapter screeningTableAdapter;
        private UserAndScreeningDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox closeContactComboBox;
        private System.Windows.Forms.ComboBox travelledComboBox;
        private System.Windows.Forms.ComboBox symptomsComboBox;
        private System.Windows.Forms.BindingSource userBindingSource;
        private UserAndScreeningDataSetTableAdapters.UserTableAdapter userTableAdapter;
    }
}