using _20250118_ShopAspNetMvc.Models;

namespace _20250118_ShopAspNetMvc.ViewModels
{
    public class ProductCategoryViewModel
    {
        public Product Product { get; set; }
        public List<Category> Categories { get; set; }

        public ProductCategoryViewModel(List<Category> categories)
        {
            Categories = categories;
        }
    }
}
