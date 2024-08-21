using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using VNXLabs.Enums;

namespace VNXLabs.Models
{
    public class Portfolio
    {
        [Key]
        public Guid Id { get; set; }
        public Guid OwnerId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public PortfolioStatus Status { get; set; }
        public virtual ICollection<PortfolioImage>? Images { get; set; }
        [ForeignKey("OwnerId")]
        public virtual AppUser? AppUser { get; set; }

    }
}
