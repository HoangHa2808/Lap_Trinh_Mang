using System;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace Lab2_Bai2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			IPEndPoint svrEndPoint = new IPEndPoint(IPAddress.Any, 5000);
			Socket svrSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

			svrSocket.Bind(svrEndPoint);
			svrSocket.Listen(10);
			Socket cltSocket = svrSocket.Accept();

			EndPoint cltEndPoint = cltSocket.RemoteEndPoint;
			Console.WriteLine(cltEndPoint.ToString());

			byte[] buff;
			string hello = "Hello Client";
			buff = Encoding.ASCII.GetBytes(hello);
			cltSocket.Send(buff, 0, buff.Length, SocketFlags.None);

			Console.ReadKey();
			svrSocket.Close();
			cltSocket.Close();

		}
	}
}
