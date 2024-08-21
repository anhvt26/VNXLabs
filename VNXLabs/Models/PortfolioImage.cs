using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VNXLabs.Models
{
    public class PortfolioImage
    {
        [Key]
        public Guid Id { get; set; }
        public Guid PortfolioId { get; set; }
        public string? Path { get; set; }
        [ForeignKey("PortfolioId")]
        public virtual Portfolio? Portfolio { get; set; }
    }
}
