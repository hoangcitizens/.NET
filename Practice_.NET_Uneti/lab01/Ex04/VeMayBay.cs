using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04
{
    class VeMayBay
    {
        private string tenChuyen;
        private DateTime ngayBay;
        private double giaVe;

        // Thuộc tính
        public string TenChuyen 
        {
            get { return tenChuyen; }
            set { tenChuyen = value; }
        }
        public DateTime NgayBay 
        { 
            get { return ngayBay; }
            set { ngayBay = value; }
        }
        public double GiaVe 
        { 
            get { return giaVe; }
            set
            {
                giaVe = value;
            }

        }
        public VeMayBay() { }
        // Hàm tạo
        public VeMayBay(string tenChuyen, DateTime ngayBay, double giaVe)
        {
            this.tenChuyen = tenChuyen;
            this.ngayBay = ngayBay;
            this.giaVe = giaVe;
        }
       
        // Hàm hủy
        ~VeMayBay() { }

        // Phương thức nhập
        public void Nhap()
        {
            Console.Write("Nhập tên chuyến bay: ");
            TenChuyen = Console.ReadLine();
            Console.Write("Nhập ngày bay (dd/MM/yyyy): ");
            NgayBay = DateTime.Parse(Console.ReadLine());
            Console.Write("Nhập giá vé: ");
            GiaVe = double.Parse(Console.ReadLine());
        }

        // Phương thức xuất
        public void Xuat()
        {
            Console.WriteLine($"Tên chuyến: {TenChuyen}, Ngày bay: {NgayBay.ToShortDateString()}, Giá vé: {GiaVe}");
        }

        // Hàm trả về giá vé
        public double GetGiaVe()
        {
            return GiaVe;
        }
    }
}
