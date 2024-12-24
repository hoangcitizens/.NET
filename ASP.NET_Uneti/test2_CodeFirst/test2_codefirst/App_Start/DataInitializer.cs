using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using test2_codefirst.Models;

namespace test2_codefirst.App_Start
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<QLSVDataContext>
    {
        protected override void Seed(QLSVDataContext context)
        {
            context.SinhViens.Add(new SinhVien { Masv = 1, Hoten = "Nguyễn Đặng Tân", Namsinh = 2002, Gioitinh = "Nam", Email = "dat@gmail.com" });
            context.SinhViens.Add(new SinhVien { Masv = 2, Hoten = "Đặng Anh Văn", Namsinh = 2003, Gioitinh = "Nam", Email = "van@gmail.com" });
            context.SinhViens.Add(new SinhVien { Masv = 3, Hoten = "Vũ Anh Tuấn", Namsinh = 2001, Gioitinh = "Nam", Email = "tuan@gmail.com" });
            context.SaveChanges();

            context.Diems.Add(new Diem { Masv = 1, Tenmh = "Cơ sở dữ liệu", Diemmh = 9.0});
            context.Diems.Add(new Diem { Masv = 1, Tenmh = "Kỹ thuật lập trình", Diemmh = 9.4 });
            context.Diems.Add(new Diem { Masv = 2, Tenmh = "Cơ sở dữ liệu", Diemmh = 6.0 });
            context.Diems.Add(new Diem { Masv = 2, Tenmh = "Kỹ thuật lập trình", Diemmh = 6.4 });
            context.Diems.Add(new Diem { Masv = 3, Tenmh = "Cơ sở dữ liệu", Diemmh = 8.0 });
            context.Diems.Add(new Diem { Masv = 3, Tenmh = "Kỹ thuật lập trình", Diemmh = 8.4 });

            base.Seed(context);
        }
    }
}