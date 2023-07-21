using Microsoft.AspNetCore.Mvc;
using Pizzapan.BusinessLayer.Abstract;
using Pizzapan.EntityLayer.Concrete;
using System;

namespace Pizzapan.PresentationLayer.Controllers
{
    public class CouponController : Controller
    {
        private readonly ICouponService _couponService;

        public CouponController(ICouponService couponService)
        {
            _couponService = couponService;
        }

        public IActionResult Index()
        {
            var values=_couponService.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddCoupon()
        {
            var key = CouponOlustur();
            ViewBag.Coupon = key;
            return View();
        }

        [HttpPost]
        public IActionResult AddCoupon(Coupon c)
        {
            c.CouponDate=Convert.ToDateTime( DateTime.Now.ToShortDateString());
            c.CouponFinishDate = c.CouponDate.AddDays(3);
            _couponService.Tİnsert(c);
            return RedirectToAction("Index");
        }

        public string CouponOlustur()
        {
            string coupon = "";
            Random rnd = new Random();

            // 4 harf
            for (int i = 0; i < 4; i++)
            {
                char c = (char)rnd.Next('A', 'Z' + 1);
                coupon += c;
            }                     
            // 2 sayı
            for (int i = 0; i < 2; i++)
            {
                int n = rnd.Next(0, 9);
                coupon += n.ToString();
            }
            return coupon;
        }
    }
}
