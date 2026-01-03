using Microsoft.AspNetCore.Mvc;

namespace _12Day_ConventionalRouting.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult<int> sum(int a ,int b)
        {
            return a+b;
        }
    }
}
