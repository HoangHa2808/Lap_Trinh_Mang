using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
	internal class Program
	{
		static void Main(string[] args)
		{
			TcpClient client;
			try
			{
				client = new TcpClient("127.0.0.1", 9050);
			}
			catch (SocketException)
			{
				Console.WriteLine("Khong ket noi duoc voi server");
				return;
			}

			NetworkStream ns = client.GetStream();


			byte[] data;
			string a, b, op;

			while (true)
			{
				Console.Write("a = ");
				a = Console.ReadLine();
				data = Encoding.ASCII.GetBytes(a);
				ns.Write(data, 0, data.Length);
				ns.Flush();

				Console.Write("b = ");
				b = Console.ReadLine();
				data = Encoding.ASCII.GetBytes(b);
				ns.Write(data, 0, data.Length);
				ns.Flush();

				Console.Write("Op: ");
				op = Console.ReadLine();
				data = Encoding.ASCII.GetBytes(op);
				ns.Write(data, 0, data.Length);
				ns.Flush();

				Console.WriteLine("1. Tiep tuc");
				Console.WriteLine("2. Thoat");
				Console.Write("--> ");
				string exit = Console.ReadLine();
				if (exit == "2")
					break;
			}

			ns.Close();
			client.Close();
			Console.ReadLine();
		}
	}
}
