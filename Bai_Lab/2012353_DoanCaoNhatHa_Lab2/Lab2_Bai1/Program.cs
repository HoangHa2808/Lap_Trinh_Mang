using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Lab2_Bai1
{
    class Program
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

            Console.ReadKey();
            
            svrSocket.Close();
            cltSocket.Close();

        }
    }
}
