using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04_Lab03
{
    class SinhVien
    {
        private string maSo;
        private string hoTen;
        private int namSinh;
        private string diaChi;
        private string lopHoc;
        public string MaSo
        {
            get { return maSo; }
            set { maSo = value; }
        }
        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }
        public int NamSinh
        {
            get { return namSinh; }
            set { namSinh = value; }
        }
        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        public string LopHoc
        {
            get { return lopHoc; }
            set { lopHoc = value; }
        }

        public SinhVien() { }
        public SinhVien(string maSo, string hoTen, int namSinh, string diaChi, string lopHoc)
        {
            MaSo = maSo;
            HoTen = hoTen;
            NamSinh = namSinh;
            DiaChi = diaChi;
            LopHoc = lopHoc;
        }

        public void XuatThongTin()
        {
            Console.WriteLine($"Mã số: {MaSo}, Họ tên: {HoTen}, Năm sinh: {NamSinh}, Địa chỉ: {DiaChi}, Lớp học: {LopHoc}");
        }
    }
}
