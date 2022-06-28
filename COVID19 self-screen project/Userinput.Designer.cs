
namespace PRG455_project
{
    partial class Userinput
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
            System.Windows.Forms.Label userIdLabel;
            System.Windows.Forms.Label userNameLabel;
            System.Windows.Forms.Label userTypeLabel;
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userAndScreeningDataSet = new PRG455_project.UserAndScreeningDataSet();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonscreening = new System.Windows.Forms.Button();
            this.userIdTextBox = new System.Windows.Forms.TextBox();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.userTypeComboBox = new System.Windows.Forms.ComboBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonSearchScreening = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.userTableAdapter = new PRG455_project.UserAndScreeningDataSetTableAdapters.UserTableAdapter();
            this.tableAdapterManager = new PRG455_project.UserAndScreeningDataSetTableAdapters.TableAdapterManager();
            this.Adminbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            userIdLabel = new System.Windows.Forms.Label();
            userNameLabel = new System.Windows.Forms.Label();
            userTypeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userAndScreeningDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // userIdLabel
            // 
            userIdLabel.AutoSize = true;
            userIdLabel.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            userIdLabel.Location = new System.Drawing.Point(21, 66);
            userIdLabel.Name = "userIdLabel";
            userIdLabel.Size = new System.Drawing.Size(61, 16);
            userIdLabel.TabIndex = 11;
            userIdLabel.Text = "User Id:";
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            userNameLabel.Location = new System.Drawing.Point(21, 93);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new System.Drawing.Size(83, 16);
            userNameLabel.TabIndex = 13;
            userNameLabel.Text = "User Name:";
            // 
            // userTypeLabel
            // 
            userTypeLabel.AutoSize = true;
            userTypeLabel.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            userTypeLabel.Location = new System.Drawing.Point(21, 120);
            userTypeLabel.Name = "userTypeLabel";
            userTypeLabel.Size = new System.Drawing.Size(80, 16);
            userTypeLabel.TabIndex = 15;
            userTypeLabel.Text = "User Type:";
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "User";
            this.userBindingSource.DataSource = this.userAndScreeningDataSet;
            // 
            // userAndScreeningDataSet
            // 
            this.userAndScreeningDataSet.DataSetName = "UserAndScreeningDataSet";
            this.userAndScreeningDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("Snap ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.Color.Red;
            this.buttonClose.Location = new System.Drawing.Point(23, 250);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 61);
            this.buttonClose.TabIndex = 10;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonscreening
            // 
            this.buttonscreening.Font = new System.Drawing.Font("Snap ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonscreening.ForeColor = System.Drawing.Color.Navy;
            this.buttonscreening.Location = new System.Drawing.Point(197, 201);
            this.buttonscreening.Name = "buttonscreening";
            this.buttonscreening.Size = new System.Drawing.Size(189, 34);
            this.buttonscreening.TabIndex = 11;
            this.buttonscreening.Text = "Start Screening";
            this.buttonscreening.UseVisualStyleBackColor = true;
            this.buttonscreening.Click += new System.EventHandler(this.buttonscreening_Click);
            // 
            // userIdTextBox
            // 
            this.userIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "UserId", true));
            this.userIdTextBox.Location = new System.Drawing.Point(110, 63);
            this.userIdTextBox.Name = "userIdTextBox";
            this.userIdTextBox.Size = new System.Drawing.Size(121, 21);
            this.userIdTextBox.TabIndex = 12;
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "UserName", true));
            this.userNameTextBox.Location = new System.Drawing.Point(110, 90);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(121, 21);
            this.userNameTextBox.TabIndex = 14;
            // 
            // userTypeComboBox
            // 
            this.userTypeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "UserType", true));
            this.userTypeComboBox.FormattingEnabled = true;
            this.userTypeComboBox.Items.AddRange(new object[] {
            "Student",
            "Employee"});
            this.userTypeComboBox.Location = new System.Drawing.Point(110, 117);
            this.userTypeComboBox.Name = "userTypeComboBox";
            this.userTypeComboBox.Size = new System.Drawing.Size(121, 20);
            this.userTypeComboBox.TabIndex = 16;
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Snap ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(23, 143);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(78, 23);
            this.buttonSave.TabIndex = 22;
            this.buttonSave.Text = "Submit";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonSearchScreening
            // 
            this.buttonSearchScreening.Font = new System.Drawing.Font("Snap ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearchScreening.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSearchScreening.Location = new System.Drawing.Point(197, 263);
            this.buttonSearchScreening.Name = "buttonSearchScreening";
            this.buttonSearchScreening.Size = new System.Drawing.Size(189, 48);
            this.buttonSearchScreening.TabIndex = 25;
            this.buttonSearchScreening.Text = "Search Screening Report";
            this.buttonSearchScreening.UseVisualStyleBackColor = true;
            this.buttonSearchScreening.Click += new System.EventHandler(this.buttonSearchScreening_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Snap ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(311, 27);
            this.label2.TabIndex = 26;
            this.label2.Text = "COVID-19 Self-Screening";
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ScreeningTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PRG455_project.UserAndScreeningDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = this.userTableAdapter;
            // 
            // Adminbutton
            // 
            this.Adminbutton.Font = new System.Drawing.Font("Snap ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adminbutton.ForeColor = System.Drawing.Color.Fuchsia;
            this.Adminbutton.Location = new System.Drawing.Point(294, 63);
            this.Adminbutton.Name = "Adminbutton";
            this.Adminbutton.Size = new System.Drawing.Size(92, 74);
            this.Adminbutton.TabIndex = 27;
            this.Adminbutton.Text = "User Admin Page";
            this.Adminbutton.UseVisualStyleBackColor = true;
            this.Adminbutton.Click += new System.EventHandler(this.Adminbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(220, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 22);
            this.label1.TabIndex = 28;
            this.label1.Text = "Submit First!";
            // 
            // Userinput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 321);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Adminbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSearchScreening);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(userIdLabel);
            this.Controls.Add(this.userIdTextBox);
            this.Controls.Add(userNameLabel);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(userTypeLabel);
            this.Controls.Add(this.userTypeComboBox);
            this.Controls.Add(this.buttonscreening);
            this.Controls.Add(this.buttonClose);
            this.Name = "Userinput";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userAndScreeningDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserAndScreeningDataSet userAndScreeningDataSet;
        private System.Windows.Forms.BindingSource userBindingSource;
        private UserAndScreeningDataSetTableAdapters.UserTableAdapter userTableAdapter;
        private UserAndScreeningDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonscreening;
        private System.Windows.Forms.TextBox userIdTextBox;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.ComboBox userTypeComboBox;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonSearchScreening;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Adminbutton;
        private System.Windows.Forms.Label label1;
    }
}

