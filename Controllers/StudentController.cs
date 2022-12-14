using Microsoft.AspNetCore.Mvc;
using VuThiHuyenBTH.Models;

namespace VuThiHuyenBTH.Controllers
{
    public class StudentController : Controller
    {
         
    [HttpPost]
        public IActionResult Index(Student std)
        {
            ViewBag.message = std.StudentID + "-" + std.StudentName + "-" + std.StudentAge;
            return View();
        }
        public IActionResult List()
        {
            List<Student> stdList = new List<Student>()
        {
            new Student {StudentID =1, StudentName = "Nguyen Van A", StudentAge = 18},
            new Student {StudentID =2, StudentName = "Nguyen Van B", StudentAge = 18},
            new Student {StudentID =3, StudentName = "Nguyen Van C", StudentAge = 18},
            new Student {StudentID =4, StudentName = "Nguyen Van D", StudentAge = 18},
             new Student {StudentID =5, StudentName = "Nguyen Van E", StudentAge = 18},

        };
            ViewData["Students"] = stdList;
            return View(stdList);
        }
        [HttpPost]
        public IActionResult Create(Student std)
        {
            string message = std.StudentID + "-";
            message += std.StudentName + "-";
            message += std.StudentAge;
            ViewBag.TT = message;
            return View();
        }
    }
}
