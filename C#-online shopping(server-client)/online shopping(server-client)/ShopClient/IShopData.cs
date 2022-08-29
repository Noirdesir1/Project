using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopClient
{
    public interface IShopData
    {
		string HostName { get; set; }

		int HostPort { get; set; }

		int AccountNo { get; set; }

		bool ClosedOrNot { get; }

		string UserName { get; set; }

		Task Start();

		Task Disconnect();

		Task Connect();

		Task<IList<Product>> GetProducts();

		Task<IList<Purchase>> GetOrders();

		Task Purchase(string product);
	}
}
