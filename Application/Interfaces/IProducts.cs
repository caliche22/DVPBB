using Domain.Entities;

namespace Application.Interfaces
{
    public interface IProducts
    {
        Task<IEnumerable<Product>> GetAllProductsAsync();
        Task<Product?> GetProductByIdAsync(int externalId);
    }
}