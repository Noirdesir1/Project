using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TollboothServer
{
    public partial class TollboothServerForm : Form
    {
        private readonly CancellationTokenSource m_cancellationTokenSource;
        private readonly TollboothServer m_server;

        public TollboothServerForm(TollboothServer server, CancellationTokenSource cancellationTokenSource)
        {
            InitializeComponent();
            m_server = server;
            m_cancellationTokenSource = cancellationTokenSource;
        }

        private void TollboothServerForm_FormClosed(object sender, FormClosedEventArgs e) => m_cancellationTokenSource.Cancel();

        private void TollboothServerForm_Load(object sender, EventArgs e)
        {
            Progress<TollboothDataChange> progress = new Progress<TollboothDataChange>();
            progress.ProgressChanged += Progress_ProgressChanged;
            m_server.Progress = progress;
            m_server.StartServer();
        }

        private void Progress_ProgressChanged(object sender, TollboothDataChange e)
        {
            switch (e.Change)
            {
                case TollboothDataChange.ChangeType.ADD:
                    {
                        int index;
                        for (index = lstTollbooths.Items.Count - 1; index >= 0; index--)
                        {
                            if (((Tollbooth)lstTollbooths.Items[index]).Id < e.Tollbooth.Id)
                                break;
                        }
                        lstTollbooths.Items.Insert(++index, e.Tollbooth);
                    }
                    break;
                case TollboothDataChange.ChangeType.UPDATE:
                    {
                        int index = lstTollbooths.Items.IndexOf(e.Tollbooth);
                        if (index >= 0)
                            lstTollbooths.Items[index] = e.Tollbooth;
                    }
                    break;
                case TollboothDataChange.ChangeType.REMOVE:
                    {
                        int index = lstTollbooths.Items.IndexOf(e.Tollbooth);
                        if (index >= 0)
                            lstTollbooths.Items.RemoveAt(index);
                    }
                    break;
            }
            lblNumTollbooths.Text = $"There are {lstTollbooths.Items.Count} tollbooths connected.";
        }
    }
}
