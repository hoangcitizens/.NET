using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04
{
    class Nguoi
    {
        private string hoTen;
        private string gioiTinh;
        private int tuoi;

        public Nguoi() { }
        public Nguoi(string hoTen, string gioiTinh, int tuoi)
        {
            this.hoTen = hoTen;
            this.gioiTinh = gioiTinh;
            this.tuoi = tuoi;
        }
        ~Nguoi() { }
        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }
        public string GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }
        public int Tuoi
        {
            get { return tuoi; }
            set
            {
                tuoi = value;
            }
        }

        // Phương thức nhập
        public void Nhap()
        {
            Console.Write("Nhập họ tên: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhập giới tính: ");
            GioiTinh = Console.ReadLine();
            Console.Write("Nhập tuổi: ");
            Tuoi = int.Parse(Console.ReadLine());
        }

        // Phương thức xuất
        public void Xuat()
        {
            Console.WriteLine($"Họ tên: {HoTen}, Giới tính: {GioiTinh}, Tuổi: {Tuoi}");
        }
    }
}
