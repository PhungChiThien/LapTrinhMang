using DNSServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNS_Server
{
    class Program
    {
        private static named named;
        static void Main(string[] args)
        {
            named = new named();
            while (!false)
            {
                named.startListening();
            }
        }
    }
}
