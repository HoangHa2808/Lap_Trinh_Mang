using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Lab02.Cau1
{
    class Program
    {
        static void Main(string[] args)
        {
            IPEndPoint serverEndpoint = new IPEndPoint(IPAddress.Any, 5000);

            Socket serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            serverSocket.Bind(serverEndpoint);
            serverSocket.Listen(10);

        

            Socket clientSocket = serverSocket.Accept();

            EndPoint clientEndpoint = clientSocket.RemoteEndPoint;

            byte[] buff;
            string hello = "Hello Client";
            buff = Encoding.ASCII.GetBytes(hello);
            clientSocket.Send(buff, 0, buff.Length, SocketFlags.None);


            serverSocket.Close();
            clientSocket.Close();
        }
    }
}