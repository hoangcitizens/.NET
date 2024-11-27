using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04_Lab03
{
    class QuanLySinhVien
    {
        private ArrayList danhSachSinhVien = new ArrayList();

        // a. Thêm sinh viên
        public void ThemSinhVien(SinhVien sv)
        {
            danhSachSinhVien.Add(sv);
            Console.WriteLine("Đã thêm sinh viên thành công!");
        }

        // a. Sửa thông tin sinh viên
        public void SuaSinhVien(string maSo)
        {
            SinhVien sinhVien = (SinhVien)danhSachSinhVien.Cast<SinhVien>().FirstOrDefault(sv => sv.MaSo == maSo);
            if (sinhVien != null)
            {
                Console.Write("Nhập họ tên mới: ");
                sinhVien.HoTen = Console.ReadLine();
                Console.Write("Nhập năm sinh mới: ");
                sinhVien.NamSinh = int.Parse(Console.ReadLine());
                Console.Write("Nhập địa chỉ mới: ");
                sinhVien.DiaChi = Console.ReadLine();
                Console.Write("Nhập lớp học mới: ");
                sinhVien.LopHoc = Console.ReadLine();
                Console.WriteLine("Đã cập nhật thông tin sinh viên.");
            }
            else
            {
                Console.WriteLine("Không tìm thấy sinh viên với mã số này.");
            }
        }

        // a. Xóa sinh viên
        public void XoaSinhVien(string maSo)
        {
            SinhVien sinhVien = (SinhVien)danhSachSinhVien.Cast<SinhVien>().FirstOrDefault(sv => sv.MaSo == maSo);
            if (sinhVien != null)
            {
                danhSachSinhVien.Remove(sinhVien);
                Console.WriteLine("Đã xóa sinh viên.");
            }
            else
            {
                Console.WriteLine("Không tìm thấy sinh viên với mã số này.");
            }
        }

        // b. Xuất số lượng sinh viên
        public void XuatSoLuongSinhVien()
        {
            Console.WriteLine($"Số lượng sinh viên: {danhSachSinhVien.Count}");
        }

        // c. Xuất danh sách sinh viên thuộc một lớp học
        public void XuatSinhVienTheoLop(string lopHoc)
        {
            var svTheoLop = danhSachSinhVien.Cast<SinhVien>().Where(sv => sv.LopHoc == lopHoc).ToList();
            if (svTheoLop.Count > 0)
            {
                Console.WriteLine($"Danh sách sinh viên thuộc lớp {lopHoc}:");
                foreach (SinhVien sv in svTheoLop)
                {
                    sv.XuatThongTin();
                }
            }
            else
            {
                Console.WriteLine($"Không có sinh viên nào thuộc lớp {lopHoc}.");
            }
        }
    }
}
