using lab06_NguyenHuuHoang_1_11.App_Start;
using lab06_NguyenHuuHoang_1_11.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace lab06_NguyenHuuHoang_1_11
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            // khởi tạo bảng không có dữ liệu
            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<ShopDataContext>());
            Database.SetInitializer(new MyDbInitializer());

        }
    }
}
