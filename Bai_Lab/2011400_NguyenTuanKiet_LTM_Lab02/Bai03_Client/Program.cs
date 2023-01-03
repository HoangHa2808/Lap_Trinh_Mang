using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Bai03_Client
{
    class Program
    {
        static void Main(string[] args)
        {
            IPEndPoint serverEndpoint = new IPEndPoint(IPAddress.Loopback, 5000);

            Socket serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            Console.WriteLine("Dang ket noi toi server...");

            serverSocket.Connect(serverEndpoint);

            if (serverSocket.Connected)
            {
                Console.WriteLine("Ket noi thanh cong toi server...");
                byte[] buff = new byte[100];
                int byteReceive = serverSocket.Receive(buff, 0, buff.Length, SocketFlags.None);

                string str = Encoding.ASCII.GetString(buff, 0, byteReceive);
                Console.WriteLine("Ket qua tra ve tu server: " + str);
            }

            Console.ReadKey();

            serverSocket.Close();
        }
    }
}
