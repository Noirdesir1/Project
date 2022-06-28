
namespace PRG455_project
{
    partial class Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            this.reportBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.reportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userAndScreeningDataSet = new PRG455_project.UserAndScreeningDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.reportBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.reportDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDtextBox = new System.Windows.Forms.TextBox();
            this.usernamebutton = new System.Windows.Forms.Button();
            this.buttonSavetofile = new System.Windows.Forms.Button();
            this.Datebutton = new System.Windows.Forms.Button();
            this.closecontactbutton = new System.Windows.Forms.Button();
            this.fromdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.TodateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.statuscomboBox = new System.Windows.Forms.ComboBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.resetbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.travelledcomboBox = new System.Windows.Forms.ComboBox();
            this.travelledbutton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.symptomscomboBox = new System.Windows.Forms.ComboBox();
            this.symptombutton2 = new System.Windows.Forms.Button();
            this.tableAdapterManager = new PRG455_project.UserAndScreeningDataSetTableAdapters.TableAdapterManager();
            this.reportTableAdapter = new PRG455_project.UserAndScreeningDataSetTableAdapters.ReportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.reportBindingNavigator)).BeginInit();
            this.reportBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userAndScreeningDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // reportBindingNavigator
            // 
            this.reportBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.reportBindingNavigator.BindingSource = this.reportBindingSource;
            this.reportBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.reportBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.reportBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.reportBindingNavigatorSaveItem});
            this.reportBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.reportBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.reportBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.reportBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.reportBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.reportBindingNavigator.Name = "reportBindingNavigator";
            this.reportBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.reportBindingNavigator.Size = new System.Drawing.Size(888, 25);
            this.reportBindingNavigator.TabIndex = 0;
            this.reportBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // reportBindingSource
            // 
            this.reportBindingSource.DataMember = "Report";
            this.reportBindingSource.DataSource = this.userAndScreeningDataSet;
            // 
            // userAndScreeningDataSet
            // 
            this.userAndScreeningDataSet.DataSetName = "UserAndScreeningDataSet";
            this.userAndScreeningDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // reportBindingNavigatorSaveItem
            // 
            this.reportBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.reportBindingNavigatorSaveItem.Enabled = false;
            this.reportBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("reportBindingNavigatorSaveItem.Image")));
            this.reportBindingNavigatorSaveItem.Name = "reportBindingNavigatorSaveItem";
            this.reportBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.reportBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // reportDataGridView
            // 
            this.reportDataGridView.AutoGenerateColumns = false;
            this.reportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewCheckBoxColumn2,
            this.dataGridViewCheckBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.reportDataGridView.DataSource = this.reportBindingSource;
            this.reportDataGridView.Location = new System.Drawing.Point(0, 28);
            this.reportDataGridView.Name = "reportDataGridView";
            this.reportDataGridView.RowTemplate.Height = 23;
            this.reportDataGridView.Size = new System.Drawing.Size(742, 220);
            this.reportDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ScreeningId";
            this.dataGridViewTextBoxColumn1.HeaderText = "ScreeningId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "UserId";
            this.dataGridViewTextBoxColumn2.HeaderText = "UserId";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "UserName";
            this.dataGridViewTextBoxColumn3.HeaderText = "UserName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "CloseContact";
            this.dataGridViewCheckBoxColumn1.HeaderText = "CloseContact";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "Travelled";
            this.dataGridViewCheckBoxColumn2.HeaderText = "Travelled";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            // 
            // dataGridViewCheckBoxColumn3
            // 
            this.dataGridViewCheckBoxColumn3.DataPropertyName = "Symptoms";
            this.dataGridViewCheckBoxColumn3.HeaderText = "Symptoms";
            this.dataGridViewCheckBoxColumn3.Name = "dataGridViewCheckBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn4.HeaderText = "Date";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // userIDtextBox
            // 
            this.userIDtextBox.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIDtextBox.Location = new System.Drawing.Point(21, 277);
            this.userIDtextBox.Name = "userIDtextBox";
            this.userIDtextBox.Size = new System.Drawing.Size(140, 22);
            this.userIDtextBox.TabIndex = 2;
            // 
            // usernamebutton
            // 
            this.usernamebutton.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamebutton.Location = new System.Drawing.Point(32, 335);
            this.usernamebutton.Name = "usernamebutton";
            this.usernamebutton.Size = new System.Drawing.Size(115, 26);
            this.usernamebutton.TabIndex = 3;
            this.usernamebutton.Text = "Search User Name";
            this.usernamebutton.UseVisualStyleBackColor = true;
            this.usernamebutton.Click += new System.EventHandler(this.usernamebutton_Click);
            // 
            // buttonSavetofile
            // 
            this.buttonSavetofile.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSavetofile.Location = new System.Drawing.Point(32, 407);
            this.buttonSavetofile.Name = "buttonSavetofile";
            this.buttonSavetofile.Size = new System.Drawing.Size(115, 31);
            this.buttonSavetofile.TabIndex = 4;
            this.buttonSavetofile.Text = "Save to a File";
            this.buttonSavetofile.UseVisualStyleBackColor = true;
            this.buttonSavetofile.Click += new System.EventHandler(this.buttonSavetofile_Click);
            // 
            // Datebutton
            // 
            this.Datebutton.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datebutton.Location = new System.Drawing.Point(212, 371);
            this.Datebutton.Name = "Datebutton";
            this.Datebutton.Size = new System.Drawing.Size(116, 28);
            this.Datebutton.TabIndex = 5;
            this.Datebutton.Text = "Search by Date";
            this.Datebutton.UseVisualStyleBackColor = true;
            this.Datebutton.Click += new System.EventHandler(this.Datebutton_Click);
            // 
            // closecontactbutton
            // 
            this.closecontactbutton.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closecontactbutton.Location = new System.Drawing.Point(420, 332);
            this.closecontactbutton.Name = "closecontactbutton";
            this.closecontactbutton.Size = new System.Drawing.Size(121, 51);
            this.closecontactbutton.TabIndex = 6;
            this.closecontactbutton.Text = "Search Close Contact Status";
            this.closecontactbutton.UseVisualStyleBackColor = true;
            this.closecontactbutton.Click += new System.EventHandler(this.button4_Click);
            // 
            // fromdateTimePicker
            // 
            this.fromdateTimePicker.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromdateTimePicker.Location = new System.Drawing.Point(184, 274);
            this.fromdateTimePicker.Name = "fromdateTimePicker";
            this.fromdateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.fromdateTimePicker.TabIndex = 7;
            // 
            // TodateTimePicker2
            // 
            this.TodateTimePicker2.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TodateTimePicker2.Location = new System.Drawing.Point(184, 330);
            this.TodateTimePicker2.Name = "TodateTimePicker2";
            this.TodateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.TodateTimePicker2.TabIndex = 8;
            // 
            // statuscomboBox
            // 
            this.statuscomboBox.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statuscomboBox.FormattingEnabled = true;
            this.statuscomboBox.Items.AddRange(new object[] {
            "True",
            "False"});
            this.statuscomboBox.Location = new System.Drawing.Point(420, 277);
            this.statuscomboBox.Name = "statuscomboBox";
            this.statuscomboBox.Size = new System.Drawing.Size(121, 26);
            this.statuscomboBox.TabIndex = 9;
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.Color.Red;
            this.buttonClose.Location = new System.Drawing.Point(801, 407);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 31);
            this.buttonClose.TabIndex = 10;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // resetbutton
            // 
            this.resetbutton.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetbutton.Location = new System.Drawing.Point(400, 407);
            this.resetbutton.Name = "resetbutton";
            this.resetbutton.Size = new System.Drawing.Size(75, 31);
            this.resetbutton.TabIndex = 11;
            this.resetbutton.Text = "RESET Gridview";
            this.resetbutton.UseVisualStyleBackColor = true;
            this.resetbutton.Click += new System.EventHandler(this.resetbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(182, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "From:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(182, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "To:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(417, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "Close Contact Status:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(566, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 18);
            this.label5.TabIndex = 18;
            this.label5.Text = "Travelled Status:";
            // 
            // travelledcomboBox
            // 
            this.travelledcomboBox.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.travelledcomboBox.FormattingEnabled = true;
            this.travelledcomboBox.Items.AddRange(new object[] {
            "True",
            "False"});
            this.travelledcomboBox.Location = new System.Drawing.Point(566, 277);
            this.travelledcomboBox.Name = "travelledcomboBox";
            this.travelledcomboBox.Size = new System.Drawing.Size(121, 26);
            this.travelledcomboBox.TabIndex = 17;
            // 
            // travelledbutton
            // 
            this.travelledbutton.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.travelledbutton.Location = new System.Drawing.Point(566, 335);
            this.travelledbutton.Name = "travelledbutton";
            this.travelledbutton.Size = new System.Drawing.Size(121, 48);
            this.travelledbutton.TabIndex = 16;
            this.travelledbutton.Text = "Search Travelled Status";
            this.travelledbutton.UseVisualStyleBackColor = true;
            this.travelledbutton.Click += new System.EventHandler(this.travelledbutton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(706, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 18);
            this.label6.TabIndex = 21;
            this.label6.Text = "Symptoms Status:";
            // 
            // symptomscomboBox
            // 
            this.symptomscomboBox.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.symptomscomboBox.FormattingEnabled = true;
            this.symptomscomboBox.Items.AddRange(new object[] {
            "True",
            "False"});
            this.symptomscomboBox.Location = new System.Drawing.Point(709, 278);
            this.symptomscomboBox.Name = "symptomscomboBox";
            this.symptomscomboBox.Size = new System.Drawing.Size(121, 26);
            this.symptomscomboBox.TabIndex = 20;
            // 
            // symptombutton2
            // 
            this.symptombutton2.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.symptombutton2.Location = new System.Drawing.Point(709, 335);
            this.symptombutton2.Name = "symptombutton2";
            this.symptombutton2.Size = new System.Drawing.Size(121, 48);
            this.symptombutton2.TabIndex = 19;
            this.symptombutton2.Text = "Search Symptoms Status";
            this.symptombutton2.UseVisualStyleBackColor = true;
            this.symptombutton2.Click += new System.EventHandler(this.symptombutton2_Click);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.ScreeningTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PRG455_project.UserAndScreeningDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            // 
            // reportTableAdapter
            // 
            this.reportTableAdapter.ClearBeforeFill = true;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.symptomscomboBox);
            this.Controls.Add(this.symptombutton2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.travelledcomboBox);
            this.Controls.Add(this.travelledbutton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resetbutton);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.statuscomboBox);
            this.Controls.Add(this.TodateTimePicker2);
            this.Controls.Add(this.fromdateTimePicker);
            this.Controls.Add(this.closecontactbutton);
            this.Controls.Add(this.Datebutton);
            this.Controls.Add(this.buttonSavetofile);
            this.Controls.Add(this.usernamebutton);
            this.Controls.Add(this.userIDtextBox);
            this.Controls.Add(this.reportDataGridView);
            this.Controls.Add(this.reportBindingNavigator);
            this.Name = "Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportBindingNavigator)).EndInit();
            this.reportBindingNavigator.ResumeLayout(false);
            this.reportBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userAndScreeningDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserAndScreeningDataSet userAndScreeningDataSet;
        private System.Windows.Forms.BindingSource reportBindingSource;
        private UserAndScreeningDataSetTableAdapters.ReportTableAdapter reportTableAdapter;
        private UserAndScreeningDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator reportBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton reportBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView reportDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox userIDtextBox;
        private System.Windows.Forms.Button usernamebutton;
        private System.Windows.Forms.Button buttonSavetofile;
        private System.Windows.Forms.Button Datebutton;
        private System.Windows.Forms.Button closecontactbutton;
        private System.Windows.Forms.DateTimePicker fromdateTimePicker;
        private System.Windows.Forms.DateTimePicker TodateTimePicker2;
        private System.Windows.Forms.ComboBox statuscomboBox;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button resetbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox travelledcomboBox;
        private System.Windows.Forms.Button travelledbutton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox symptomscomboBox;
        private System.Windows.Forms.Button symptombutton2;
    }
}