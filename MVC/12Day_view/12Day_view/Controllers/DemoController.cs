using _12Day_view.Models;
using Microsoft.AspNetCore.Mvc;

namespace _12Day_view.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            //ViewBag.Message = "Helloo";

            //Emp emp = new Emp() { Id = 101, Name = "Tom Ellis", Address = "London" };
            //ViewBag.empInfo = emp;

            ViewData["number"] = 123456;
            return View();
        }

    }
}
