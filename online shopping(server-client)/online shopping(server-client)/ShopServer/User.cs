using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopServer
{
    class User
    {
		public int AccountNo { get; set; }

		public string UserName { get; set; }

		public User(int accountNo, string userName)
		{
			AccountNo = accountNo;
			UserName = userName;
		}
	}
}
