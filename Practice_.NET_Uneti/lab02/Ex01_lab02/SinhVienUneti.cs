using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01_lab02
{
    // Lớp trừu tượng SinhVienUneti
    public abstract class SinhVienUneti
    {
        private string hoTen;
        private string nganh;
        // Thuộc tính họ tên và ngành
        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }
        public string Nganh
        {
            get { return nganh; }
            set { nganh = value; }
        }

        // Constructor để khởi tạo giá trị cho thuộc tính
        public SinhVienUneti(string hoTen, string nganh)
        {
            HoTen = hoTen;
            Nganh = nganh;
        }

        // Phương thức trừu tượng để lấy điểm
        public abstract double GetDiem();

        // Phương thức xếp loại học lực dựa trên điểm
        public string GetXepLoaiHL()
        {
            double diem = GetDiem();
            if (diem >= 8)
                return "Giỏi";
            else if (diem >= 6.5)
                return "Khá";
            else if (diem >= 5)
                return "Trung bình";
            else
                return "Yếu";
        }

        // Phương thức xuất thông tin sinh viên
        public void Xuat()
        {
            Console.WriteLine("Họ tên: " + HoTen);
            Console.WriteLine("Ngành: " + Nganh);
            Console.WriteLine("Điểm: " + GetDiem());
            Console.WriteLine("Xếp loại học lực: " + GetXepLoaiHL());
        }
    }
}
