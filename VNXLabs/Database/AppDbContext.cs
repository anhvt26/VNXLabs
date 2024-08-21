using Microsoft.EntityFrameworkCore;
using VNXLabs.Models;

namespace VNXLabs.Database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<PortfolioImage> PortfolioImages { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<ResearchProduct> ResearchProducts { get; set; }
        public DbSet<ResearchProductCategory> ResearchProductCategories { get; set; }
        public DbSet<ResearchProductLanguage> ResearchProductLanguages { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=192.168.100.141,1433;Database=VNXLabs;User Id=SA;Password=Password123;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Comment>()
                .HasOne(c => c.ResearchProduct)
                .WithMany(rp => rp.Comments)
                .HasForeignKey(c => c.ProductId)
                .OnDelete(DeleteBehavior.Restrict); 

            modelBuilder.Entity<Comment>()
                .HasOne(c => c.AppUser)
                .WithMany(u => u.Comments)
                .HasForeignKey(c => c.UserId)
                .OnDelete(DeleteBehavior.Restrict); 

            modelBuilder.Entity<ResearchProduct>()
                .HasOne(rp => rp.AppUser)
                .WithMany(u => u.ResearchProducts)
                .HasForeignKey(rp => rp.AuthorId)
                .OnDelete(DeleteBehavior.Restrict); 

            modelBuilder.Entity<Rating>()
                .HasOne(r => r.ResearchProduct)
                .WithMany(rp => rp.Rating)
                .HasForeignKey(r => r.ProductId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ResearchProductCategory>()
                .HasOne(rpc => rpc.ResearchProduct)
                .WithMany(rp => rp.ResearchProductCategories)
                .HasForeignKey(rpc => rpc.ProductId)
                .OnDelete(DeleteBehavior.Restrict); 

            base.OnModelCreating(modelBuilder);
        }

    }
}
