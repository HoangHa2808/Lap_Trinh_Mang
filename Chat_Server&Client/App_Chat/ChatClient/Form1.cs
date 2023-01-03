using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatClient
{
    public partial class Form1 : Form
    {
        TcpClient _client;
        byte[] _buffer = new byte[4096]; 
        public Form1()
        {
            InitializeComponent();

            _client = new TcpClient();
            _client.Connect("127.0.0.1", 9000);
            _client.GetStream().BeginRead(_buffer, 0, _buffer.Length, Server_Message, null);
        }

        private void Server_Message(IAsyncResult ar)
        {
            if (ar.IsCompleted)
            {
var bytesIn = _client.GetStream().EndRead(ar);
                if(bytesIn >0)
                {
                    var tmp = new byte[bytesIn];
                    Array.Copy(_buffer, 0, tmp, 0, bytesIn);

                }
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            var msg = Encoding.ASCII.GetBytes(txtSMS.Text);
            _client.GetStream().Write(msg, 0, msg.Length);
            txtSMS.Text = "";
            txtSMS.Focus();
        }
    }
}
