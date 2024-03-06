using Inventory.Models;

namespace Inventory.Repositoy
{
    public interface IPurchaseOrders
    {
        Task<bool> Create(PurchaseOrders purchaseOrders);
        Task<bool> Update(PurchaseOrders purchaseOrders);
        Task<bool> Delete(PurchaseOrders purchaseOrders);
        Task<List<PurchaseOrders>> GetAll();
        Task<PurchaseOrders> GetById(int PurchaseOrderID);

    }
}
