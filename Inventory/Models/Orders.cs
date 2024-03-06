using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inventory.Models
{
    public class Orders
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }

        [ForeignKey(nameof(Employee))]
        public int EmployeeId { get; set; }
        public int CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime InvoiceDate { get; set; }
        public DateTime ShippedDate { get; set; }
        public int ShpperId { get; set; }
        public string? ShippingFee { get; set; }
        public string? TaxRate { get; set; }
        public int TaxRateId { get; set; }
        public string? PaymentMethod { get; set; }
        public DateTime PainDate { get; set; }

        [ForeignKey(nameof(OrderStatus))]
        public int OrderStatusId { get; set; }
        public string? AddedBy {  get; set; }
        public string? AddedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public string? ModifiedOn { get; set; }

        public Employee? Employee { get; set; }
        public OrderStatus? OrderStatus { get; set; }
        public ICollection<OrderDetails>? OrderDetails { get; set; }
        
    }
}
