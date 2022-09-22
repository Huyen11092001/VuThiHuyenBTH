using Microsoft.AspNetCore.Mvc;
using VuThiHuyenBTH.Models;

namespace VuThiHuyenBTH.Controllers
{
    public class PersonController : Controller
    {
        [HttpPost]
        public IActionResult Index(Person std)
        {
            ViewBag.Ps = std.PersonID + "-" + std.PersonName + "-" + std.PersonAge + "-" + std.Address;
            return View();
        }
        public IActionResult List()
        {
            List<Person> stdList = new()
        {
            new Person {PersonID =1, PersonName = "Nguyen Van A", PersonAge = 18, Address = "Ha Noi"},
            new Person {PersonID =2, PersonName = "Nguyen Van B", PersonAge = 19, Address = "Ha Nam"},
            new Person {PersonID =3, PersonName = "Nguyen Van C", PersonAge = 18, Address = "Nam Dinh"},
            new Person {PersonID =4, PersonName = "Nguyen Van D", PersonAge = 19, Address = "Ha Nam"},
            new Person {PersonID =5, PersonName = "Nguyen Van E", PersonAge = 18, Address = "Ha Noi"},

        };
            ViewData["Persons"] = stdList;
            return View(stdList);
        }
        [HttpPost]
        public IActionResult Create(Person std)
        {
            string message = std.PersonID + "-";
            message += std.PersonName + "-";
            message += std.PersonAge + "-";
            message += std.Address ;
            ViewBag.TT = message;
            return View();
        }
    }
}

