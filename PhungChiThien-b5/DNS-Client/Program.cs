using DNSClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNS_Client
{
    class Program
    {
        private static dnsclient dnsClient;
        static void Main(string[] args)
        {
            dnsClient = new dnsclient();
            dnsClient.requestResolve("https://google.com");
            System.Console.ReadKey();
        }
    }
}
