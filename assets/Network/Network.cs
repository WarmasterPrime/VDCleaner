using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Net.Configuration;
using System.Net.Cache;
using System.Net.NetworkInformation;
using System.Net.Security;
using System.Net.Sockets;
using System.Net.WebSockets;

namespace VDCleaner
{
	public class Network
	{
		public NetworkInterface[] Interfaces;
		public string HostName;
		public string IPv4;
		public string IPv6;
		public int Port;
		public string Subnet;
		public string MAC;
		public List<string>DNS=new List<string>();
		public List<string>Gateway=new List<string>();

		public Network()
		{
			Interfaces=NetworkInterface.GetAllNetworkInterfaces();
			IPHostEntry h=Dns.GetHostEntry(Dns.GetHostName());
			HostName=h.HostName;
			foreach(IPAddress ip in h.AddressList)
				if(ip.AddressFamily==AddressFamily.InterNetwork)
				{
					SetIp(ip);
					break;
				}
			MAC=Interfaces.Where(nic=>nic.OperationalStatus==OperationalStatus.Up && nic.NetworkInterfaceType!=NetworkInterfaceType.Loopback).Select(nic=>nic.GetPhysicalAddress().ToString()).FirstOrDefault().Inserter(":",2);
		}

		private void SetIp(IPAddress q)
		{
			if(q!=null)
			{
				byte[] list=q.GetAddressBytes();
				if(list.Length<5)
					IPv4=q.ToString();
				else
					IPv6=q.ToString();
			}
		}



	}
}
