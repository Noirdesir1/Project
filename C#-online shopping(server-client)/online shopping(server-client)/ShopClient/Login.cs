using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShopClient;

namespace ShopClient
{
    public partial class FormLogin : Form
    {
		private readonly IShopData m_session;
		public FormLogin(IShopData session)
        {
            InitializeComponent();
			m_session = session;
		}

        private async void buttonConnect_Click(object sender, EventArgs e)
        {
			try
			{
				if (!m_session.ClosedOrNot && textBoxhostname.Text != m_session.HostName)
				{
					await m_session.Disconnect();
				}
				if (m_session.ClosedOrNot)
				{
					m_session.HostName = textBoxhostname.Text;
					m_session.AccountNo = int.Parse(textBoxaccountno.Text);
					await m_session.Start();
				}

				base.DialogResult = DialogResult.OK;
				Close();
			}
			catch (InvalidOperationException x)
			{
				InvalidOperationException i = x;
				MessageBox.Show(i.Message, i.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				base.DialogResult = DialogResult.Cancel;
				Close();
			}
		}

        private void textBoxhostname_TextChanged(object sender, EventArgs e)
        {
			
			buttonConnect.Enabled = !string.IsNullOrEmpty(textBoxhostname.Text);
		}

        private void textBoxaccountno_TextChanged(object sender, EventArgs e)
        {
			buttonConnect.Enabled = !string.IsNullOrEmpty(textBoxaccountno.Text);
		}

        private void FormLogin_Load(object sender, EventArgs e)
        {
			this.textBoxhostname.Text = "localhost";
        }
    }
}
