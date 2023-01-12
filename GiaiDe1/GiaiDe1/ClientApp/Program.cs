using ServerApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp
{
    public class Program
    {
        static void Main(string[] args)
        {
			try
			{
                // Khởi tạo Client
                TcpClient client = new TcpClient("127.0.0.1", 5000);
                NetworkStream networkStream = client.GetStream();

                byte[] data = new byte[1024];
                int size;

                bool tiepTucNhap = false;

                do
                {
                    Sach sach = new Sach();

                    // Nhập mã sách
                    Console.Write("Nhap ma sach: ");
                    sach.maSach = Convert.ToInt32(Console.ReadLine());

                    // Nhập tên sách
                    Console.Write("Nhap ten sach: ");
                    sach.tenSach = Console.ReadLine();

                    // Nhập giá tiền
                    Console.Write("Nhap gia tien: ");
                    sach.giaTien = Convert.ToDouble(Console.ReadLine());

                    data = sach.GetBytes();
                    size = sach.sizeByte;

                    networkStream.Write(data, 0, size);

                    // Xóa bộ đệm
                    networkStream.Flush();

                    // Hỏi người dùng có muốn nhập tiếp không?
                    Console.Write("Co nhap tiep khong? Tra loi \"khong\" de thoat! ");

                    // Kiểm tra người dùng có muốn nhập tiếp không
                    if (Console.ReadLine().ToLower() == "khong")
                        tiepTucNhap = false;
                    else
                        tiepTucNhap = true;

                    // tiepTucNhap = Console.ReadLine() == "khong";

                } while (tiepTucNhap == true);

                // Đóng kết nối
                networkStream.Close();
                client.Close();
            }
			catch (Exception)
			{
                Console.WriteLine("Khong the ket noi toi Server!");
			}
        }
    }
}
