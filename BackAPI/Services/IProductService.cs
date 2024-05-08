using BackAPI.Models;

namespace BackAPI.Services
{
    public interface IProductService
    {
        Task<bool> AddProduct(ProductModel product);
    }
}
