using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace OanTuTi_Server
{
    class Program
    {
        static void Main(string[] args)
        {
            int recv;
            byte[] data = new byte[4];

            IPEndPoint ipep = new IPEndPoint(IPAddress.Any, 9050);
            Socket newsock = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            newsock.Bind(ipep);

            Console.WriteLine("Waiting for client.....");

            IPEndPoint ipClient = new IPEndPoint(IPAddress.Any, 0);
            EndPoint remote = (EndPoint)(ipClient);

            recv = newsock.ReceiveFrom(data, ref remote);
            int clientChossen = BitConverter.ToInt32(data, 0);

            Random rand = new Random();
            int serverChoosen = rand.Next(0, 2);

            if (clientChossen == serverChoosen)
            {
                byte[] result = Encoding.ASCII.GetBytes("Hoa");
                newsock.SendTo(result, remote);
            }

            if (clientChossen > serverChoosen)
            {
                byte[] result = Encoding.ASCII.GetBytes("Thang");
                newsock.SendTo(result, remote);
            }

            if (clientChossen < serverChoosen)
            {
                byte[] result = Encoding.ASCII.GetBytes("Thua");
                newsock.SendTo(result, remote);
            }

        }
    }
}
