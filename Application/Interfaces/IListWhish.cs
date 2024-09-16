using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface IListWhish
    {
        Task<ListWhish> GetListWhish(int id);
        Task<IEnumerable<ListWhish>> GetWishlistItemsByUserIdAsync(int userId);
        Task AddToWishlistAsync(ListWhish item);
        Task RemoveFromWishlistAsync(int id);
    }
}
