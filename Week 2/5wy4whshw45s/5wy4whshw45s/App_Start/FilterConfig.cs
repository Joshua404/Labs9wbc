using System.Web;
using System.Web.Mvc;

namespace _5wy4whshw45s
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
