using System.ComponentModel.DataAnnotations;

namespace VNXLabs.Models
{
    public class UserRole
    {
        [Key]
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public virtual ICollection<AppUser>? AppUsers { get; set; }
    }
}
