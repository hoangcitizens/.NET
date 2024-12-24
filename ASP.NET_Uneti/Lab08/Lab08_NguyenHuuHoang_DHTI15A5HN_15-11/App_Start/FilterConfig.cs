using System.Web;
using System.Web.Mvc;

namespace Lab08_NguyenHuuHoang_DHTI15A5HN_15_11
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
