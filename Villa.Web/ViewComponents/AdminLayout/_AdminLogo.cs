using Microsoft.AspNetCore.Mvc;

namespace Villa.Web.ViewComponents.AdminLayout
{
    public class _AdminLogo : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
