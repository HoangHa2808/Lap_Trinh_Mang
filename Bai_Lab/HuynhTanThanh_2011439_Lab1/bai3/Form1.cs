using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPhanGiai_Click(object sender, EventArgs e)
        {
            GetHostInfo(txtTenMien.Text);
        }

        public void GetHostInfo(string host)
        {
            try
            {
                IPHostEntry hostInfo = Dns.GetHostEntry(host);
                lblTenMien.Text = "Ten mien: " + hostInfo.HostName;
                string s = "Dia chi IP: ";
                foreach (IPAddress ipaddr in hostInfo.AddressList)
                {
                   s += ipaddr.ToString() + " ";
                }
                lblDiaChiIP.Text = s;
            }
            catch (Exception)
            {
                lblTenMien.Text = "Khong phan giai duoc ten mien: " + host;
                lblDiaChiIP.Text = "";
            }
        }

        private void txtTenMien_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnPhanGiai_Click(this, new EventArgs());
            }
        }
    }
}
