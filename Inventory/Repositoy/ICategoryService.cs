using Microsoft.EntityFrameworkCore;
using Inventory.Data;
using Inventory.Models;

namespace Inventory.Repositoy
{
    public interface ICategoryService
    {

        Task<bool> Create(Categories categories);
        Task<bool> Update(Categories categories);
        Task<List<Categories>> GetAll();
        Task<Categories> Get(int CategoryId);
        Task<bool> Delete(Categories categories);

       
    }
}
