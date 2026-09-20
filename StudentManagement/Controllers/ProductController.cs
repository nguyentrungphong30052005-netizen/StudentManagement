using Microsoft.AspNetCore.Mvc;

namespace StudentManagement.Controllers
{
    public class ProductController : Controller
    {
        // Action 1: Detail nhận tham số id từ URL (Ví dụ: /Product/Detail/5)
        public IActionResult Detail(int? id)
        {
            // Xử lý nâng cao: Nếu không truyền dữ liệu (id trống), hiển thị thông báo lỗi phù hợp
            if (id == null)
            {
                return Content("Lỗi: Vui lòng truyền mã sản phẩm (ID)!");
            }

            return Content($"Product ID = {id}");
        }

        // Action 2: Category nhận tham số name qua Query String (Ví dụ: /Product/Category?name=Laptop)
        public IActionResult Category(string name)
        {
            // Xử lý nâng cao: Nếu không truyền tên danh mục
            if (string.IsNullOrEmpty(name))
            {
                return Content("Lỗi: Vui lòng truyền tên danh mục (Category Name)!");
            }

            return Content($"Category = {name}");
        }
    }
}