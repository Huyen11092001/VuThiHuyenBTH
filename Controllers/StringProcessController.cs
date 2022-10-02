using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;
using VuThiHuyenBTH.Models.Process;

namespace VuThiHuyenBTH.Controllers
{
    public class StringProcessController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        StringProcess Str = new StringProcess();
       
        [HttpPost]
        // Xoa bo ky tu trang
        public IActionResult Index(string strInput)
        {
            string TB = Str.RemoveRemainingWhiteSpace(strInput);
            ViewBag.Thongbao = TB;
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }

        // Chuyen chuoi sang in hoa
        [HttpPost]
        public IActionResult Create(string strInput)
        {
            string abc = Str.LowerToUpper(strInput);
            ViewBag.Hienthi = abc;
            return View();
        }
        public IActionResult uppertolower()
        {
            return View();
        }
        // Chuyen chuoi sang in thuong
        [HttpPost]
        public IActionResult uppertolower(string strInput)
        {
            string up = Str.UpperToLower(strInput);
            ViewBag.Inthuong = up;
            return View();
        }
        public IActionResult capitaliOne()
        {
            return View();
        }

        [HttpPost]
        // Viet hoa chu cai dau 
        public IActionResult capitaliOne(string strInput)
        {
            string capitaone = Str.CapitalizeOneFirstCharacter(strInput);
            ViewBag.Hoa1 = capitaone;
            return View();
        }
        public IActionResult capitaliFirst()
        {
            return View();
        }
        [HttpPost]
        // Viet hoa chu cai dau tien cua cac tu trong chuoi
        public IActionResult capitaliFirst(string strInput)
        {
            string capitaFirst = Str.CapitalizeFirstCharacter(strInput);
            ViewBag.HoaFirst = capitaFirst;
            return View();
        }
        public IActionResult Remove()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Remove(string strInput)
        {
            string remove = Str.RemoveVietnameseAccents(strInput);
            ViewBag.Remo = remove;
            return View();
        }
    }
}

