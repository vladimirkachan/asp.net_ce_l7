using Microsoft.AspNetCore.Mvc;

namespace _05_PartialViews.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
