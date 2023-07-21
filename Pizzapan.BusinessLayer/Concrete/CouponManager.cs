using Pizzapan.BusinessLayer.Abstract;
using Pizzapan.DataAccessLayer.Abstract;
using Pizzapan.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzapan.BusinessLayer.Concrete
{
    public class CouponManager : ICouponService
    {
        private readonly ICouponDal _couponDal;

        public CouponManager(ICouponDal couponDal)
        {
            _couponDal = couponDal;
        }

        public void TDelete(Coupon t)
        {
            throw new NotImplementedException();
        }

        public Coupon TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Coupon> TGetList()
        {
           return _couponDal.GetList();
        }

        public void TUpdate(Coupon t)
        {
            throw new NotImplementedException();
        }

        public void Tİnsert(Coupon t)
        {
            _couponDal.İnsert(t);
        }
    }
}
