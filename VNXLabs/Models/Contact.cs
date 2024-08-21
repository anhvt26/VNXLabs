using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using VNXLabs.Enums;

namespace VNXLabs.Models
{
    public class Contact
    {
        [Key]
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string? Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public ContactStatus Status { get; set; }
        [ForeignKey("UserId")]
        public virtual AppUser? User { get; set; }
    }
}
