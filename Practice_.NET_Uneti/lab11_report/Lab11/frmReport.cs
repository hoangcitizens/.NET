using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab11
{
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            Model1 model = new Model1();
            List<tbSinhVien> tbSinhViens = model.tbSinhViens.ToList();
            List<StudentReport> studentReports = new List<StudentReport>();
            foreach (tbSinhVien sv in tbSinhViens)
            {
                StudentReport temp = new StudentReport();
                temp.MaSV = sv.MaSV;
                temp.Ten = sv.Ten;
                temp.GioiTinh = sv.GioiTinh;
                temp.NgaySinh = sv.NgaySinh ?? DateTime.MinValue; // hoặc sử dụng cách 2
                temp.DiaChi = sv.DiaChi;

                studentReports.Add(temp);
            }

            reportViewer1.LocalReport.ReportPath = "Report1.rdlc";
            var source = new ReportDataSource("DataSet1",studentReports);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(source);
            this.reportViewer1.RefreshReport();
        }
    }
}
