using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG455_project
{
    public partial class Screening : Form
    {
        public Screening()
        {
            InitializeComponent();
        }

        private void screeningBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.screeningBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.userAndScreeningDataSet);

        }

        private void Screening_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'userAndScreeningDataSet.User' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.userAndScreeningDataSet.User);
  

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(this.screeningTableAdapter.countQuery()) + 1;
            this.screeningTableAdapter.InsertQuery(count, Userinfo.id, bool.Parse(closeContactComboBox.Text), bool.Parse(travelledComboBox.Text), bool.Parse(symptomsComboBox.Text), dateDateTimePicker.Text);
            if(bool.Parse(closeContactComboBox.Text)| bool.Parse(travelledComboBox.Text)| bool.Parse(symptomsComboBox.Text))
            {
                this.userTableAdapter.UpdateQuery(true, Userinfo.id);
                MessageBox.Show("Warning! You have been Falgged and are not allowed to enter the campus!\nPlease contact faculty right now!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Submitted Successfully!");
                this.Close();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            this.screeningBindingSource.AddNew();
        }
    }
}
