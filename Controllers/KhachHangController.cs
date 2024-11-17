using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class KhachHangController : Controller
    {
        private readonly BDSContext _context;

        public KhachHangController(BDSContext context)
        {
            _context = context;
        }

        public IActionResult Index(string searchString)
        {
             var khachHangs = _context.KhachHangs.ToList();
            return View(khachHangs);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(KhachHang khachHang)
        {
            if (ModelState.IsValid)
            {
                // Kiểm tra xem mã khách hàng đã tồn tại hay chưa
                var existingCustomer = _context.KhachHangs
                    .FirstOrDefault(kh => kh.MaKH == khachHang.MaKH);

                if (existingCustomer != null)
                {
                    // Báo lỗi nếu mã khách hàng đã tồn tại
                    ModelState.AddModelError("MaKH", "Mã khách hàng đã tồn tại trong hệ thống.");
                    return View(khachHang);
                }

                // Lưu thông tin khách hàng mới
                _context.Add(khachHang);
                _context.SaveChanges();
                TempData["SuccessMessage"] = "Khách hàng đã được lưu thành công!";
                return Json(khachHang);
            }

            // Trả lại view nếu có lỗi trong dữ liệu
            return View(khachHang);
        }


        public IActionResult Edit(int id)
        {
            var khachHang = _context.KhachHangs.Find(id);
            if (khachHang == null)
            {
                return NotFound();
            }
            return View(khachHang);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, KhachHang khachHang)
        {
            if (id != khachHang.MaKH)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(khachHang);
                    _context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KhachHangExists(khachHang.MaKH))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(khachHang);
        }

        public IActionResult Delete(int id)
        {
            var khachHang = _context.KhachHangs.Find(id);
            if (khachHang == null)
            {
                return NotFound();
            }
            return View(khachHang);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var khachHang = _context.KhachHangs.Find(id);
            _context.KhachHangs.Remove(khachHang);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        private bool KhachHangExists(int id)
        {
            return _context.KhachHangs.Any(e => e.MaKH == id);
        }
    }
}
