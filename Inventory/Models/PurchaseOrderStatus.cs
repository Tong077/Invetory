using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inventory.Models
{
    public class PurchaseOrderStatus
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StatusId { get; set; }
        public string? StatusName { get; set; }
        public string? SortOrder { get; set; }
        public string? AddedBy { get; set; }
        public string? AddedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public string? ModifiedOn { get; set; }
        public ICollection<PurchaseOrders>? PurchaseOrders { get; set; }
    }
}
