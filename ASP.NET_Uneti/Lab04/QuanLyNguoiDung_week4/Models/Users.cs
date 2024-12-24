using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QuanLyNguoiDung_week4.Models
{
    public class Users
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Tên bắt buộc phải nhập")]
        [StringLength(30,MinimumLength =2)]
        [DisplayName("Họ tên")]
        public string Name { get; set; }
        [Required] // bắt buộc phải nhập
        public string Address { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Nhập mật khẩu sai! Nhập lại")]
        [Compare("Password")]
        public string RenEnterPassword { get; set; }
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }
        [Required]
        //[Range(18,60)] // Nhập min = 16, max = 60
        [ReadOnly(true)] // chỉ đọc
        public int Age { get; set; }
        [Required]
        public bool Gender { get; set; }
    }
}