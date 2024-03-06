using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inventory.Models
{
    public class OrderDetails
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderDetaillId { get; set; }

        [ForeignKey(nameof(Orders))]
        public int OrderId { get; set; }

        [ForeignKey(nameof(Products))]
        public int ProductId { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? UnitPrice { get; set; }
        public string? Discount { get; set; }

        [ForeignKey(nameof(OrderDetailStatus))]
        public int OrderDetailStatusId { get; set; }
        public string? AddedBy { get; set; }
        public string? AddedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public string? ModifiedOn { get; set;}
        public Orders? Orders { get; set; }
        public Products? Products { get; set; }

    }
}
