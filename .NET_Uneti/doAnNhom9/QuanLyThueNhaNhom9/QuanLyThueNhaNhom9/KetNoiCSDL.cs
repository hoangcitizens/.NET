using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyThueNhaNhom9
{
    internal class KetNoiCSDL
    {
        SqlConnection con = new SqlConnection($@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={Application.StartupPath}\QuanLyThueNha.mdf;Integrated Security=True;Connect Timeout=30");
        public SqlConnection getCon()
        {
            return con;
        }
    }
}
