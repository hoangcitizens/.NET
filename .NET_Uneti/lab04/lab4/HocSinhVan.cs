using lab4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public class HocSinhVan : HocSinh
    {
        private double diemvanchuyen;
        public HocSinhVan() : base()
        {
            diemvanchuyen = 0;
        }
        public HocSinhVan(string hoten, int namsinh, double diemvan, double diemtoan, double diemvanchuyen) : base(hoten,namsinh,diemvan,diemtoan)
        {
            this.diemvanchuyen = diemvanchuyen;
        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine($"Điểm văn chuyên: {diemvanchuyen}");
        }
        public override void nhap()
        {
            base.nhap();
            Console.Write("Mời nhập điểm văn chuyên: ");
            diemvanchuyen = double.Parse(Console.ReadLine());   
        }
        public override double TinhDiemTrungBinh()
        {
            return (diemvan*2 + diemtoan) / 3;
        }
    }
}
