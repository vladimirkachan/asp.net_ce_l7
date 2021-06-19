using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace _03_ViewDataBag.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["1"] = "one";
            ViewData["2"] = "two";
            ViewData["3"] = "three";
            ViewData["4"] = "four";
            ViewData["5"] = "five";
            ViewBag.FirstName = "VovA";
            ViewBag.LastName = "Kachan";
            return View();
        }
    }
}
