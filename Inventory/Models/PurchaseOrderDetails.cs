using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inventory.Models
{
    public class PurchaseOrderDetails
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PurchaseOrderDetailsId { get; set; }
        public int PurchaseOrderId { get; set; }

        [ForeignKey(nameof(Products))]
        public int ProductId { get; set; }
        public decimal Quantity { get; set; }
        public decimal UniteCost { get; set; }
        public DateTime ReceivedDate { get; set; }
        public string? AddedBy { get; set; }
        public string? AddedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public string? ModifiedOn { get; set; }

        public Products? Products { get; set; }
    }
}
