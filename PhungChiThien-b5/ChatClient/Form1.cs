using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace ChatClient
{
    public partial class Form1 : Form
    {
    
        private TcpClient client;
        private NetworkStream netStream;
        private byte[] dataSend, dataReceive;

        private string data;
        private int dataSize;

        public ChatClient()
        {
            InitializeComponent();

            dataSend = new byte[1024];
            dataReceive = new byte[1024];
            client = new TcpClient();
        }

        private void btnConnect_Click(object sender, System.EventArgs e)
        {
            client.BeginConnect(txtHost.Text, 1724, new AsyncCallback(connectServer), client);
            lbxConversation.Items.Add("Client connecting to server...");
        }

        private void connectServer(IAsyncResult ar)
        {
            netStream = client.GetStream();
            lbxConversation.Items.Add("Client connected to server...");
            lbxConversation.Items.Add("***************************************");
        }

        private void btnText_Click(object sender, System.EventArgs e)
        {

        }
    }
}
