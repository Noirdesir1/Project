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
    public partial class UserAdmin : Form
    {
        public UserAdmin()
        {
            InitializeComponent();
        }

        private void userBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.userBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.userAndScreeningDataSet);

        }

        private void UserAdmin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'userAndScreeningDataSet.Screening' table. You can move, or remove it, as needed.
            this.screeningTableAdapter.Fill(this.userAndScreeningDataSet.Screening);
            // TODO: This line of code loads data into the 'userAndScreeningDataSet.User' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.userAndScreeningDataSet.User);

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
