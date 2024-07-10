using lab4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public class HocSinhToan : HocSinh
    {
        private double diemtoanchuyen;
        public HocSinhToan() : base()
        {
            diemtoanchuyen = 0;
        }
        public HocSinhToan(string hoten, int namsinh, double diemvan, double diemtoan, double diemtoanchuyen) : base(hoten, namsinh, diemvan, diemtoan)
        {
            this.diemtoanchuyen = diemtoanchuyen;
        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine($"Điểm toán chuyên: {diemtoanchuyen}");
        }
        public override void nhap()
        {
            base.nhap();
            Console.Write("Mời nhập điểm toán chuyên: ");
            diemtoanchuyen = double.Parse(Console.ReadLine());
        }
        public override double TinhDiemTrungBinh()
        {
            return (diemvan + diemtoan*2) / 3;
        }
    }
}
