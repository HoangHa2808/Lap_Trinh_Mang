using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Bai1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Nhap ten mien: ");
			string domain = "";
			domain = Console.ReadLine();
			Console.WriteLine("Phan giai ten mien: " + domain);
			GetHostInfo(domain);
		}

		static void GetHostInfo(string host)
		{
			try
			{
				IPHostEntry hostInfo = Dns.GetHostEntry(host);
				Console.WriteLine("Ten mien: " + hostInfo.HostName);
				Console.Write("Dia chi IP: ");
				foreach (IPAddress ipaddr in hostInfo.AddressList)
				{
				Console.Write(ipaddr.ToString() + " ");  
				}
				Console.ReadLine();

			}

			catch
			{
				Console.WriteLine("Khong phan giai duoc ten mien: " + host + "\n");
			}
		}
	}
}
