using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace Bai01
{
    class Program
    {
        static void Main(string[] args)
        {
            string host = "";
            host = Console.ReadLine();
            Console.WriteLine("Phan giai ten mien: " + host);
            GetHostInfo(host);
            Console.ReadKey();
        }

        static void GetHostInfo(string host)
        {
            try
            {
                IPHostEntry hostInfo = Dns.GetHostEntry(host);
                Console.WriteLine("Ten mien: " + hostInfo.HostName);
                Console.Write("Dia chi IP: ");
                foreach (IPAddress ipaddr in hostInfo.AddressList)
                {
                    Console.Write(ipaddr.ToString() + " ");
                }

                Console.WriteLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Khong phan giai duoc ten mien: " + host + "\n");
            }
        }
    }
}
