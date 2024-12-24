using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using lab06_NguyenHuuHoang_1_11.Models;

namespace lab06_NguyenHuuHoang_1_11.App_Start
{
    public class MyDbInitializer : DropCreateDatabaseIfModelChanges<ShopDataContext>
    {      
        protected override void Seed(ShopDataContext context)
        {
            context.Customers.Add(new Customer { CustomerId = 1, Name = "Hoàng" });
            context.Customers.Add(new Customer { CustomerId = 2, Name = "Long" });
            context.Customers.Add(new Customer { CustomerId = 3, Name = "Linh" });
            context.SaveChanges();
            context.Orders.Add(new Order { CustomerId = 1, ProductName = "Bánh mỳ", Price = 20000, Quantity = 5 });
            context.Orders.Add(new Order { CustomerId = 2, ProductName = "Cafe", Price = 15000, Quantity = 10 });
            context.Orders.Add(new Order { CustomerId = 3, ProductName = "Mỳ tôm", Price = 5000, Quantity = 4 });
            context.SaveChanges();
            base.Seed(context);
        }
    }
}