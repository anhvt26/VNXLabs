using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using VNXLabs.Enums;

namespace VNXLabs.Models
{
    public class Rating
    {
        [Key]
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid ProductId { get; set; }
        public RatingPoint Rate { get; set; }
        public DateTime? CreatedAt { get; set; }
        [ForeignKey("UserId")]
        public virtual AppUser? AppUser { get; set; }
        [ForeignKey("ProductId")]
        public virtual ResearchProduct? ResearchProduct { get; set; }
    }
}
