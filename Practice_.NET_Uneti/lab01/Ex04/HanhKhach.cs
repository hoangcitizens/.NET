using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04
{
    class HanhKhach : Nguoi
    {
        private int soLuong;
        // Thuộc tính
        public VeMayBay[] Ve { get; set; }
        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }

        // Hàm tạo
        public HanhKhach(string hoTen, string gioiTinh, int tuoi, int soLuong) : base(hoTen, gioiTinh, tuoi)
        {
            SoLuong = soLuong;
            Ve = new VeMayBay[SoLuong];
        }

        // Hàm hủy
        ~HanhKhach() { }
        // Phương thức nhập
        public void Nhap()
        {
            base.Nhap();
            Console.Write("Nhập số lượng vé: ");
            SoLuong = int.Parse(Console.ReadLine());
            Ve = new VeMayBay[SoLuong];

            for (int i = 0; i < SoLuong; i++)
            {
                Console.WriteLine($"Nhập vé máy bay cho hành khách thứ {i + 1}:");
                Ve[i] = new VeMayBay("", DateTime.Now, 0);
                Ve[i].Nhap();
            }
        }
        // Phương thức xuất
        public void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"Số lượng vé: {SoLuong}");
            foreach (var ve in Ve)
            {
                ve.Xuat();
            }
        }
        // Phương thức tính tổng tiền
        public double TongTien()
        {
            double tong = 0;
            foreach (var ve in Ve)
            {
                tong += ve.GetGiaVe();
            }
            return tong;
        }
    }
}
