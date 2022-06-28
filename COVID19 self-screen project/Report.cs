using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PRG455_project
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'userAndScreeningDataSet.Report' table. You can move, or remove it, as needed.
            this.reportTableAdapter.Fill(this.userAndScreeningDataSet.Report);

        }


        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSavetofile_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Save file";
            save.Filter = "Text Files (*.txt)|*.txt";
            if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StreamWriter write = new StreamWriter(File.Create(save.FileName));
                for(int i = 0; i < reportDataGridView.Rows.Count - 1; i++)
                {
                    for(int j = 0; j < reportDataGridView.Columns.Count; j++)
                    {
                        write.Write(reportDataGridView.Rows[i].Cells[j].Value.ToString() + "|");
                    }
                    write.WriteLine("");
                }

                write.Close();
                MessageBox.Show("Data Saved");
            }
        }

        private void Datebutton_Click(object sender, EventArgs e)
        {
            this.reportTableAdapter.FillBySearchdate(this.userAndScreeningDataSet.Report, fromdateTimePicker.Text,TodateTimePicker2.Text);
        }

        private void resetbutton_Click(object sender, EventArgs e)
        {
            this.reportTableAdapter.Fill(this.userAndScreeningDataSet.Report);
            userIDtextBox.Text = "";
            statuscomboBox.Text = "";
            travelledcomboBox.Text = "";
            symptomscomboBox.Text = "";
        }

        private void usernamebutton_Click(object sender, EventArgs e)
        {
            this.reportTableAdapter.FillBySearchName(this.userAndScreeningDataSet.Report, userIDtextBox.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.reportTableAdapter.FillByclosecontact(this.userAndScreeningDataSet.Report, bool.Parse(statuscomboBox.Text));
        }

        private void travelledbutton_Click(object sender, EventArgs e)
        {
            this.reportTableAdapter.FillBytravelled(this.userAndScreeningDataSet.Report, bool.Parse(travelledcomboBox.Text));
        }

        private void symptombutton2_Click(object sender, EventArgs e)
        {
            this.reportTableAdapter.FillBysymptoms(this.userAndScreeningDataSet.Report, bool.Parse(symptomscomboBox.Text));
        }
    }
}
