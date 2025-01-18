using _20250118_ShopAspNetMvc.Models;

namespace _20250118_ShopAspNetMvc.Data
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();
        Product? GetProductById(int id);
        void DeleteProduct(Product product);
    }
}