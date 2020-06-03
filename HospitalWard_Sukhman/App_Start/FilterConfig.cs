using System.Web;
using System.Web.Mvc;

namespace HospitalWard_Sukhman
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
