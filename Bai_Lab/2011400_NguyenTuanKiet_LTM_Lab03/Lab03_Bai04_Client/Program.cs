﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Lab03_Bai04_Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPEndPoint serverEndpoint = new IPEndPoint(IPAddress.Loopback, 1234);
            Socket serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            serverSocket.Connect(serverEndpoint);

            if (!serverSocket.Connected)
            {
                Console.WriteLine("Co loi trong qua trinh ket noi");
                Console.ReadLine();
                return;
            }

            while (true)
            {
                Console.Write("Nhap du lieu can gui: ");
                string str = Console.ReadLine();

                if (str.Equals("exit")) break;

                byte[] data = Encoding.ASCII.GetBytes(str);

                serverSocket.Send(data);
                Console.WriteLine("Da gui cau chao");

                Console.WriteLine();
            }

            Console.WriteLine("Da thoat chuong trinh client");
            Console.ReadLine();
            serverSocket.Close();
        }
    }
}