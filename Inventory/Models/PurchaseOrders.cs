using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inventory.Models
{
    public class PurchaseOrders
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PurchaseOrderID { get; set; }
        public int VendorId { get; set; }
        public int SubmittedById { get; set; }

        [ForeignKey(nameof(Employee))]
        public int EmployeeId { get; set; }
        public DateTime SubmittDate { get; set; }
        public int ApprovedById {  get; set; }
        public DateTime ApproveDate { get; set; }

        [ForeignKey(nameof(PurchaseOrderStatus))]
        public int StatusId { get; set; }
        public DateTime ReceiveDate { get; set; }
        public string? ShippingFee { get; set; }
        public decimal TaxAmount { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal? PaymentAmount { get; set; }
        public string? PaymentMethod { get; set; }
        public string? Note { get; set; }
        public string? Addedby { get; set; }
        public string? AddedOn {  get; set; }
        public string? ModifiedBy { get; set; }
        public string? ModifiedOn { get; set; }

        public Employee? Employee { get; set; }
        public PurchaseOrderStatus? purchaseOrderStatus { get; set; }
    }
}
