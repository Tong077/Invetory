using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inventory.Models
{
    public class Products
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }
        public string? ProductCode { get; set; }
        public string? ProductDescription { get; set; }
        public string? StandardUnitCost { get; set; }
        public string? UnitPrice { get; set; }
        public string? Reorderlevel { get; set; }
        public string? TargetLevel { get; set; }
        public string? QuantityPerUnit { get; set; }
        public string? Discountinued {  get; set; }
        public string? MinimumReorderQuantity { get; set; }

        [ForeignKey(nameof(Categories))]
        public int CategoryId { get; set; }
        public string? AddedBy { get; set; }
        public string? AddedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public string? ModifiedOn { get; set; }

       public ICollection<PurchaseOrderDetails>? PurchaseOrderDetails { get; set; }
        public ICollection<OrderDetails>? OrderDetails { get; set; }
        public Categories? Categories { get; set; }
    }
}
