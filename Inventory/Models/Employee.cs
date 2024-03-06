using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inventory.Models
{
    public class Employee
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? EmailAddress { get; set; }
        public string? JobTitle { get; set; }
        public string? PrimaryPhone { get; set; }
        public string? SecondaryPhone { get; set; }
        public string? Title { get; set; }
        public string? Attachments { get; set; }
        public int SupervisorId { get; set; }
        public string? WindowsUserName { get; set; }
        public string? AddeBy { get; set; } 
        public string? AddedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public string? ModifiedOn { get; set;}

        public ICollection<Orders>? Orders { get; set; }
        public ICollection<PurchaseOrders>? PurchaseOrders { get; set; }
    }
}
