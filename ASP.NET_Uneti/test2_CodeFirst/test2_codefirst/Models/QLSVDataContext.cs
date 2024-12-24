using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace test2_codefirst.Models
{
    public partial class QLSVDataContext : DbContext
    {
        public QLSVDataContext()
            : base("name=QLSVDataContext")
        {

        }

        public DbSet<SinhVien> SinhViens { get; set; }
        public DbSet<Diem> Diems { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<System.Data.Entity.ModelConfiguration.Conventions.PluralizingTableNameConvention>();
        }
    }
}
