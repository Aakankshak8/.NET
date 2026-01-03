using Microsoft.AspNetCore.Mvc;

namespace _11Day_BasicMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
