using Microsoft.AspNetCore.Mvc;

namespace Villa.Web.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
