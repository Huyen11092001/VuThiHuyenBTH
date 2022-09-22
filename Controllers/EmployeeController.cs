using Microsoft.AspNetCore.Mvc;
using VuThiHuyenBTH.Models;

namespace VuThiHuyenBTH.Controllers
{
    public class EmployeeController : Controller
    {
        [HttpPost]
        public IActionResult Index(Employee std)
        {
            ViewBag.Ep = std.EmployeeID + "-" + std.EmployeeName + "-" + std.EmployeeAge;
            return View();
        }
        public IActionResult List()
        {
            List<Employee> stdList = new List<Employee>()
        {
            new Employee {EmployeeID =1, EmployeeName = "Nguyen Van A", EmployeeAge = 18},
            new Employee {EmployeeID =2, EmployeeName = "Nguyen Van B", EmployeeAge = 18},
            new Employee {EmployeeID =3, EmployeeName = "Nguyen Van C", EmployeeAge = 18},
            new Employee {EmployeeID =4, EmployeeName = "Nguyen Van D", EmployeeAge = 18},
            new Employee {EmployeeID =5, EmployeeName = "Nguyen Van E", EmployeeAge = 18},
        };
            ViewData["Employees"] = stdList;
            return View(stdList);
        }
        [HttpPost]
        public IActionResult Create(Employee std)
        {
            string message = std.EmployeeID + "-";
            message += std.EmployeeName + "-";
            message += std.EmployeeAge;
            ViewBag.TT = message;
            return View();
        }
    }
}

