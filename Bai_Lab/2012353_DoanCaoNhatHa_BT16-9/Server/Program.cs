using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
	internal class Program
	{
		static void Main(string[] args)
		{
			byte[] data = new byte[1024];
			TcpListener server = new TcpListener(IPAddress.Any, 9050);
			server.Start();
			TcpClient client = server.AcceptTcpClient();
			NetworkStream ns = client.GetStream();
			int recv;

			while (true)
			{
				string[] a = new string[3];
				for (int i = 0; i < 3; i++)
				{
					recv = ns.Read(data, 0, 2);
					a[i] = Encoding.ASCII.GetString(data, 0, recv);

				}

				Console.WriteLine("{0} {1} {2} = {3}", a[0], a[2], a[1], getMath(a[2], float.Parse(a[0]), float.Parse(a[1])));
				recv = ns.Read(data, 0, 2);
				var status = Encoding.ASCII.GetString(data, 0, recv);
				if (string.IsNullOrEmpty(status)) break;
			}

			ns.Close();
			client.Close();
			server.Stop();
			Console.ReadLine();
		}

		static float getMath(string o, float a, float b)
		{
			switch (o)
			{
				case "+":
					return a + b;
				case "-":
					return a - b;
				case "*":
					return a * b;
				case "/":
					return a / b;
			}
			return 0;
		}
	}
}
