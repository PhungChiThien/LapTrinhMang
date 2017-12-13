using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System;

namespace ChatServer
{
    public partial class ChatServer : Form
    {
        private TcpClient client;
        private TcpListener server;
        private NetworkStream netStream;

        private byte[] dataSend, dataReceive;
        private int dataSize;
        private string dataFile;

        public ChatServer()
        {
            InitializeComponent();

            dataSend = new byte[1024];
            dataReceive = new byte[1024];

            this.Load += ChatServer_Load;
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        void ChatServer_Load(object sender, System.EventArgs e)
        {
            server = new TcpListener(new IPEndPoint(IPAddress.Any, 1724));
            server.Start();
            lbxConversation.Items.Add("Server is listening...");
            server.BeginAcceptTcpClient(new AsyncCallback(AcceptClient), server);
        }

        private void AcceptClient(IAsyncResult ar)
        {
            //client = server.AcceptTcpClient();
            client = server.EndAcceptTcpClient(ar);
            netStream = client.GetStream();
            lbxConversation.Items.Add("Server accpeted a client...");
            lbxConversation.Items.Add("***************************************");
        }

        private void btnText_Click(object sender, EventArgs e)
        {
            refreshData();
            netStream.WriteByte(ChatSignal.ChatSignal.REQ_SEND_TEXT);		//send a request to send text to client

            byte signal = Convert.ToByte(netStream.ReadByte());		//receive one byte of signal from client
            if (signal == ChatSignal.ChatSignal.ACK)		//if client ack sent request
            {
                //send text to client
                string text = txtInput.Text;
                dataSend = Encoding.ASCII.GetBytes(text);
                netStream.Write(dataSend, 0, text.Length);
                lbxConversation.Items.Add("Server said: " + text);
            }
        }

        private void refreshData()		//for receiving from client
        {
            byte signal = Convert.ToByte(netStream.ReadByte());		//receive one byte of signal from client
            if (signal == ChatSignal.ChatSignal.REQ_SEND_TEXT)		//if client ack sent request
            {
                //receive txt from client
                dataSize = netStream.Read(dataReceive, 0, 1024);
                string text = Encoding.ASCII.GetString(dataReceive, 0, dataSize);
                lbxConversation.Items.Add("Client said: " + text);
            }
        }
    }
}