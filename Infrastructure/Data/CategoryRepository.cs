using BackendC.Application.Interfaces;
using BackendC.Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace BackendC.Infrastructure.Data
{
    public class CategoryRepository : ICategory
    {
        private readonly ApplicationDbContext _context;

        public CategoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Category>> GetCategoriesAsync()
        {
            return await _context.Categories.ToListAsync();
        }
    }
}
