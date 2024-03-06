using Inventory.Models;

namespace Inventory.Repositoy
{
    public interface IProductService
    {
        Task<bool> Create(Products products);
        Task<bool> Update(Products products);
        Task<bool> Delete(Products products);

        Task<Products> GetById(int ProductId);
        Task<List<Products>> GetAll();
    }
}
