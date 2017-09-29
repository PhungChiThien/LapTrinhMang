using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] a = new byte[4];
            for (int i = 0; i < a.Length; i++)
                a[i] = 10;
            IPAddress ip = new IPAddress.Parse("192.168.1.10");
            Console.WriteLine("IP: {0}", ip);
            Console.WriteLine("Any: {0}", IPAddress.Any);
            Console.WriteLine("Broadcast: {0}", IPAddress.Broadcast);
            Console.WriteLine("Loopback: {0}", IPAddress.Loopback);

            /*IPEndPoint ipe = new IPEndPoint(IPAddress.Parse("123.123.12.13"), 12345);
            Console.WriteLine("IpEndpoint: {0}", ipe);
            Console.WriteLine("IP: {0}", ipe.Address);
            Console.WriteLine("IP: {0}", ip.AddressFamily);*/


            IPHostEntry iphe = Dns.GetHostEntry("www.google.com");
            foreach (IPAddress i in iphe.AddressList)
                Console.WriteLine("IP: {0}", i);
            Console.ReadKey();
        }
    }
}
