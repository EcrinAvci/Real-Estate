using Microsoft.AspNetCore.Mvc;

namespace Villa.Web.ViewComponents.AdminLayout
{
    public class _AdminSidebar : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
