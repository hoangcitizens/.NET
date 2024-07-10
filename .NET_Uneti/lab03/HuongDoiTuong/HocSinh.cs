using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuongDoiTuong
{
    internal class HocSinh
    {
        // khai báo biến thành viên
        private string hoten; // private giới hạn chỉ trong class HocSinh truy xuất được
        protected int namsinh; // protected giới hạn chỉ lớp con và trong lớp HocSinh truy xuất được
        internal double diemvan; // internal chỉ trong cùng project 
        public double diemtoan; 
        // khai báo hàm thành viên
        public HocSinh()
        {
            hoten = "";
            namsinh = 2006;
            diemvan = 0;
            diemtoan = 0;
        }    
        public HocSinh(string hoten, int namsinh, double diemvan, double diemtoan)
        {
            this.hoten = hoten; // this phân biệt giữa tên biến và tham số
            this.namsinh = namsinh;
            this.diemvan = diemvan;
            this.diemtoan = diemtoan;
        }
        public HocSinh(HocSinh hs)
        {
            this.hoten = hs.hoten;
            this.namsinh = hs.namsinh;
            this.diemvan = hs.diemvan;
            this.diemtoan = hs.diemtoan;
        }
        public void nhap()
        {
            Console.Write("Mời nhập họ và tên: ");
            hoten = Console.ReadLine();
            Console.Write("Mời nhập năm sinh: ");
            namsinh = int.Parse(Console.ReadLine());
            Console.Write("Mời nhập điểm văn: ");
            diemvan = double.Parse(Console.ReadLine());
            Console.Write("Mời nhập điểm văn: ");
            diemtoan = double.Parse(Console.ReadLine());
        }
        public void xuat()
        {
            Console.WriteLine($"Họ tên: {hoten}, Năm sinh: {namsinh}, Điểm văn: {diemvan}, Điểm toán: {diemtoan}");
        }
    }
}
