using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopServer
{
    class Purchase
    {
		public string ProductName { get; }
		public int Quantity { get; }
		public string UserName { get; }

		public Purchase(string productName, int quantity, string userName)
		{
			ProductName = productName;
			Quantity = quantity;
			UserName = userName;
		}
	}
}
