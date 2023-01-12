using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace ServerApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Khởi tạo Server
            TcpListener server = new TcpListener(IPAddress.Any, 5000);
            server.Start();
            Console.WriteLine("Da chay Server!");

            // Chờ Client kết nối
            TcpClient client = server.AcceptTcpClient();
            NetworkStream networkStream = client.GetStream();

            // Khai báo đối tượng danh sách chứa các đối tượng Sách
            List<Sach> dsSach = new List<Sach>();

            byte[] data = new byte[1024];
            int size;

            while ((size = networkStream.Read(data, 0, data.Length)) != 0)
            {
                Console.WriteLine("Kich thuoc goi tin nhan duoc tu Client: " + size.ToString());

                // Tạo đối tượng Sách từ mảng Byte nhận được từ Client
                Sach sach = new Sach(data);
                sach.XuatThongTinSach();

                // Thêm sách vào DS sách
                dsSach.Add(sach);

                // Xóa bộ đệm
                networkStream.Flush();
            }

            // Đóng kết nối
            networkStream.Close();
            client.Close();
            server.Stop();

            // Ghi thông tin tất cả sách vào file ThongTinSach.txt
            GhiThongTinTatCaSachVaoFileTXT("D:\\Studies\\LapTrinhMang\\OnTap\\GiaiDe1\\ThongTinSach.txt", dsSach);
        }

        static void GhiThongTinTatCaSachVaoFileTXT(string tenFile, List<Sach> dsSach)
        {
            if (tenFile != "" && dsSach.Count > 0)
            {
                StreamWriter streamWriter = new StreamWriter(tenFile);

                foreach (Sach sach in dsSach)
                {
                    streamWriter.WriteLine(sach);
                    streamWriter.Flush();
                }
            }
        }
    }
}
