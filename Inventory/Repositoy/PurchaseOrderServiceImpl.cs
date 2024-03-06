
using Inventory.Data;
using Inventory.Models;
using Microsoft.EntityFrameworkCore;

namespace Inventory.Repositoy
{
    public class PurchaseOrderServiceImpl : IPurchaseOrders
    {
        private readonly EntityDbContext context;
        public PurchaseOrderServiceImpl(EntityDbContext context)
        {
            this.context = context;
        }

        public async Task<bool> Create(PurchaseOrders purchaseOrders)
        {
           context.PurchaseOrders.Add(purchaseOrders);
            return await context.SaveChangesAsync() > 0;
        }

        public async Task<bool> Delete(PurchaseOrders purchaseOrders)
        {
            context.PurchaseOrders.Remove(purchaseOrders);
            return await context.SaveChangesAsync() > 0;
        }

        public async Task<List<PurchaseOrders>> GetAll()
        {
            var results = context.PurchaseOrders;
            return await results.ToListAsync();
        }

        public Task<PurchaseOrders> GetById(int PurchaseOrderID)
        {
            var purchaseOrder = context.PurchaseOrders.FirstOrDefaultAsync(x => x.PurchaseOrderID == PurchaseOrderID);
            return purchaseOrder;
        }

        public async Task<bool> Update(PurchaseOrders purchaseOrders)
        {
            context.PurchaseOrders.Update(purchaseOrders);
            return await context.SaveChangesAsync() > 0;
        }
    }
}
