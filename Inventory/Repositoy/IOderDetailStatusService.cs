using Inventory.Models;

namespace Inventory.Repositoy
{
    public interface IOderDetailStatus
    {
        Task<bool> Create(OrderDetailStatus oderDetailStatus);
        Task<List<OrderDetailStatus>> GetAll();
        Task<OrderDetailStatus> Get(int OrderDetailStatusId);
        Task<bool> Update(OrderDetailStatus oderDetailStatus);
        Task<bool> Delete(OrderDetailStatus oderDetailStatus);

    }
}
