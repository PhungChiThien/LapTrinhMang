using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace DNSServer
{
    //named forward resolve by default
    class named
    {
        private TcpListener server;
        private TcpClient client;
        private NetworkStream netStream;
        private byte[] dataSend, dataReceive;
        private string data;

        private Dictionary<string, string> resolve;	//resolve domain name as key to IP as value

        public named()
        {
            Console.WriteLine("Server init components...");
            dataReceive = new byte[1024];
            dataSend = new byte[1024];

            resolve = new Dictionary<string, string>();		//add samples
            resolve.Add("https://google.com", "111.222.333.444");
            resolve.Add("https://bing.com", "1.2.3.4");

            server = new TcpListener(IPAddress.Any, 1724);
        }

        public void startListening()
        {
            Console.WriteLine("Server listening...");
            server.Start();
            client = server.AcceptTcpClient();
            netStream = client.GetStream();
            Console.WriteLine("Server accepted a client...");

            int dataSize = netStream.Read(dataReceive, 0, 1024);
            data = Encoding.ASCII.GetString(dataReceive, 0, dataSize);
            if (data == "QUERY")			//server accept and respond to client's query
            {
                data = "ACCEPT";
                dataSend = Encoding.ASCII.GetBytes(data);
                netStream.Write(dataSend, 0, data.Length);
            }

            dataSize = netStream.Read(dataReceive, 0, 1024);		//receiving query
            string key = Encoding.ASCII.GetString(dataReceive, 0, dataSize);		//translate byte array to domain name as string
            Console.WriteLine("Server received a query: " + key);
            string value = resolve[key];
            dataSend = Encoding.ASCII.GetBytes(value);		//return resolved result to client
            netStream.Write(dataSend, 0, value.Length);
            Console.WriteLine("Server responed with: " + value);

            dataSize = netStream.Read(dataReceive, 0, 1024);
            data = Encoding.ASCII.GetString(dataReceive, 0, dataSize);
            if (data == "ACK")
            {
                client.Close();
                netStream.Close();
                Console.WriteLine("Server disconnected a client...");
            }
        }
    }
}