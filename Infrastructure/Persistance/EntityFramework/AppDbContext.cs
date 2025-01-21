using Application.Abstractions;
using Application.Services;
using Domain.Abstractions;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistance.EntityFramework
{
    public class AppDbContext(
        DbContextOptions<AppDbContext> options,
        ICurrentUserService currentUserService ) : DbContext(options), IAppDbContext
    {
        private readonly ICurrentUserService _currentUserService = currentUserService;

        public DbSet<User> Users { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Sector> Sectors { get; set; }
        public DbSet<Slide> Slides { get; set; }
        public DbSet<UsefullLink> UsefulLinks { get; set; }
        public DbSet<Image> Images { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            modelBuilder.Entity<Image>()
                .HasOne(x => x.Post).WithMany(x => x.Images).HasForeignKey(x => x.PostId);
            modelBuilder.Entity<Image>().HasKey(x => x.Id);
                
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.EnableSensitiveDataLogging();
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            SetAuditableEntity();
            return base.SaveChangesAsync(cancellationToken);
        }

        private void SetAuditableEntity()
        {
            foreach (var entry in ChangeTracker.Entries<AudiTableEntity>())
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Entity.CreatedBy = _currentUserService.Id;
                    entry.Entity.CreatedAt = DateTime.UtcNow;
                }
                if (entry.State == EntityState.Modified)
                {
                    entry.Entity.UpdatedBy = _currentUserService.Id;
                    entry.Entity.UpdatedAt = DateTime.UtcNow;
                }
            }
        }

        public async Task SeedAsync(CancellationToken cancellationToken = default)
        {
            using var _context = this.GetService<AppDbContext>();
            await _context.Users.AddAsync(DefaultData.DefaultUserData.DefaultUser, cancellationToken);

            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
