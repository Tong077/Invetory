using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inventory.Models
{
    public class OrderDetailStatus
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderDetailStatusId { get; set; }
        public string? OrderDetailStatusName { get; set; }
        public string? SortOrder { get; set; }
        public string? AddedBy { get; set; }
        public string? AddedOn { get; set; }
        public string? Modifiedby { get; set; }
        public string? ModifiedOn { get; set;}
        public ICollection <OrderDetails>? OrderDetails { get; set; }
}
}
