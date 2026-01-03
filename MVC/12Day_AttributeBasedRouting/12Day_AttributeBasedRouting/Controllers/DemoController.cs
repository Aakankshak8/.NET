using Microsoft.AspNetCore.Mvc;

namespace _12Day_AttributeBasedRouting.Controllers
{
    [Route("demo")]
    public class DemoController : Controller
    {
        [Route("Index")]
        public IActionResult Index()
        {
            return View("~/Views/Demo/Data.cshtml");
        }
        [Route("Product")]
        public int add()
        {
            return 3 * 5;
        }
    }
}
