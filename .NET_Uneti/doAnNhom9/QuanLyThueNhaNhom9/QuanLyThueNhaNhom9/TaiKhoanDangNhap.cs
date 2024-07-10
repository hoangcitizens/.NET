using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThueNhaNhom9
{
    internal class TaiKhoanDangNhap
    {
        private string taiKhoan;
        private string matKhau;

        public TaiKhoanDangNhap()
        {
        }
        public TaiKhoanDangNhap(string taiKhoan, string matKhau)
        {
            this.taiKhoan = taiKhoan;
            this.matKhau = matKhau;
        }
        public bool DangNhap(string username,string password)
        {
            if (username == this.taiKhoan || password == this.matKhau)
                return true;
            else
                return false;
        }
    }
}
