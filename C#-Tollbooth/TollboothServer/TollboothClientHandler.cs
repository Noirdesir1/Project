using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TollboothServer
{
    public class TollboothClientHandler
    {
        private readonly TcpClient m_tcpClient;
        private readonly ConcurrentDictionary<int, Tollbooth> m_currentTollbooths;
        private readonly IProgress<TollboothDataChange> m_progress;

        public TollboothClientHandler(TcpClient tcpClient, ConcurrentDictionary<int, Tollbooth> currentTollbooths, IProgress<TollboothDataChange> progress)
        {
            m_tcpClient = tcpClient;
            m_currentTollbooths = currentTollbooths;
            m_progress = progress;
        }

        // Handle client session
        public void Run(object threadInfo)
        {
            // Using makes sure TcpClient is closed at end of scope
            using (m_tcpClient)
            {
                try
                {
                    NetworkStream stream = m_tcpClient.GetStream();
                    StreamReader reader = new StreamReader(stream);
                    StreamWriter writer = new StreamWriter(stream);

                    string line = reader.ReadLine();
                    if (line != null) // A null value indicates the client may have closed the connection
                    {
                        if ("CREATE" == line)
                        {
                            Tollbooth tollbooth = new Tollbooth();
                            if (m_currentTollbooths.TryAdd(tollbooth.Id, tollbooth))
                            {
                                writer.WriteLine(tollbooth.Id);
                                writer.Flush(); // Push out any text that is still in the buffer
                                m_progress?.Report(new TollboothDataChange(TollboothDataChange.ChangeType.ADD, tollbooth));
                            }
                        }
                        else
                        {
                            string[] request = line.Split(':');
                            if (2 == request.Length && int.TryParse(request[1], out int tollboothId)) // Tollbooth id comes after :
                            {
                                string cmd = request[0]; // Command comes before :
                                if ("CLOSE" == cmd)
                                {
                                    if (m_currentTollbooths.TryRemove(tollboothId, out Tollbooth tollbooth))
                                        m_progress?.Report(new TollboothDataChange(TollboothDataChange.ChangeType.REMOVE, tollbooth)); // Tollbooth is no longer current, so remove
                                }
                                else
                                {
                                    try
                                    {
                                        Tollbooth tollbooth = m_currentTollbooths.Values.Single(tb => tb.Id == tollboothId);
                                        (string Command, Action ActionCall)[] executeCommand = new (string, Action)[] { // Create tuple array
                                            ("GET", null), // If the command is GET, no method should be called
                                            ("PAYING_CAR", tollbooth.PayingCar), // If the command is PAYING_CAR, tollbooth.PayingCar should be called
                                            ("NON_PAYING_CAR", tollbooth.NonPayingCar), // If the command is NON_PAYING_CAR, tollbooth.NonPayingCar should be called
                                            ("RESET", tollbooth.Reset) // If the command is RESET, tollbooth.Reset should be called
                                        };
                                        var findCmd = executeCommand.Where(excmd => excmd.Command == cmd); // Create a sequence of one element if the command matches, otherwise sequence is empty
                                        if (findCmd.Any()) // Any is true if sequence is not empty
                                        {
                                            int cars;
                                            decimal cash;

                                            lock (tollbooth)
                                            {
                                                findCmd.Single().ActionCall?.Invoke(); // Perform the tollbooth update

                                                cars = tollbooth.Cars;
                                                cash = tollbooth.Cash;
                                            }
                                            writer.WriteLine($"{cars},{cash}");
                                            writer.Flush(); // Push out any text that is still in the buffer
                                            if (findCmd.Single().ActionCall != null) // If an update was performed
                                                m_progress?.Report(new TollboothDataChange(TollboothDataChange.ChangeType.UPDATE, tollbooth));
                                        }
                                    }
                                    catch (InvalidOperationException)
                                    {
                                        // Tollbooth not found
                                    }
                                }
                            }
                        }
                    }
                }
                catch (IOException) // Exception takes us out of the loop, so client handler thread will end
                {
                    Console.WriteLine("***Network Error***");
                }
                catch (OutOfMemoryException)
                {
                    // Catch buffer overflow exception
                    // Connection will close upon leaving the using block
                }
            }
        }
    }
}
