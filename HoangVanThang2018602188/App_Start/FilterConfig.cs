using System.Web;
using System.Web.Mvc;

namespace HoangVanThang2018602188
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
