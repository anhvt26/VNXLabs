using System.ComponentModel.DataAnnotations;

namespace VNXLabs.Models
{
    public class Category
    {
        [Key]
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public virtual ICollection<ResearchProductCategory>? ResearchProductCategories { get; set; }
    }
}
