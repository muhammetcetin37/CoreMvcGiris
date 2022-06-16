using Microsoft.AspNetCore.Mvc;

namespace CoreMvcGiris.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Hakkimizda()
        {
            return View();
        }

        public IActionResult Referanslar()
        {
            return View();
        }
    }
}
