﻿using Pizzapan.BusinessLayer.Abstract;
using Pizzapan.DataAccessLayer.Abstract;
using Pizzapan.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzapan.BusinessLayer.Concrete
{
    public class ProductImageManager : IProductImageService
    {

        private readonly IProductImageDal _productImageDal;

        public ProductImageManager(IProductImageDal imageProductDal)
        {
            _productImageDal = imageProductDal;
        }

        public void TDelete(ProductImage t)
        {
            _productImageDal.Delete(t);
        }

        public ProductImage TGetByID(int id)
        {
            return _productImageDal.GetByID(id);
        }

        public List<ProductImage> TGetList()
        {
            return _productImageDal.GetList();
        }

        public void TUpdate(ProductImage t)
        {
            _productImageDal.Update(t);
        }

        public void Tİnsert(ProductImage t)
        {
            _productImageDal.İnsert(t);
        }
    }
}
