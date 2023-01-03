using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap ten mien: ");
            string name = "";
            name = Console.ReadLine();

            IPAddress ip = GetLocalIPAddress();
            Console.WriteLine("IP Address: " + ip);
            Console.ReadKey();
        }

        public static IPAddress GetLocalIPAddress()
        {
            var domain = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in domain.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip;
                }
            }
            throw new Exception("Error!");
        }
    }
}
