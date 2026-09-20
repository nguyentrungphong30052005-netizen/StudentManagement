using Microsoft.AspNetCore.Mvc;

namespace StudentManagement.Controllers
{
    public class HomeController : Controller
    {
        // 1. Action Index: Hiển thị "Welcome to ASP.NET MVC"
        public IActionResult Index()
        {
            return Content("Welcome to ASP.NET MVC");
        }

        // 2. Action About: Hiển thị tên sinh viên
        public IActionResult About()
        {
            return Content("Họ và tên sinh viên: Nguyễn Trung Phong");
        }

        // 3. Action Contact: Hiển thị email sinh viên
        public IActionResult Contact()
        {
            return Content("Email sinh viên: nguyentrungphong30052005@gmail.com");
        }
    }
}