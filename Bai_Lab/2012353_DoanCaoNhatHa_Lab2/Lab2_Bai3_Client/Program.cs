using System;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace Lab2_Bai3_Client
{
	internal class Program
	{
		static void Main(string[] args)
		{
			IPEndPoint svrEndPoint = new IPEndPoint(IPAddress.Any, 5000);
			Socket svrSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

			Console.WriteLine("Dang ket noi voi server.....");
			svrSocket.Connect(svrEndPoint);

			if(svrSocket.Connected)
			{
				Console.WriteLine("Ket noi thanh cong voi server....");
				byte[] buff = new byte[100];
				int byteReceive = svrSocket.Receive(buff, 0, buff.Length, SocketFlags.None);

				string str = Encoding.ASCII.GetString(buff, 0, byteReceive);
				Console.WriteLine("Ket qua tra ve tu sever: " + str);
			}
			Console.ReadKey();

			svrSocket.Close();
		}
	}
}
