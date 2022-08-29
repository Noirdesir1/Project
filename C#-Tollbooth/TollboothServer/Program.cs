using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TollboothServer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
            TollboothServer server = new TollboothServer(cancellationTokenSource.Token);
            Application.Run(new TollboothServerForm(server, cancellationTokenSource));
        }
    }
}
