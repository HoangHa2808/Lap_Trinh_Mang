using App_Chat.Properties;
using Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Chat
{
    public partial class Login : Form
    {
        convert cvt = new convert();
        Messages ms = new Messages();

        IPEndPoint IP;
        Socket client;
        public Login()
        {
            InitializeComponent();
            Connect();
        }

        private void gunaTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string userName = txtAccount.Text.Trim();
            string password = txtPass.Text.Trim();

            Send("login");
            Chat chatFrm = new Chat();
            chatFrm.Show();
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbSignUp_Click(object sender, EventArgs e)
        {
            //new SignUp().Show();
            this.Hide();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            Connect();
        }

        #region

        bool Connect()
        {
            IP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), Convert.ToInt32("9999"));
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            try
            {
                client.Connect(IP);
                MessageBox.Show("Connect thành công");
            }
            catch
            {
                MessageBox.Show("Không kết nối được server");
                return false;
            }

            //tạo cái luồng để lắng nghe
            Thread listen = new Thread(Receive);
            listen.IsBackground = true;
            listen.Start();
            return true;
        }

        void Send(string action)
        {
            ms.action = action;

            //add data
            ms.user.UserName = txtAccount.Text;
            ms.user.Password = txtPass.Text;

            client.Send(cvt.Serialize(ms));
        }

        void Close()
        {
            client.Close();
        }

        void Receive()
        {
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 1000];
                    client.Receive(data);

                    Messages _ms = new Messages();


                    _ms = (Messages)cvt.Deserialize(data);

                    switch (_ms.action)
                    {
                        case "login":
                            if (_ms.text == "success")
                            {
                                ms.user = _ms.user;
                            }
                            else if (_ms.text == "logged in")
                                MessageBox.Show("Bạn đã đăng nhập vào hệ thống rồi, vui lòng không đăng nhập lại !!!");
                            else
                                MessageBox.Show("Đăng nhập thất bại! Tài khoản " + _ms.user.UserName + " không tồn tại! ");

                            break;

                        default:
                            break;

                    }
                }
            }
            catch
            {
                Close();
            }
        }
        #endregion


    }
}
