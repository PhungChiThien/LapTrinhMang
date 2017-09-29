using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
namespace bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("About my computer");
            Console.WriteLine("- Computer name: \"{0}\"", Dns.GetHostName());

            IPAddress[] myIP = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress ip in myIP)
            {
                Console.WriteLine("- IP {0}: {1}", ip.AddressFamily.ToString(), ip.ToString());
            }
            Console.Write("Nhap ten mien hoac ip: ");
            string host = Console.ReadLine();

            IPHostEntry e = Dns.GetHostEntry(host);
            Console.WriteLine("Hostname: {0}", e.HostName);

            
            foreach (string s in e.Aliases)
                Console.WriteLine("\t+ Alias: {0} \n", s);

            
            foreach (IPAddress i in e.AddressList)
                Console.WriteLine("\t+ IP: {0}", i);
        }
    }
}
