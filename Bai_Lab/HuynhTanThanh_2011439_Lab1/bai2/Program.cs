using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;

namespace Bai02
{
    class Program
    {
        static void Main(string[] args)
        {
            GetInfoLocalHost();
            Console.ReadKey();
            
        }

        public static void DisplayGatewayAddresses()
        {
            Console.WriteLine("Gateways");
            NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface adapter in adapters)
            {
                IPInterfaceProperties adapterProperties = adapter.GetIPProperties();
                GatewayIPAddressInformationCollection addresses = adapterProperties.GatewayAddresses;
                if (addresses.Count > 0)
                {
                    Console.WriteLine(adapter.Description);
                    foreach (GatewayIPAddressInformation address in addresses)
                    {
                        Console.WriteLine("\tGateway Address ......................... : {0}",
                            address.Address.ToString());
                    }
                    Console.WriteLine();
                }
            }
        }

        public static IPAddress GetSubnetMask(IPAddress address)
        {
            foreach (NetworkInterface adapter in NetworkInterface.GetAllNetworkInterfaces())
            {
                foreach (UnicastIPAddressInformation unicastIPAddressInformation in adapter.GetIPProperties().UnicastAddresses)
                {
                    if (unicastIPAddressInformation.Address.AddressFamily == AddressFamily.InterNetwork)
                    {
                        if (address.Equals(unicastIPAddressInformation.Address))
                        {
                            return unicastIPAddressInformation.IPv4Mask;
                        }
                    }
                }
            }
            throw new ArgumentException(string.Format("Can't find subnetmask for IP address '{0}'", address));
        }

        public static void GetInfoLocalHost()
        {
            try
            {
                IPHostEntry hostInfo = Dns.GetHostEntry(Dns.GetHostName());
                Console.WriteLine("Local Host:");
                Console.WriteLine("Ten host: " + hostInfo.HostName);
                
                foreach (IPAddress ipaddr in hostInfo.AddressList)
                {
                    Console.WriteLine("IPv4 address.  .  .  .  .  .  .  .  .  .  . : " + ipaddr.ToString());
                    Console.WriteLine("Subnet Mask .  .  .  .  .  .  .  .  .  .  . : " + GetSubnetMask(ipaddr));
                    if (ipaddr.AddressFamily == AddressFamily.InterNetwork)
                        Console.Write(ipaddr.ToString() + "\n");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
