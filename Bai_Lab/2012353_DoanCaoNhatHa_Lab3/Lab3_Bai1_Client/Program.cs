using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Bai1_Client
{
	internal class Program
	{
		static void Main(string[] args)
		{
			IPEndPoint serverEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 5000);
           		Socket serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
           		string str = "Hello Server";
            	byte[] data = Encoding.ASCII.GetBytes(str);

            	Console.WriteLine("Dang gui cau chao...");
            	serverSocket.SendTo(data, data.Length, SocketFlags.None, serverEndPoint);
            	Console.WriteLine("Da gui cau chao");

           		Console.ReadLine();
		}
	}
}
