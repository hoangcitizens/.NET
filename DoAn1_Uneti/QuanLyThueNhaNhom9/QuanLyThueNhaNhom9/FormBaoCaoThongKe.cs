using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThueNhaNhom9
{
    public partial class FormBaoCaoThongKe : Form
    {
        SqlConnection conn = new KetNoiCSDL().getCon();
        DataTable dt = new DataTable();
        public FormBaoCaoThongKe()
        {
            InitializeComponent();
        }

        private void FormBaoCaoThongKe_Load(object sender, EventArgs e)
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand(@"Select * from QuanLy", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
         
            //this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("ThongKeDanhSachHopDong", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            this.reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            this.reportViewer1.LocalReport.ReportPath = "Report1.rdlc";
            // tạo nguồn dữ liệu báo cáo
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = dt;
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
    }
}
