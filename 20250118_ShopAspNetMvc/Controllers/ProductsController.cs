using _20250118_ShopAspNetMvc.Data;
using Microsoft.AspNetCore.Mvc;

namespace _20250118_ShopAspNetMvc.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductRepository _productRepository;

        public ProductsController(ILogger<HomeController> logger, IProductRepository productRepository)
        {
            _logger = logger;
            _productRepository = productRepository;
        }
        public IActionResult Index()
        {
            var products = _productRepository.GetAllProducts().ToList();
            return View(products);
        }
    }
}