using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lab06_NguyenHuuHoang_1_11.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        // Thuộc tính khóa ngoài
        public int CustomerId { get; set; }
        // Thuộc tính điều hướng
        public virtual Customer Customer { get; set; }
    }
}