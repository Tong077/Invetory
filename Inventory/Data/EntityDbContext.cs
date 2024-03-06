using Microsoft.EntityFrameworkCore;
using Inventory;
using Inventory.Models;

namespace Inventory.Data
{
    public class EntityDbContext:DbContext
    {
        public EntityDbContext(DbContextOptions<EntityDbContext> options) : base (options) 
        { }
        
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<OrderStatus> OrderStatuses {  get; set; }
        public DbSet<PurchaseOrders> PurchaseOrders { get; set; }
        public DbSet<Categories> Categories { get; set; } 
        public DbSet<PurchaseOrderDetails> PurchaseOrderDetails { get;}
        public DbSet<PurchaseOrderStatus> PurchaseOrderStatuses { get; set; }
        public DbSet<OrderDetailStatus> OrderDetailStatus { get; set; }

    }
    
}
