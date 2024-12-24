using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace lab06_NguyenHuuHoang_1_11.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        [StringLength(30,MinimumLength = 2)]
        public string  Name { get; set; }
        // Thuộc tính điều hướng
        public virtual ICollection<Order> Orders { get; set; }
    }
}