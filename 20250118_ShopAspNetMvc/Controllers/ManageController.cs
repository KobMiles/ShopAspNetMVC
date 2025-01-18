using Microsoft.AspNetCore.Mvc;
using _20250118_ShopAspNetMvc.Data;
using _20250118_ShopAspNetMvc.Models;

namespace _20250118_ShopAspNetMvc.Controllers
{
    public class ManageController : Controller
    {
        private readonly IProductRepository _productRepository;

        public ManageController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IActionResult Index()
        {
            var products = _productRepository.GetAllProducts().ToList();
            return View(products);
        }

        public IActionResult Delete(int id)
        {
            var product = _productRepository.GetProductById(id);
            if (product == null)
            {
                return NotFound();
            }
            _productRepository.DeleteProduct(product);
            return RedirectToAction("Index");
        }

        //public IActionResult Create()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public IActionResult Create(Product product)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _productRepository.AddProduct(product);
        //        return RedirectToAction("Index");
        //    }
        //    return View(product);
        //}

        //public IActionResult Edit(int id)
        //{
        //    var product = _productRepository.GetProductById(id);
        //    if (product == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(product);
        //}

        //[HttpPost]
        //public IActionResult Edit(Product product)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _productRepository.UpdateProduct(product);
        //        return RedirectToAction("Index");
        //    }
        //    return View(product);
        //}


        //[HttpPost, ActionName("Delete")]
        //public IActionResult DeleteConfirmed(int id)
        //{
        //    _productRepository.DeleteProduct(id);
        //    return RedirectToAction("Index");
        //}
    }
}
