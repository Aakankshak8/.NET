using _12Day_view.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Diagnostics;

namespace _12Day_view.Controllers
{
    public class HomeController : Controller
    {

        List<Emp> empList = new List<Emp>()
            {
                new Emp(){ Id= 101, Name= "Pooja", Address="Pune"},
                new Emp(){ Id= 102, Name= "Neha", Address="Nagpur"},
                new Emp(){ Id= 103, Name= "Tina", Address="Thane"},
                new Emp(){ Id= 104, Name= "Pinky", Address="Puri"},
                new Emp(){ Id= 105, Name= "Jaspreet", Address="Jamnagar"},

            };

        List<Customer> customerList = new List<Customer>() {
         new Customer(){CId= 1, CName="Bob", BillNo= 1234 },
         new Customer(){CId= 2, CName="Rob", BillNo= 5678 },
         new Customer(){CId= 3, CName="Tom", BillNo= 2468 },
        };
        public IActionResult Index()
        {
            string nm="hello";
            return View("index",nm);
        }

        public ActionResult getEmps()
        {
            return View(empList);
        }
        public ActionResult getCust()
        {
            return View(customerList);
        }

        public IActionResult GetRecords()
        {
            IETDbViewModel vmmodel = new IETDbViewModel()
            {
                allEmps = empList,
                allCusts = customerList
            };
            return View(vmmodel);
        }
        

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
