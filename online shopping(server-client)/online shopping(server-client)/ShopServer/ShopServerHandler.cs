using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ShopServer
{
    class ShopServerHandler
    {
        private readonly TcpClient m_tcpClient;
        private IList<Product> m_products = new List<Product>();
        private readonly CancellationToken m_cancellationToken;
        private StreamReader m_reader;
        private StreamWriter m_writer;
        private IList<User> m_users = new List<User>();
        private string m_userName = "";
        private readonly object m_lock = new object();
        private static BlockingCollection<Purchase> cur_Purchase { get; set; } = new BlockingCollection<Purchase>();

        public ShopServerHandler(IList<Product> products, IList<User> users, TcpClient tcpClient, CancellationToken cancellationToken)
        {
            m_products = products;
            m_tcpClient = tcpClient;
            m_users = users;
            m_cancellationToken = cancellationToken;
        }

        public void Run()
        {
            using (m_tcpClient)
            {
                try
                {
                    NetworkStream stream = m_tcpClient.GetStream();
                    m_reader = new StreamReader(stream);
                    m_writer = new StreamWriter(stream);
                    m_cancellationToken.Register(stream.Close);

                    while (!m_cancellationToken.IsCancellationRequested)
                    {
                        string line = m_reader.ReadLine();
                        string info = "";

                        Console.WriteLine(line);
                        if (line == null || line == "DISCONNECT")
                        {
                            break;
                        }

                        if (line.StartsWith("CONNECT"))
                        {
                            line = line.Substring(line.IndexOf(':') + 1);
                            if(int.TryParse(line,out var acc))
                            {
                                User user = m_users.FirstOrDefault((User u) => u.AccountNo == acc);

                                if (user == null)
                                {
                                    info = "NOT_VALID";
                                }
                                else
                                {
                                    m_userName = user.UserName;
                                    info = "CONNECTED:" + user.UserName;
                                }
                            }
                        }
                        else if(line == "GET_PRODUCTS")
                        {
                            info = "PRODUCTS:" + string.Join("///", m_products.Select((Product product) => $"{product.Name},{product.Quantity}"));
                        }
                        else if (line == "GET_ORDERS")
                        {
                            info = "ORDERS:" + string.Join("///", cur_Purchase.Select((Purchase pur) => $"{pur.ProductName},{pur.Quantity},{pur.UserName}"));
                        }
                        else if (line.StartsWith("PURCHASE"))
                        {
                            line = line.Substring(line.IndexOf(':') + 1);
                            if (!string.IsNullOrEmpty(line))
                            {
                                Product product = m_products.FirstOrDefault((Product p) => p.Name == line);
                                if (product != null)
                                {
                                    int quantity = product.Quantity;
                                    int count = cur_Purchase.Count((Purchase p) => p.ProductName == product.Name);
                                    if (quantity > count)
                                    {
                                        cur_Purchase.Add(new Purchase(product.Name, 1, m_userName));
                                        info = "DONE";
                                    }
                                    else
                                    {
                                        info = "NOT_AVAILABLE";
                                    }
                                }
                                else
                                {
                                    info = "NOT_VALID";
                                }
                            }
                        }
                        if (!string.IsNullOrEmpty(info))
                        {
                            printInfo(info);
                        }
                    }


                }
                catch (IOException)
                {
                    Console.WriteLine("***Network Error***");
                }
                catch (ObjectDisposedException)
                {
                    Console.WriteLine("***Network Error***");
                }
                catch (OutOfMemoryException)
                {
                }
            }
        }

        private void printInfo(string info)
        {
            lock (m_lock)
            {
                m_writer.WriteLine(info);
                m_writer.Flush();
                Console.WriteLine(info);
            }
        }
    }
}
