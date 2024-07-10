using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    public class SinhVien
    {
        string maSV;
        string hoTen;
        DateTime ngaySinh;
        string gioiTinh;
        string diaChi;
        string email;
        string soDienThoai;

        public SinhVien()
        {
            maSV = "Unknown";
            hoTen = "Unknown";
            ngaySinh = DateTime.MinValue;
            gioiTinh = "Unknown";
            diaChi = "Unknown";
            email = "Unknown";
            soDienThoai = "Unknown";
        }
        public SinhVien(string maSV, string hoTen, DateTime ngaySinh, string gioiTinh,
            string diaChi, string email, string soDienThoai)
        {
            this.maSV = maSV;
            this.hoTen = hoTen;
            this.ngaySinh = ngaySinh;
            this.gioiTinh = gioiTinh;
            this.diaChi = diaChi;
            this.email = email;
            this.soDienThoai = soDienThoai;
        }
        public string MaSV
            { get { return maSV; } set { maSV = value; } }
        public string HoTen
            { get { return hoTen; } set { hoTen = value; } }
        public DateTime NgaySinh
            { get { return ngaySinh; } set { ngaySinh = value; } }
        public string GioiTinh
            { get { return gioiTinh; } set { gioiTinh = value; } }
        public string DiaChi
            { get { return diaChi; } set { diaChi = value; } }
        public string Email
            { get { return email; } set { email = value; } }
        public string SoDienThoai
            { get { return soDienThoai; } set { soDienThoai = value; } }
    }
}
