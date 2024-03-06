using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inventory.Models
{
    public class Categories 
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryId { get; set; }
        public string? CategoryName { get; set;}
        public string? CategoryCode { get; set;}  
        public string? CategoryDescription { get; set;}
        public string? CategoryImage { get; set;}
        public string? AddedBy { get; set;}
        public string? AddedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public string? ModifiedOn { get; set; }  
        public ICollection<Products>? Products { get; set; }
    }
}
