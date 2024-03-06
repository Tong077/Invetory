using Inventory.Data;
using Inventory.Models;
using Microsoft.EntityFrameworkCore;

namespace Inventory.Repositoy
{
    public class ProductServiceImpl : IProductService
    {
        private readonly EntityDbContext context;
        public ProductServiceImpl(EntityDbContext context)
        {
            this.context = context;
        }
        public async Task<bool> Create(Products products)
        {
           context.Products.Add(products);
            return await context.SaveChangesAsync() > 0;

        }

        public async Task<bool> Delete(Products products)
        {
           context.Products.Remove(products);
            return await context.SaveChangesAsync() > 0;
        }

        public async Task<List<Products>> GetAll()
        {
            var results = context.Products;
            return await results.ToListAsync();
        }

        public Task<Products> GetById(int ProductId)
        {
           var products = context.Products.FirstOrDefaultAsync(x =>x.ProductId == ProductId);
            return products; 
        }

        public async Task<bool> Update(Products products)
        {
            context.Products.Update(products);
            return await context.SaveChangesAsync() > 0;
        }
    }
}
