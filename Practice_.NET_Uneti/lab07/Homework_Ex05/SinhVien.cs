using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Ex05
{
    public class SinhVien
    {
        // Thuộc tính
        public string MaSinhVien { get; set; }
        public string HoTen { get; set; }
        public string QueQuan { get; set; }
        public int NamSinh { get; set; }

        public SinhVien(string maSinhVien, string hoTen, string queQuan, int namSinh)
        {
            MaSinhVien = maSinhVien;
            HoTen = hoTen;
            QueQuan = queQuan;
            NamSinh = namSinh;
        }

        public virtual void HienThi()
        {
            Console.WriteLine($"{MaSinhVien} - {HoTen} - {QueQuan} - {NamSinh}");
        }
    }
}
