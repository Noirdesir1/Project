using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TollboothClient
{
    public partial class SetHostForm : Form
    {
        private readonly ITollboothData m_session;

        public SetHostForm(ITollboothData session)
        {
            InitializeComponent();
            m_session = session;
        }

        private void txtHostName_TextChanged(object sender, EventArgs e) => btnSetHost.Enabled = !string.IsNullOrEmpty(txtHostName.Text);

        private void btnSetHost_Click(object sender, EventArgs e) => m_session.HostName = txtHostName.Text;
    }
}
