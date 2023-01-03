using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoanCaoNhatHa_Lab6
{
	public partial class Client : Form
	{ 
		ClientProgram clP = new ClientProgram();
	
		public Client()
		{
			InitializeComponent();
			clP.SetDataFunction = text => lbxClient.Items.Add(text);

		}

		private void btn_Connect_Click(object sender, EventArgs e)
		{
			clP.SetDataFunction = text => lbxClient.Items.Add(text);

		}

		private void btnDisconnect_Click(object sender, EventArgs e)
		{
			clP.Disconnect();
		}

		private void btnSend_Click(object sender, EventArgs e)
		{
			clP.SendData(txtClient.Text);
			txtClient.Text = "";
		}
	}
}
