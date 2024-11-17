using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly BDSContext _context;

        public HomeController(BDSContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Properties()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Services()
        {
            return View();
        }
        public IActionResult Detail()
        {
            return View(); 
        }
        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }

       
        [HttpPost]
        public IActionResult Contact(YeuCauDinhGia model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                   
                    bool check = _context.YeuCauDinhGias.Any(x => x.MaYC == model.MaYC);

                    if (check)
                    {
                        
                        ModelState.AddModelError("MaYC", "Mã yêu cầu đã tồn tại. Vui lòng nhập mã khác.");
                        return View(model); 
                    }

                    // Thêm dữ liệu vào database
                    _context.YeuCauDinhGias.Add(model);
                    _context.SaveChanges();

                   
                    ViewBag.Message = "Yêu cầu đã được gửi thành công!";
                    return View(new YeuCauDinhGia()); 
                }
                catch (Exception ex)
                {
                    // Xử lý lỗi chung và hiển thị thông báo
                    ModelState.AddModelError("", "Đã xảy ra lỗi khi lưu dữ liệu: " + ex.Message);
                }
            }

            // Trả về view nếu có lỗi trong ModelState
            return View(model);
        }


    }
}
