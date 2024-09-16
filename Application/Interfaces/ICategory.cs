using BackendC.Domain.Entities;

namespace BackendC.Application.Interfaces
{
    public interface ICategory
    {
        Task<IEnumerable<Category>> GetCategoriesAsync();
    }
}
