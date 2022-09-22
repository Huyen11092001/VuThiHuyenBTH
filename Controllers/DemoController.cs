using Microsoft.AspNetCore.Mvc;
using VuThiHuyenBTH.Models.Process;
namespace VuThiHuyenBTH.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        Giaiphuongtrinh gpt = new Giaiphuongtrinh();
        [HttpPost]
        public IActionResult Index(string hesoA, string hesoB)
        {
            double a = Convert.ToDouble(hesoA);
            double b = Convert.ToDouble(hesoB);
            string thongbao = gpt.GiaiphuongtrinhBacNhat( a, b);
            ViewBag.mess = thongbao;
            return View();
        }
        // phương trình bậc 2
        public IActionResult Create(string heSoA,string heSoB, String heSoC)
        {
            double A = Convert.ToDouble(heSoA);
            double B = Convert.ToDouble(heSoB);
            double C = Convert.ToDouble(heSoC);
            string thongBao = gpt.GiaiphuongtrinhBacHai(A, B, C);
            ViewBag.abc = thongBao;
            return View();
        }
       }
       
    }
    

