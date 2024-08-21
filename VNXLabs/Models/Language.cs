using System.ComponentModel.DataAnnotations;

namespace VNXLabs.Models
{
    public class Language
    {
        [Key]
        public Guid Id { get; set; }
        public string? Code { get; set; }
        public string? Name { get; set; }
        public virtual ICollection<ResearchProductLanguage>? ResearchProductLanguages { get; set; }
    }
}
