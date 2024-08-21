using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using VNXLabs.Enums;

namespace VNXLabs.Models
{
    public class AppUser
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public Guid RoleId { get; set; }
        [ForeignKey("RoleId")]
        public virtual UserRole? Role { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public UserStatus Status { get; set; }
        public virtual ICollection<Contact>? Contacts { get; set; }
        public virtual Portfolio? Portfolio { get; set; }
        public virtual ICollection<Comment>? Comments { get; set; }
        public virtual ICollection<Rating>? Ratings { get; set; }
        public virtual ICollection<ResearchProduct>? ResearchProducts { get; set; }
    }
}
