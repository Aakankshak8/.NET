using Microsoft.AspNetCore.Mvc;

namespace _12Day_AttributeBasedRouting.Controllers
{
    [Route("[Controller]")]
    public class DashboardController : Controller
    {
        [Route("[action]")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("[action]/{id?}/{nm?}")]
        public string GetSomething(int id, string nm)
        {
            return $"Id: {id}, Name:{nm}";
        }
    }
}
