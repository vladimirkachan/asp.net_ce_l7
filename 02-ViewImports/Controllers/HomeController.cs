using Microsoft.AspNetCore.Mvc;

namespace _02_ViewImports.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Year()
        {
            return View();
        }
        public IActionResult Month()
        {
            return View();
        }
        public IActionResult Day()
        {
            return View();
        }
    }
}
