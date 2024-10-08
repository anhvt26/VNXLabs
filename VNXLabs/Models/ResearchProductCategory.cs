using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VNXLabs.Models
{
    public class ResearchProductCategory
    {
        [Key]
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public Guid CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public virtual Category? Category { get; set; }
        [ForeignKey("ProductId")]
        public virtual ResearchProduct? ResearchProduct { get; set; }
    }
}
