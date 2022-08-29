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
    public partial class TollboothClientForm : Form
    {
        private readonly ITollboothData m_tollbooth;
        private int m_tollboothId = 0;

        public TollboothClientForm(ITollboothData tollbooth)
        {
            InitializeComponent();
            m_tollbooth = tollbooth;
        }

        private void TollboothClientForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            m_tollbooth.Progress = null; // Disable progress reporting
            m_tollbooth.Close(m_tollboothId);
        }

        private void TollboothClientForm_Load(object sender, EventArgs e)
        {
            m_tollbooth.Progress = new Progress<Tollbooth>(TollboothUpdate_ProgressReport);
            if (SetHost())
                m_tollbooth.Create();
            else
                Application.Exit();
        }

        private void TollboothUpdate_ProgressReport(Tollbooth tollboothData)
        {
            if (null == tollboothData) // Could not reach tollbooth in the server
            {
                MessageBox.Show("Server Unavailable", "Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            else if (0 == tollboothData.Id)
            {
                MessageBox.Show("Unable to create tollbooth", "Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            else
            {
                if (0 == m_tollboothId)
                {
                    m_tollboothId = tollboothData.Id;
                    this.Text = $"Tollbooth #{m_tollboothId}";
                }
                lblCars.Text = tollboothData.Cars.ToString();
                lblCash.Text = tollboothData.Cash.ToString("C2");
            }
        }

        private void btnClose_Click(object sender, EventArgs e) => this.Close();

        private void btnPayingCar_Click(object sender, EventArgs e) => m_tollbooth.PayingCar(m_tollboothId);

        private void btnNonPayingCar_Click(object sender, EventArgs e) => m_tollbooth.NonPayingCar(m_tollboothId);

        private void btnReset_Click(object sender, EventArgs e) => m_tollbooth.Reset(m_tollboothId);

        private bool SetHost() => new SetHostForm(m_tollbooth).ShowDialog(this) == DialogResult.OK;
    }
}
