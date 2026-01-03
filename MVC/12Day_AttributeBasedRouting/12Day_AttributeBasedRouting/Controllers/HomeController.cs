using Microsoft.AspNetCore.Mvc;

namespace _12Day_AttributeBasedRouting.Controllers
{
    [Route("Home")]
    public class HomeController : Controller
    {
        //[Route("/Home")]
        //[Route("/Home/Index")]
        [Route("Index")]
        [Route("~/")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("about")]
        public IActionResult about()
        {
            return View();
        }
    }
}
