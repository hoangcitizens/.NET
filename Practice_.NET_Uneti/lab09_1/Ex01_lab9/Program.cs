using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex01_lab9
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Yc1_FrmKhachHang());
            //Application.Run(new Yc2_FrmMatHang());
            //Application.Run(new Yc3_FrmBanHang());
            //Application.Run(new Yc4a_FrmTimKiemKH());
            Application.Run(new FrmMain());
        }
    }
}
