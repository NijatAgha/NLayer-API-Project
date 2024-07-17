using Microsoft.EntityFrameworkCore;
using NLayer.Core.Models;
using NLayer.Core.Repositories;
using NLayer.Data.Context;

namespace NLayer.Data.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }

        public async Task<List<Product>> GetProductsWithCategoryAsync()
        {
            return await _appDbContext.Products.Include(p => p.Category).ToListAsync();
        }
    }
}
