using _13Day_BootStrap_Layout_PartialView.Models;
using Microsoft.AspNetCore.Mvc;

namespace _13Day_BootStrap_Layout_PartialView.Controllers
{
    public class HomeController : Controller
    {
        List<Emp> emps = new List<Emp>() {
            new Emp(){ Id= 1, Name= "Aakanksha Karale", Address="Karad"},
            new Emp(){ Id= 2, Name= "Disha Gaikwad", Address="Shrirampur"},
            new Emp(){ Id= 3, Name= "Kalyani Patil", Address="Dhule"},
            new Emp(){ Id= 4, Name= "Niyati Borkute", Address="Chandrapur"},
        };

        List<Product> products = new List<Product>() {
            new Product(){ Id = 1, Name = "Laptop", Price = 75000, Description = "Asus 16GB RAM", Image="~/images/laptop.png"},
                new Product(){ Id = 2, Name = "HDD", Price = 5000, Description = "Sandisk 1TB", Image="~/images/HDD.png"},
                new Product(){ Id = 3, Name = "Mobile", Price = 175000, Description = "Nokia, Windows OS", Image="~/images/Mobile.png"},
            };
        public IActionResult Index()
        {
            ViewData["title"] = "Index";
            return View(emps);
        }
        public IActionResult About()
        {
            ViewData["title"] = "About";
            return View();
        }
        public IActionResult Contact()
        {
            ViewData["title"] = "Contact";
            return View();
        }
        public IActionResult Courses()
        {
            ViewData["title"] = "Courses";
            return View();
        }
        public IActionResult ProductData()
        {
            return View(products);
        }

        public IActionResult PData(int id)
        {
            Product product = products.Find(p => p.Id == id);
            List<Product> lst = new List<Product>() { product };
            return View(lst);
        }
    }
}
