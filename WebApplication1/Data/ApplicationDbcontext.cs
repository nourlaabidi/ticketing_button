using Microsoft.EntityFrameworkCore;
using WebApplication1.Core.Models;


namespace WebApplication1.Data
{
    public class ApplicationDbcontext : DbContext
    {
        public ApplicationDbcontext(DbContextOptions<ApplicationDbcontext> options) : base(options)
        {

        }
        public DbSet<Category> categories { get; set; }
        public DbSet<feedback> feedbacks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("categories");
                entity.Property(e => e.Id).HasColumnName("Id");
                entity.Property(e => e.Name).HasColumnName("Name");
                entity.Property(e => e.Email).HasColumnName("Email");
                entity.Property(e => e.Comment).HasColumnName("Question");
                entity.Property(e => e.Url).HasColumnName("url");
            });
            modelBuilder.Entity<feedback>(entity =>
            {
                entity.ToTable("feedbacks");
                entity.Property(e => e.Id).HasColumnName("Id");
                entity.Property(e => e.Name).HasColumnName("Name");
                entity.Property(e => e.Email).HasColumnName("Email");
                entity.Property(e => e.Feedback).HasColumnName("Feedback");
                entity.Property(e => e.Url).HasColumnName("url");
            });
        }
        
    }
}
