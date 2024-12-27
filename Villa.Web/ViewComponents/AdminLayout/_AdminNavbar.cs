using Microsoft.AspNetCore.Mvc;

namespace Villa.Web.ViewComponents.AdminLayout
{
    public class _AdminNavbar : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
