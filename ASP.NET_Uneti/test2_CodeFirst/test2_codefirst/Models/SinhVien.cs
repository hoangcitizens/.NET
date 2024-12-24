using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace test2_codefirst.Models
{
    public class SinhVien
    {
        [Key]
        [Required]
        public int Masv { get; set; }
        [Required]
        [StringLength(50,MinimumLength = 4)]
        public string Hoten { get; set; }
        [Required]

        public string Gioitinh { get; set; }
        [Required]
        [Range(2000,2006)]
        public int Namsinh { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public virtual ICollection<Diem> Diems { get; set; }
    }
}