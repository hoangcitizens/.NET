using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace week3_NguyenHuuHoang.Models
{
    
    public class Users
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string  Address { get; set; }
        public Address UserAddress { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool Gender { get; set; }
        
    }
    public enum Address {  
        
        ThaiBinh, Hanoi, TpHoChiMinh, HaiPhong, QuangNinh, DaNang
    }
}