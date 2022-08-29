using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TollboothServer
{
    public class TollboothServer
    {
        private readonly CancellationToken m_cancellationToken;
        public IPAddress ServerIp { get; set; } = IPAddress.Any; // Default to any local ip
        public int ServerPort { get; set; } = 55057; // Default to port 55057
        private readonly ConcurrentDictionary<int, Tollbooth> m_currentTollbooths = new ConcurrentDictionary<int, Tollbooth>();
        public ConcurrentQueue<TollboothDataChange> PendingActions { get; } = new ConcurrentQueue<TollboothDataChange>();
        public IProgress<TollboothDataChange> Progress { get; set; } = null;

        public TollboothServer(CancellationToken cancellationToken) => m_cancellationToken = cancellationToken;

        // Handle new client connections
        private void Start()
        {
            try
            {
                TcpListener listener = new TcpListener(ServerIp, ServerPort);
                listener.Start(); // Once the listener is started, the client can connect and send data.  More than one client can connect.
                m_cancellationToken.Register(listener.Stop); // Stop the server port listener if a cancellation is requested
                while (!m_cancellationToken.IsCancellationRequested)
                {
                    TcpClient tcpClient = listener.AcceptTcpClient(); // Get the next ready client connection, or wait for a client connection if no new clients are connected
                    TollboothClientHandler handler = new TollboothClientHandler(tcpClient, m_currentTollbooths, Progress);
                    ThreadPool.QueueUserWorkItem(handler.Run); // Thread is not long running, so can use thread pool
                }
            }
            catch (SocketException) // Exception takes us out of the loop, server connection handler thread will end
            {
                // SocketException may occur when listener is started or stopped
            }
        }

        public void StartServer() => new Thread(Start).Start();
    }
}
