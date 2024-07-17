using Microsoft.EntityFrameworkCore;
using NLayer.Core.Models;
using NLayer.Core.Repositories;
using NLayer.Data.Context;

namespace NLayer.Data.Repositories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }

        public async Task<Category> GetSingleCategoryByIdWithProductsAsync(int categoryId)
        {
            return await _appDbContext.Categories
                .Include(c => c.Products)
                .Where(c => c.Id == categoryId)
                .SingleOrDefaultAsync();
        }
    }
}
