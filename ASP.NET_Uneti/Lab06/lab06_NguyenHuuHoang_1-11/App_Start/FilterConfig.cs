using System.Web;
using System.Web.Mvc;

namespace lab06_NguyenHuuHoang_1_11
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
