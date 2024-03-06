using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inventory.Models
{
    public class OrderStatus
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderStatusId { get; set; }
        public string? OrderStatusCode { get; set; }
        public string? OrderStatusName { get; set; }
        public string? SortOder { get; set; }
        public string? AddedBy { get; set; }
        public string? AddedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public string? ModifiedOn { get; set; }
        
        public ICollection<Orders>? Orders { get; set; }
    }
    
}
