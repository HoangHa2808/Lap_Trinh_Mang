﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace _2012353_DoanCaoNhatHa_Lab4
{
	internal class Server
	{
		static void Main(string[] args)
		{
			byte[] data = new byte[1024];
			TcpListener server = new TcpListener(IPAddress.Any, 9050);
			server.Start();
			TcpClient client = server.AcceptTcpCLient();
			NetworkStream ns = client.GetStream();

			byte[] size = new byte[2];
			int rec = ns.Read(size, 0, 2);
			int packsize = BitConverter.ToInt16(size, 0);
			Console.WriteLine("Kich thuoc goi tin = {0}", packsize);
			rec = ns.Read(data, 0, packsize);
			Employee emp1 = new Employee(data);
			Console.WriteLine("emp1.EmployeeID = {0}", emp1.EmployeeID);
			Console.WriteLine("emp1.LastName = {0}", emp1.LastName);
			Console.WriteLine("emp1.FirstName = {0}", emp1.FirstName);
			Console.WriteLine("emp1.YearsService = {0}", emp1.YearsService);
			Console.WriteLine("emp1.Salary = {0}", emp1.Salary);

			ns.Close();
			client.Close();
			server.Stop();
		}
	}
}
