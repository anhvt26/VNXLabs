using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using VNXLabs.Enums;

namespace VNXLabs.Models
{
    public class ResearchProduct
    {
        [Key]
        public Guid Id { get; set; }
        public Guid AuthorId { get; set; }
        [Required]
        public string? Title { get; set; }
        public string? Summary { get; set; }
        public string? Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public ProductStatus? Status { get; set; }
        public virtual ICollection<ResearchProductLanguage>? ResearchProductLanguages { get; set; }
        [ForeignKey("AuthorId")]
        public virtual AppUser? AppUser { get; set; }
        public virtual ICollection<Comment>? Comments { get; set; }
        public virtual ICollection<Rating>? Rating { get; set; }
        public virtual ICollection<ResearchProductCategory>? ResearchProductCategories { get; set; }

    }
}
