using Microsoft.AspNetCore.Mvc;
using Pizzapan.BusinessLayer.Abstract;

namespace Pizzapan.PresentationLayer.ViewComponents.Default
{
    public class _ServiceMenuPartial:ViewComponent
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;

        public _ServiceMenuPartial(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }

        public IViewComponentResult Invoke()
        {
            //ViewBag.pizza= _productService.TGetProductsWithCategoryName(1);
            //ViewBag.hamburger= _productService.TGetProductsWithCategoryName(2);
            //ViewBag.doner= _productService.TGetProductsWithCategoryName(3);
            //ViewBag.kategori = _categoryService.TGetList();
            //ViewBag.urunler = _productService.TGetProductsWithCategory();
            var values = _categoryService.TGetCategoriesWithProduct();
            return View(values);
        }
    }
}
