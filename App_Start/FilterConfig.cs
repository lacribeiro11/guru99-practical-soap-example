using System.Web;
using System.Web.Mvc;

namespace Guru99_Practical_SOAP_Example
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
