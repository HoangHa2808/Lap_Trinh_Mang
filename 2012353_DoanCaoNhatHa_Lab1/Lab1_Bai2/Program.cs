using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace Lab1_Bai2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Nhap ten mien: ");
			string m = "";
			m = Console.ReadLine();
			IPAddress ip = GetLocalIPAddress();
			//IPAddress sbMask = GetSubnetMask();
			//IPAddress dfGateway = GetDefaultGateway();

			Console.WriteLine("IP Address: " + ip);
			//Console.WriteLine("Subnet Mask: " + sbMask);
			//Console.WriteLine("DefaultGateway: " + dfGateway);
			Console.ReadKey();
		}

		public static IPAddress GetLocalIPAddress()
		{
			var domain = Dns.GetHostEntry(Dns.GetHostName());
			foreach(var ip in domain.AddressList)
			{
				if(ip.AddressFamily == AddressFamily.InterNetwork)
				{
					return ip;
				}
			}
			throw new Exception("Error!");
		}

		//public static IPAddress GetSubnetMask()
		//{

		//}

		//public static IPAddress GetDefaultGateway()
		//{

		//}
	}
}
