using Inventory.Models;

namespace Inventory.Repositoy
{
    public interface IOrderDetailsService
    {
        Task<bool> Create(OrderDetails orderDetails);
        Task<bool> Update(OrderDetails orderDetails);
        Task<OrderDetails> Get(int OrderDetaillId);
        Task<List<OrderDetails>> GetAll();
        Task<bool> Delete(OrderDetails orderDetails);
    }
}
