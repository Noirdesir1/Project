using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ShopServer
{
    class ShopServer
    {
        private readonly CancellationToken m_cancellationToken;
        public IPAddress ServerIp { get; set; } = IPAddress.Any; 
        public int ServerPort { get; set; } = 55058;
        private readonly Random rand = new Random();

        private IList<Product> m_products = new List<Product>();

        private IList<User> m_Users = new List<User>();

        public ShopServer(CancellationToken cancellationToken) => m_cancellationToken = cancellationToken;

        public void Start()
        {
            try
            {
                ProduceProduct();
                ProduceAccount();
                TcpListener listener = new TcpListener(ServerIp, ServerPort);
                listener.Start();
                m_cancellationToken.Register(listener.Stop); 
                while (!m_cancellationToken.IsCancellationRequested)
                {
                    TcpClient tcpClient = listener.AcceptTcpClient();
                    new Thread(new ShopServerHandler(m_products, m_Users, tcpClient, m_cancellationToken).Run).Start();
                }
            }
            catch (SocketException) 
            {

            }
        }

        private void ProduceProduct()
        {
            IList<string> product = new List<string> { "keyboard", "mouse", "CPU", "memory", "headset" };
            foreach(string thing in product)
            {
                m_products.Add(new Product(thing, rand.Next(1, 4)));
            }
        }

        private void ProduceAccount()
        {
            m_Users.Add(new User(1111, "Atson"));
            m_Users.Add(new User(2222, "Ruby"));
            m_Users.Add(new User(3333, "Wendy"));

        }

    }
}
