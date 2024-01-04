using Microsoft.AspNetCore.Mvc;

namespace VKStudio.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
