using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzapan.EntityLayer.Concrete
{
    public class Coupon
    {
        public int CouponID { get; set; }
        public string CouponName{ get; set; }
        public int CouponCount { get; set; }
        public DateTime CouponDate{ get; set; }
        public DateTime CouponFinishDate { get; set; }

    }
}
