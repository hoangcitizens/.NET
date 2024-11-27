using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Ex04
{
    [Serializable] // Đánh dấu lớp có thể được tuần tự hóa để lưu vào tệp nhị phân
    class SinhVien
    {
        public string MaSV { get; set; }
        public string HoTen { get; set; }
        public int NamSinh { get; set; }

        // Hiển thị thông tin sinh viên
        public void HienThiThongTin()
        {
            Console.WriteLine($"Mã SV: {MaSV}, Họ Tên: {HoTen}, Năm Sinh: {NamSinh}");
        }
    }

    internal class Ex04
    {
        // Hàm nhập danh sách sinh viên từ người dùng
        static List<SinhVien> NhapDanhSachSinhVien()
        {
            List<SinhVien> danhSachSinhVien = new List<SinhVien>();
            Console.Write("Nhập số lượng sinh viên: ");
            int soLuong = int.Parse(Console.ReadLine());

            for (int i = 0; i < soLuong; i++)
            {
                SinhVien sv = new SinhVien();

                Console.WriteLine($"Nhập thông tin sinh viên thứ {i + 1}:");
                Console.Write("Mã SV: ");
                sv.MaSV = Console.ReadLine();

                Console.Write("Họ tên: ");
                sv.HoTen = Console.ReadLine();

                Console.Write("Năm sinh: ");
                sv.NamSinh = int.Parse(Console.ReadLine());

                danhSachSinhVien.Add(sv);
            }

            return danhSachSinhVien;
        }

        // Hàm lưu danh sách sinh viên vào tệp nhị phân
        static void LuuDanhSachVaoTep(string fileName, List<SinhVien> danhSachSinhVien)
        {
            using (FileStream fs = new FileStream(fileName, FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, danhSachSinhVien);
            }
            Console.WriteLine("Danh sách sinh viên đã được lưu vào tệp nhị phân.");
        }

        // Hàm đọc danh sách sinh viên từ tệp nhị phân
        static List<SinhVien> DocDanhSachTuTep(string fileName)
        {
            if (!File.Exists(fileName))
            {
                Console.WriteLine("Tệp không tồn tại.");
                return null;
            }

            using (FileStream fs = new FileStream(fileName, FileMode.Open))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                return (List<SinhVien>)formatter.Deserialize(fs);
            }
        }

        // Hiển thị danh sách sinh viên
        static void HienThiDanhSachSinhVien(List<SinhVien> danhSachSinhVien)
        {
            Console.WriteLine("Danh sách sinh viên:");
            foreach (SinhVien sv in danhSachSinhVien)
            {
                sv.HienThiThongTin();
            }
        }
        static void Main(string[] args)
        {
            try
            {
                // Nhập danh sách sinh viên
                List<SinhVien> danhSachSinhVien = NhapDanhSachSinhVien();

                // Nhập tên tệp để lưu danh sách
                Console.Write("Nhập tên tệp để lưu danh sách sinh viên: ");
                string fileName = Console.ReadLine();

                // Lưu danh sách sinh viên vào tệp nhị phân
                LuuDanhSachVaoTep(fileName, danhSachSinhVien);

                // Đọc danh sách sinh viên từ tệp nhị phân và hiển thị
                List<SinhVien> danhSachDaDoc = DocDanhSachTuTep(fileName);
                if (danhSachDaDoc != null)
                {
                    HienThiDanhSachSinhVien(danhSachDaDoc);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Đã xảy ra lỗi: " + ex.Message);
            }
        }
    }
}
