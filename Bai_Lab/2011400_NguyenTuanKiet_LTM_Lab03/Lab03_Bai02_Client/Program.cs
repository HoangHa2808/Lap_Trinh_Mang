using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Lab03_Bai02_Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPEndPoint serverEndpoint = new IPEndPoint(IPAddress.Loopback, 1234);
            Socket serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            Console.WriteLine("Nhap cau chao: ");
            string str = Console.ReadLine();

            if (str.Equals("exit"))
            {
                serverSocket.Close();
                Console.WriteLine("Da thoat chuong trinh client");
                Console.ReadLine();
                return;
            }

            byte[] data = Encoding.ASCII.GetBytes(str);

            Console.WriteLine("Dang gui cau chao...");
            serverSocket.SendTo(data, data.Length, SocketFlags.None, serverEndpoint);
            Console.WriteLine("Da gui cau chao");

            Console.ReadLine();

            serverSocket.Close();
        }
    }
}
