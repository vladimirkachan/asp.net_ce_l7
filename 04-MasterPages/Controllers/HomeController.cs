using Microsoft.AspNetCore.Mvc;

namespace _04_MasterPages.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
