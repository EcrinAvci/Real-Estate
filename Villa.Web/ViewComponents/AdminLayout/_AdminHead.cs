using Microsoft.AspNetCore.Mvc;

namespace Villa.Web.ViewComponents.AdminLayout
{
    public class _AdminHead : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
