using _12Day_View_Bag_data_temp.Models;
using Microsoft.AspNetCore.Mvc;

namespace _12Day_View_Bag_data_temp.Controllers
{
    public class HomeController : Controller
    {

        //List<Emp> empList = new List<Emp>()
        //    {
        //        new Emp(){ Id= 101, Name= "Pooja", Address="Pune"},
        //        new Emp(){ Id= 102, Name= "Neha", Address="Nagpur"},
        //        new Emp(){ Id= 103, Name= "Tina", Address="Thane"},
        //        new Emp(){ Id= 104, Name= "Pinky", Address="Puri"},
        //        new Emp(){ Id= 105, Name= "Jaspreet", Address="Jamnagar"},

        //    };

        //List<Customer> customerList = new List<Customer>() {
        // new Customer(){CId= 1, CName="Bob", BillNo= 1234 },
        // new Customer(){CId= 2, CName="Rob", BillNo= 5678 },
        // new Customer(){CId= 3, CName="Tom", BillNo= 2468 },
        //};
        public IActionResult Index()
        {
            long ph = 9369258147;
            return View(ph);
        }
    }
}
