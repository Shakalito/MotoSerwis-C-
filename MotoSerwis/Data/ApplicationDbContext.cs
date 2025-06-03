using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MotoSerwis.Data.Entities;

namespace MotoSerwis.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Make> Makes { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Service> Services { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ApplicationUser>(entity =>
            {
                entity.HasMany(x => x.Services)
                    .WithOne(x => x.ApplicationUser)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            // Client
            modelBuilder.Entity<Client>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.FirstName).IsRequired().HasMaxLength(100);
                entity.Property(e => e.LastName).IsRequired().HasMaxLength(100);
                entity.Property(e => e.PhoneNumber).IsRequired().HasMaxLength(20);
                entity.Property(e => e.Address).IsRequired().HasMaxLength(200);
            });

            // Make
            modelBuilder.Entity<Make>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name).IsRequired().HasMaxLength(100);

                entity.HasMany(e => e.Models)
                      .WithOne(e => e.Make)
                      .HasForeignKey(e => e.MakeId)
                      .OnDelete(DeleteBehavior.Restrict);
            });

            // Model
            modelBuilder.Entity<Model>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.MakeId).IsRequired();

                entity.HasOne(e => e.Make)
                      .WithMany(m => m.Models)
                      .HasForeignKey(e => e.MakeId)
                      .OnDelete(DeleteBehavior.Restrict);
            });

            // Service
            modelBuilder.Entity<Service>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.IssueDescription).IsRequired().HasMaxLength(1000);
                entity.Property(e => e.YearOfManufacture).IsRequired();
                entity.Property(e => e.Status).IsRequired();

                entity.HasOne(s => s.Client)
                      .WithMany(s => s.Services)
                      .HasForeignKey(s => s.ClientId)
                      .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(s => s.ApplicationUser)
                      .WithMany(s => s.Services)
                      .HasForeignKey(s => s.ApplicationUserId)
                      .OnDelete(DeleteBehavior.Restrict);
            });
        }
    }
}
