using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerApp
{
    public class Sach
    {
        public int maSach;
        public string tenSach;
        public double giaTien;

        public int sizeByte;

        public Sach()
        {

        }

        public Sach(int maSach, string tenSach, double giaTien)
        {
            this.maSach = maSach;
            this.tenSach = tenSach;
            this.giaTien = giaTien;
        }

        public Sach(byte[] data)
        {
            int i = 0;

            // Lấy thông tin sách từ mảng Byte

            // Lấy dữ liệu mã sách
            maSach = BitConverter.ToInt32(data, i);
            i += 4;

            // Lấy dữ liệu độ dài tên sách
            int lengthTenSach = BitConverter.ToInt32(data, i);
            i += 4;

            // Lấy dữ liệu tên sách
            tenSach = Encoding.ASCII.GetString(data, i, lengthTenSach);
            i += lengthTenSach;

            // Lấy dữ liệu giá tiền
            giaTien = BitConverter.ToDouble(data, i);
            i += 8;

            sizeByte = i;
        }

        public void XuatThongTinSach()
        {
            Console.WriteLine($"{maSach} {tenSach} {giaTien}"); // 1 abc 5.23
        }

        public override string ToString()
        {
            return $"{maSach} {tenSach} {giaTien}";
        }

        public byte[] GetBytes()
        {
            byte[] data = new byte[1024];
            int i = 0;

            // VD: 1 abc 5.2

            // Chuyển đổi mã sách (int)
            Buffer.BlockCopy(BitConverter.GetBytes(maSach), 0, data, i, 4);
            i += 4;

            // Chuyển đổi độ dài tên sách (int)
            Buffer.BlockCopy(BitConverter.GetBytes(tenSach.Length), 0, data, i, 4);
            i += 4;

            // Chuyển đổi tên sách (string)
            Buffer.BlockCopy(Encoding.ASCII.GetBytes(tenSach), 0, data, i, tenSach.Length);
            i += tenSach.Length;

            // Chuyển đổi giá tiền (double)
            Buffer.BlockCopy(BitConverter.GetBytes(giaTien), 0, data, i, 8);
            i += 8;

            sizeByte = i;

            return data;
        }
    }
}
