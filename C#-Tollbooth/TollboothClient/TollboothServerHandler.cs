using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TollboothClient
{
    public class TollboothServerHandler : ITollboothData
    {
        public string HostName { get; set; } = "localhost"; // Default host name - localhost means that the server is running on the same computer as this client
        public int HostPort { get; set; } = 55057; // Default host port - note that the port number is the same one as in the server code
        public IProgress<Tollbooth> Progress { get; set; } = null;

        // CREATE
        public void Create()
        {
            ThreadPool.QueueUserWorkItem(threadInfo =>
            {
                (string hostName, int hostPort, IProgress<Tollbooth> progress) = ((string, int, IProgress<Tollbooth>))threadInfo; // Deconstruct tuple
                try
                {
                    using (TcpClient tcpClient = new TcpClient()) // Default constructor only allows IPv4
                    {
                        tcpClient.Connect(hostName, hostPort);
                        NetworkStream stream = tcpClient.GetStream();
                        StreamReader reader = new StreamReader(stream);
                        StreamWriter writer = new StreamWriter(stream);
                        writer.WriteLine("CREATE");
                        writer.Flush();
                        string line = reader.ReadLine();
                        if (line != null) // A null value indicates the client may have closed the connection
                        {
                            if (!int.TryParse(line, out int tollboothId) || tollboothId < 1)
                                throw new InvalidOperationException("CREATE Failed");
                            progress?.Report(new Tollbooth(tollboothId, 0, 0.0m));
                        }
                    }
                }
                catch (InvalidOperationException)
                {
                    progress?.Report(new Tollbooth(0, 0, 0.0m)); // Indicate tollbooth cannot be created (by using 0 for tollbooth id)
                }
                catch (IOException)
                {
                    progress?.Report(null); // Indicate server unavailable
                }
                catch (SocketException)
                {
                    progress?.Report(null); // Indicate server unavailable
                }
                catch (OutOfMemoryException)
                {
                    progress?.Report(null); // Indicate server unavailable
                }
            }, (HostName, HostPort, Progress)); // Thread parameters (in tuple)
        }

        // CLOSE
        public void Close(int TollboothId)
        {
            // To make sure CLOSE gets sent, use a foreground thread
            Thread thClose = new Thread(threadInfo =>
            {
                (string hostName, int hostPort, IProgress<Tollbooth> progress, int tollboothId) = ((string, int, IProgress<Tollbooth>, int))threadInfo; // Deconstruct tuple
                try
                {
                    using (TcpClient tcpClient = new TcpClient()) // Default constructor only allows IPv4
                    {
                        tcpClient.Connect(hostName, hostPort);
                        NetworkStream stream = tcpClient.GetStream();
                        StreamWriter writer = new StreamWriter(stream);
                        writer.WriteLine($"CLOSE:{tollboothId}");
                        writer.Flush();
                    }
                }
                catch (IOException)
                {
                    progress?.Report(null); // Indicate server unavailable
                }
                catch (SocketException)
                {
                    progress?.Report(null); // Indicate server unavailable
                }
            });
            thClose.Start((HostName, HostPort, Progress, TollboothId)); // Thread parameters (in tuple)
        }

        private void SendCommand(string Command, int TollboothId)
        {
            ThreadPool.QueueUserWorkItem(threadInfo =>
            {
                (string hostName, int hostPort, IProgress<Tollbooth> progress, string command, int tollbothId) = ((string, int, IProgress<Tollbooth>, string, int))threadInfo; // Deconstruct tuple
                try
                {
                    using (TcpClient tcpClient = new TcpClient()) // Default constructor only allows IPv4
                    {
                        tcpClient.Connect(hostName, hostPort);
                        NetworkStream stream = tcpClient.GetStream();
                        StreamReader reader = new StreamReader(stream);
                        StreamWriter writer = new StreamWriter(stream);
                        writer.WriteLine($"{command}:{tollbothId}");
                        writer.Flush();
                        string line = reader.ReadLine();
                        if (line != null) // A null value indicates the client may have closed the connection
                        {
                            string[] tollboothInfo = line.Split(',');
                            if (2 == tollboothInfo.Length && int.TryParse(tollboothInfo[0], out int cars) && decimal.TryParse(tollboothInfo[1], out decimal cash))
                                progress?.Report(new Tollbooth(tollbothId, cars, cash));
                        }
                    }
                }
                catch (IOException)
                {
                    progress?.Report(null); // Indicate server unavailable
                }
                catch (SocketException)
                {
                    progress?.Report(null); // Indicate server unavailable
                }
                catch (OutOfMemoryException)
                {
                    progress?.Report(null); // Indicate server unavailable
                }
            }, (HostName, HostPort, Progress, Command, TollboothId)); // Thread parameters (in tuple)
        }

        // GET
        public void Get(int TollboothId) => SendCommand("GET", TollboothId);

        // PAYING_CAR
        public void PayingCar(int TollboothId) => SendCommand("PAYING_CAR", TollboothId);

        // NON_PAYING_CAR
        public void NonPayingCar(int TollboothId) => SendCommand("NON_PAYING_CAR", TollboothId);

        // RESET
        public void Reset(int TollboothId) => SendCommand("RESET", TollboothId);
    }
}
