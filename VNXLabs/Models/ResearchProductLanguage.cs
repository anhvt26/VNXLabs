using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VNXLabs.Models
{
    public class ResearchProductLanguage
    {
        [Key]
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public Guid LanguageId { get; set; }
        public string? TranslatedTitle { get; set; }
        public string? TranslatedSummary { get; set; }
        public string? TranslatedContent { get; set; }
        [ForeignKey("ProductId")]
        public virtual ResearchProduct? ResearchProduct { get; set; }
        [ForeignKey("LanguageId")]
        public virtual Language? Language { get; set; }
    }
}
