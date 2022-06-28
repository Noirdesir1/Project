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
    public partial class Userinput : Form
    {
        public Userinput()
        {
            InitializeComponent();
        }


        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonscreening_Click(object sender, EventArgs e)
        {
            if (userIdTextBox.Text == "" | userNameTextBox.Text == "" | userTypeComboBox.Text == "")
            {
                MessageBox.Show("Please fill in all blanks!");
            }
            else if (Convert.ToBoolean(this.userTableAdapter.ReturnValue(userIdTextBox.Text)))
            {
                MessageBox.Show("Sorry! You are flagged and not allowed to take self-screening!\nPlease contact faculty!");
            }
            else
            {
                Screening s = new Screening();
                s.ShowDialog();
            }
               
        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            this.userBindingSource.AddNew();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (userIdTextBox.Text != "" && userNameTextBox.Text != "" && userTypeComboBox.Text != "") 
            {
                try
                {
                    this.userTableAdapter.InsertQueryuser(userIdTextBox.Text, userNameTextBox.Text, userTypeComboBox.Text);
                    Userinfo.id = userIdTextBox.Text;
                }
                catch
                {
                    MessageBox.Show("Sorry! You cannot sumbit identical profile!");
                }
            }
            else
            {
                MessageBox.Show("Please fill in all blanks!");
            }
          
        }

       


        private void buttonSearchScreening_Click(object sender, EventArgs e)
        {
           
                Report r = new Report();
                r.ShowDialog();
            

        }

        private void Adminbutton_Click(object sender, EventArgs e)
        {
            UserAdmin u = new UserAdmin();
            u.ShowDialog();
        }
    }
}

public static class Userinfo
{
    public static string id;
}