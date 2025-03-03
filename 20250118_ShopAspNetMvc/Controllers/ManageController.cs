using Microsoft.AspNetCore.Mvc;
using _20250118_ShopAspNetMvc.Data;
using _20250118_ShopAspNetMvc.Models;
using _20250118_ShopAspNetMvc.ViewModels;

namespace _20250118_ShopAspNetMvc.Controllers
{
    public class ManageController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;

        public ManageController(IProductRepository productRepository, ICategoryRepository categoryRepository)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
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

        public IActionResult Create()
        {
            var categories = _categoryRepository.GetAllCategories().ToList(); 
            ProductCategoryViewModel productCategoryViewModel = new(categories);
            return View(productCategoryViewModel);
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (!ModelState.IsValid)
                return View();
            _productRepository.AddProduct(product);
            return RedirectToAction("Index");
        }
    }
}
