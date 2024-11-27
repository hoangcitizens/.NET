using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Ex05
{
    public class SinhVienKhoaCoKhi : SinhVien
    {
        // Thuộc tính bổ sung
        public double DiemVeKyThuat { get; set; }
        public double DiemCNC { get; set; }

        public SinhVienKhoaCoKhi(string maSinhVien, string hoTen, string queQuan, int namSinh, double diemVeKyThuat, double diemCNC)
            : base(maSinhVien, hoTen, queQuan, namSinh)
        {
            DiemVeKyThuat = diemVeKyThuat;
            DiemCNC = diemCNC;
        }

        public override void HienThi()
        {
            base.HienThi();
            Console.WriteLine($"Diem Ve Ky Thuat: {DiemVeKyThuat}, Diem CNC: {DiemCNC}");
        }

        public double TinhDiemTB()
        {
            return (DiemVeKyThuat + DiemCNC) / 2;
        }
    }
}
