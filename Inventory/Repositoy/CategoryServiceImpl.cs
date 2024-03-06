using Inventory.Data;
using Inventory.Models;
using Microsoft.EntityFrameworkCore;

namespace Inventory.Repositoy
{
    public class CategoryServiceImpl : ICategoryService
    {
        private readonly EntityDbContext context;
        public CategoryServiceImpl(EntityDbContext context)
        {
            this.context = context;
        }

        public async Task<bool> Create(Categories categories)
        {
            context.Categories.Add(categories);
            return await context.SaveChangesAsync() > 0;
        }
        public async Task<List<Categories>> GetAll()
        {
            var results = context.Categories;
            return await results.ToListAsync();
        }

        public Task<Categories> Get(int CategoryId)
        {
            var categories = context.Categories.FirstOrDefaultAsync(x => x.CategoryId == CategoryId);
            return categories;
        }

        public async Task<bool> Delete(Categories categories)
        {
            context.Categories.Remove(categories);
            return await context.SaveChangesAsync() > 0;
        }

       
        public async Task<bool> Update(Categories categories)
        {
            context.Categories.Update(categories);
            return await context.SaveChangesAsync() > 0;
        }
    }
}
