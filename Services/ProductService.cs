using Microsoft.EntityFrameworkCore;
using static BlazorAppDemo.BlazorDemoDbContext;
using BlazorAppDemo.Models;

namespace BlazorAppDemo.Services

{
    public class ProductService
    {
        private readonly BlazorDemoDbContext _dbContext;

        public ProductService(BlazorDemoDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Product>> GetProductsAsync()
        {
            return await _dbContext.Products.ToListAsync();
        }
    }
}
