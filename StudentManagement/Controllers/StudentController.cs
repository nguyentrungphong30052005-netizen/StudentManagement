using Microsoft.AspNetCore.Mvc;
using StudentManagement.Models;

namespace StudentManagement.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Info()
        {
            // 1. Name dùng ViewBag
            ViewBag.Name = "Nguyễn Trung Phong";

            // 2. Age dùng ViewData
            ViewData["Age"] = 20;

            // 3. Major dùng Model
            var std = new Student
            {
                Major = "CNTT"
            };

            return View(std);
        }
    }
}