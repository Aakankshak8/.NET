using Microsoft.AspNetCore.Mvc;

namespace _12Day_ConventionalRouting.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult<String> welcome(string a) {

            return ("hi "+a);
        }
    }
}
