using System.Web;
using System.Web.Mvc;

namespace ClientesContatosEndereco
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
