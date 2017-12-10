using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace DNSClient
{
    class dnsclient
    {
        private TcpClient client;
        private NetworkStream netStream;
        private byte[] dataSend, dataReceive;

        private string data;
        private int dataSize;

        public dnsclient()
        {
            Console.WriteLine("Client init components...");
            dataReceive = new byte[1024];
            dataSend = new byte[1024];

            client = new TcpClient();
        }

        public void requestResolve(string domain)
        {
            client.Connect(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1724));
            netStream = client.GetStream();
            Console.WriteLine("Client connected to server...");

            data = "QUERY";		//ask server to send query
            dataSend = Encoding.ASCII.GetBytes(data);
            netStream.Write(dataSend, 0, data.Length);
            Console.WriteLine("Client sending request...");

            dataSize = netStream.Read(dataReceive, 0, 1024);
            data = Encoding.ASCII.GetString(dataReceive, 0, dataSize);
            if (data == "ACCEPT")		//if server accepts
            {
                dataSend = Encoding.ASCII.GetBytes(domain);
                netStream.Write(dataSend, 0, domain.Length);
                Console.WriteLine("Client has been accepted and sent a query ...");
            }

            dataSize = netStream.Read(dataReceive, 0, 1024);		//receive resolve result
            data = Encoding.ASCII.GetString(dataReceive, 0, dataSize);
            Console.WriteLine("Resolved result: " + data); ;

            data = "ACK";		//inform server that client has received result and closing connection
            dataSend = Encoding.ASCII.GetBytes(data);
            netStream.Write(dataSend, 0, data.Length);

            client.Close();
            Console.WriteLine("Client disconnected...");
        }
    }
}