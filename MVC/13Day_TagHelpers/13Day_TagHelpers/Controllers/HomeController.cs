using _13Day_TagHelpers.Models;
using Microsoft.AspNetCore.Mvc;

namespace _13Day_TagHelpers.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetNewUserDetails(NewUser newuser)//Model Binder
        {
            return View(newuser);
        }
    }
}
