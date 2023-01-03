using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DoanCaoNhatHa_Lab6
{
	public partial class Server : Form
	{
		ServerProgram svP = new ServerProgram(IPAddress.Any, 5000);

		public Server()
		{
			InitializeComponent();
			CheckForIllegalCrossThreadCalls = false;
			svP.SetDataFunction = text => lbxServer.Items.Add(text);
			svP.SetStatusFunction = text => txtConnection.Text = text;
		}

		private void btnStart_Click(object sender, EventArgs e)
		{
			svP.Listen();
		}

		private void btnStop_Click(object sender, EventArgs e)
		{
			svP.Close();
		}

		private void Server_Load(object sender, EventArgs e)
		{
			Client clt = new Client();
			clt.Show();
		}
	}
}
