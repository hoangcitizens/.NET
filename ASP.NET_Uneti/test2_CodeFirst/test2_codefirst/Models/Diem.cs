using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace test2_codefirst.Models
{
    public class Diem
    {
        [Key,Column(Order = 0)]
        [Required]
        public int Masv { get; set; }
        [Key, Column(Order = 1)]
        [Required]

        public string Tenmh { get; set; }
        [Required]
        [Range(0,10)]
        public double Diemmh { get; set; }
        public virtual SinhVien SinhVien { get; set; }
    }
}