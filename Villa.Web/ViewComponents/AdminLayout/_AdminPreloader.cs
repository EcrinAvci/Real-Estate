using Microsoft.AspNetCore.Mvc;

namespace Villa.Web.ViewComponents.AdminLayout
{
    public class _AdminPreloader : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
