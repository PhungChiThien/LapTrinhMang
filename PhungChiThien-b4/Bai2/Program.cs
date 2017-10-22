using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            string ipAdress;
            int port;
            string protocol;
            Console.Write("Nhap host ip: ");
            ipAdress = Console.ReadLine();
            Console.Write("Nhap host port: ");
            port = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap protocol: ");
            protocol = Console.ReadLine();

            switch (protocol)
            {
                case "TCP":
                    IPEndPoint ip = new IPEndPoint(IPAddress.Parse(ipAdress), port);
                    TcpClient client = new TcpClient();
                    try
                    {
                        client.Connect(ip);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("host: {0}:{1} is close", ipAdress, port);
                        Console.WriteLine(ex);
                        Environment.Exit(0);
                    }
                    Console.WriteLine("host: {0}:{1} is open", ipAdress, port);
                    break;

                case "UDP":
                    IPEndPoint ipUDP = new IPEndPoint(IPAddress.Parse(ipAdress), port);
                    UdpClient clientUDP = new UdpClient();
                    try
                    {
                        clientUDP.Connect(ipUDP);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("host: {0}:{1} is close", ipAdress, port);
                        Console.WriteLine(ex);
                        Environment.Exit(0);
                    }
                    Console.WriteLine("host: {0}:{1} is open", ipAdress, port);
                    break;
            }
        }
    }
}
