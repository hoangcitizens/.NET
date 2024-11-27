using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02_Abstract
{
    abstract class NhanVien
    {
        public string HoTen;
        public int Tuoi;
        public string GioiTinh;
        public abstract string ChucVu();
        public abstract void CongViec();

    }
}
