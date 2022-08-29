using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;

namespace ShopClient
{
    class ShopClientHandler:IShopData
    {
		private TcpClient m_tcpClient = null;
		private StreamReader m_reader;
		private StreamWriter m_writer;
		public string HostName { get; set; } = "localhost";
		public int HostPort { get; set; } = 55058;
		public int AccountNo { get; set; }
		public string UserName { get; set; }
		public bool ClosedOrNot => m_tcpClient == null;

		public async Task Start()
        {
            try
            {
				m_tcpClient = new TcpClient();
				m_tcpClient.Connect(HostName, HostPort);
				NetworkStream stream = m_tcpClient.GetStream();
				m_reader = new StreamReader(stream);
				m_writer = new StreamWriter(stream);
				await Connect();
			}
            catch (SocketException x)
			{
				SocketException s = x;
				m_tcpClient = null;
				throw new InvalidOperationException("Server Unavailable", s);
			}

		}

		public async Task Connect()
		{
			try
			{
				await PrintInfo($"CONNECT:{AccountNo}");
				string line = await m_reader.ReadLineAsync();
				if (line == "CONNECT_ERROR")
				{
					throw new InvalidOperationException("Client Number invalid");
				}
				if (line.StartsWith("CONNECTED"))
				{
					int position = line.IndexOf(':') + 1;
					if (position > 0)
					{
						UserName = line.Substring(position);
					}
				}
			}
			catch (IOException x)
			{
				IOException i = x;
				Close();
				throw new InvalidOperationException("Server Unavailable", i);
			}
		}

		public async Task Disconnect()
		{
			if (ClosedOrNot)
			{
				return;
			}
			try
			{
				await PrintInfo("DISCONNECT");
			}
			catch (IOException)
			{
			}
			finally
			{
				Close();
			}
		}
		private void Close()
		{
			m_tcpClient?.Close();
			m_tcpClient = null;
		}
		private async Task PrintInfo(string info)
		{
			await m_writer.WriteLineAsync(info);
			await m_writer.FlushAsync();
			Console.WriteLine(info);
		}

		public async Task<IList<Product>> GetProducts()
		{
			try
			{
				IList<Product> products = new List<Product>();
				await PrintInfo("GET_PRODUCTS");
				string line = await m_reader.ReadLineAsync();
				if (line == "NOT_CONNECTED")
				{
					throw new InvalidOperationException("Client not connected");
				}
				if (line.StartsWith("PRODUCTS"))
				{
					line = line.Substring(line.IndexOf(':') + 1);
					string[] array = line.Split('|');
					foreach (string product in array)
					{
						string[] productInfo = product.Split(',');
						if (productInfo.Length == 2 && !string.IsNullOrEmpty(productInfo[0]) && int.TryParse(productInfo[1], out var quantity))
						{
							products.Add(new Product(productInfo[0], quantity));
						}
					}
				}
				return products;
			}
			catch (IOException x)
			{
				IOException i = x;
				Close();
				throw new InvalidOperationException("Server Unavailable", i);
			}
		}

		public async Task<IList<Purchase>> GetOrders()
		{
			try
			{
				IList<Purchase> purchase = new List<Purchase>();
				await PrintInfo("GET_ORDERS");
				string line = await m_reader.ReadLineAsync();
				if (line == "NOT_CONNECTED") 
				{
					throw new InvalidOperationException("Client not connected");
				}
				if (line.StartsWith("ORDERS"))
				{
					line = line.Substring(line.IndexOf(':') + 1);
					string[] array = line.Split('|');
					foreach (string order in array)
					{
						string[] orderInfo = order.Split(',');
						if (3 == orderInfo.Length && !string.IsNullOrEmpty(orderInfo[0]) && int.TryParse(orderInfo[1], out var quantity) && !string.IsNullOrEmpty(orderInfo[2]))
						{
							purchase.Add(new Purchase(orderInfo[0], quantity, orderInfo[2]));
						}
					}
				}
				return purchase;
			}
			catch (IOException x)
			{
				IOException i = x;
				Close();
				throw new InvalidOperationException("Server Unavailable", i);
			}
		}

		public async Task Purchase(string product)
		{
			if (ClosedOrNot) 
			{
				throw new InvalidOperationException("Client Closed");
			}
			try
			{
				new List<Purchase>();
				await PrintInfo("PURCHASE:" + product);
				string line = await m_reader.ReadLineAsync();
				if (line == "NOT_CONNECTED")
				{
					throw new InvalidOperationException("Client not connected");
				}
				if (line == "NOT_VALID")
				{
					throw new InvalidOperationException("The specified product is not valid");
				}
				if (line == "NOT_AVAILABLE")
				{
					throw new InvalidOperationException("The product is not available");
				}
				if (!(line == "DONE"))
				{
				}
			}
			catch (IOException i)
			{
				Close();
				throw new InvalidOperationException("Server Unavailable", i);
			}
		}

	}
}
