using Microsoft.AspNetCore.Mvc;

namespace Villa.Web.ViewComponents.AdminLayout
{
    public class _AdminFooter :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
