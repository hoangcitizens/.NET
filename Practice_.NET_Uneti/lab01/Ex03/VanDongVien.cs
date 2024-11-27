using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03
{
    class VanDongVien
    {
        private string hoTen;
        private int tuoi;
        private string monThiDau;
        private double canNang;
        private double chieuCao;

        public VanDongVien() { }

        public VanDongVien(string hoTen, int tuoi, string monThiDau, double canNang, double chieuCao)
        {
            this.hoTen = hoTen;
            this.tuoi = tuoi;
            this.monThiDau = monThiDau;
            this.canNang = canNang;
            this.chieuCao = chieuCao;
        }
        
        // Phương thức hủy
        ~VanDongVien() { }

        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }
        public int Tuoi
        {
            get { return tuoi; }
            set { tuoi = value; }
        }
        public string MonThiDau
        {
            get { return monThiDau; }
            set { monThiDau = value; }
        }
        public double CanNang
        {
            get { return canNang; }
            set
            {
                canNang = value;
            }
        }
        public double ChieuCao
        {
            get { return chieuCao; }
            set
            {
                chieuCao = value;
            }
        }
        // Phương thức hiển thị thông tin
        public void ShowInfo()
        {
            Console.WriteLine($"Họ tên: {HoTen}, Tuổi: {Tuoi}, Môn thi đấu: {MonThiDau}, Cân nặng: {CanNang}, Chiều cao: {ChieuCao}");
        }
    }
}
