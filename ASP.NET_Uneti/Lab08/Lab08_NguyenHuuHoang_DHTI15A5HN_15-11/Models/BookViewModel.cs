using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab08_NguyenHuuHoang_DHTI15A5HN_15_11.Models
{
    public class BookViewModel
    {
        [Key]
        public string Title { get; set; }
        public Nullable<decimal> Price { get; set; }
    }
}