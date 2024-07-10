using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenHuuHoang_week5
{
    public class TaiKhoan
    {
        public delegate void MoneyChangedHandler(string s); // tạo delegate
        public event MoneyChangedHandler WithdrewMoney; // tạo event liên kết tới delegate
        public event MoneyChangedHandler TransferredMoney;
        private string fullName; // Họ và tên chủ thẻ
        private int soTaiKhoan; // Số tài khoản
        private int soDu; // Số dư
        public TaiKhoan()
        {
            fullName = "Unknown";
            soTaiKhoan = 0;  
            soDu = 0;
        }
        public TaiKhoan(string fullName, int soTaiKhoan, int soDu)
        {
            this.fullName = fullName;
            this.soTaiKhoan = soTaiKhoan;          
            this.soDu = soDu;
        }
        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }
        public int SoTaiKhoan
        {
            get { return soTaiKhoan; }
            set { soTaiKhoan = value; }
        }
        public int SoDu
        {
            get { return soDu; }
            set { soDu = value; }
        }    
        protected virtual void RunWithdrewMoney(string s)
        {
            if (WithdrewMoney != null)
            {
                WithdrewMoney(s);
            }
        }
        protected virtual void RunTransferredMoney(string s)
        {          
            if (TransferredMoney != null)
            {
                TransferredMoney(s);
            }    
        } 
        public void rutTien(int soTienCanRut)
        {
            if (soTienCanRut <= soDu)
            {
                soDu -= soTienCanRut;
            
                RunWithdrewMoney($"{soTienCanRut,-18} {DateTime.Now,-25} {soDu,-18} VNĐ " +
                    $"\n\n(!) Đã rút {soTienCanRut} VNĐ từ tài khoản {SoTaiKhoan} vào lúc {DateTime.Now}. " +
                    $"Số dư hiện tại: {SoDu} \n ");              
            }
            else
            {
                Console.WriteLine("\n\n(!) Số dư không đủ để thực hiện giao dịch rút tiền.");
            }
        }
        public void chuyenKhoan(int soTienCanChuyen, TaiKhoan taiKhoanThuHuong)
        {
            if(soTienCanChuyen <= SoDu)
            {
                SoDu -= soTienCanChuyen;
                taiKhoanThuHuong.SoDu += soTienCanChuyen;
                RunTransferredMoney($"{soTienCanChuyen,-18} {DateTime.Now,-25} {soDu,-18} {taiKhoanThuHuong.SoDu,-19} VNĐ" +
                    $"\n\n(!) Đã chuyển {soTienCanChuyen} VNĐ từ tài khoản {SoTaiKhoan} tới tài khoản " +
                    $"{taiKhoanThuHuong.SoTaiKhoan} vào lúc {DateTime.Now}. Số dư hiện tại: {SoDu} VNĐ");
            }
            else
            {
                Console.WriteLine("\n\n(!) Số dư không đủ để thực hiện giao dịch chuyển khoản.");
            }
        }
    }
}
