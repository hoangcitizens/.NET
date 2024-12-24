using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab08_NguyenHuuHoang_DHTI15A5HN_15_11.Models
{
    public class BookByCategory
    {
        public string CategoryName { get; set; }
        public string BookCount { get; set; }
        public Nullable<decimal> PriceSum { get; set; }
    }
}