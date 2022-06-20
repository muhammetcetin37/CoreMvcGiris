using Microsoft.AspNetCore.Mvc;

namespace CoreEmpty6._0.Controllers
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
        public IActionResult About()
        {
            return View();
        }
    }
}
