using Application.Interfaces;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class ListWhishRepository : IListWhish
    {
        private readonly ApplicationDbContext _context;

        public ListWhishRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ListWhish>> GetWishlistItemsByUserIdAsync(int userId)
        {
            var wishlistItems = await _context.WishlistItems
                .Include(w => w.Product)
                .Include(c => c.Product.Category)
                .Where(w => w.UserId == userId)
                .ToListAsync();
            Console.WriteLine($"Fetched {wishlistItems.Count} items for userId {userId}");

            return wishlistItems;
        }

        public async Task AddToWishlistAsync(ListWhish item)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item));
            {
            }

            _context.WishlistItems.Add(item);
            await _context.SaveChangesAsync();
        }

        public async Task RemoveFromWishlistAsync(int id)
        {
            var item = await _context.WishlistItems.FindAsync(id);
            if (item != null)
            {
                _context.WishlistItems.Remove(item);
                await _context.SaveChangesAsync();
            }
            else
            {
                Console.WriteLine($"Item with Id {id} not found");
            }
        }

        public async Task<ListWhish> GetListWhish(int id) => await _context.WishlistItems.FindAsync(id);
    }
}
