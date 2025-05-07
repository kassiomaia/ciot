using Ciot.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Ciot.Data;

public class DbContent: DbContext
{
    public DbSet<Device> Devices { get; set; }
    public DbSet<Operation> Operations { get; set; }
    public DbSet<User> Users { get; set; }
    
    public DbContent(DbContextOptions<DbContent> options) : base(options)
    {
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
        /*
         * Configure Device entity
         */

        modelBuilder.Entity<Device>()
            .HasKey(d => d.Id);
        
        modelBuilder.Entity<Device>()
            .Property(d => d.Name)
            .IsRequired()
            .HasMaxLength(100);
        
        modelBuilder.Entity<Device>()
            .HasMany(d => d.Operations)
            .WithOne(o => o.Device)
            .HasForeignKey(o => o.DeviceId)
            .OnDelete(DeleteBehavior.Cascade);
        
        /*
         * Configure Operation entity
         */

        modelBuilder.Entity<Operation>()
            .HasKey(o => o.Id);
        
        modelBuilder.Entity<Operation>()
            .Property(o => o.Name)
            .IsRequired()
            .HasMaxLength(100);

        /*
         * Configure User entity
         */
        
        modelBuilder.Entity<User>()
            .HasKey(u => u.Id);

        modelBuilder.Entity<User>()
            .Property(u => u.Name)
            .IsRequired()
            .HasMaxLength(100);

        modelBuilder.Entity<User>()
            .HasIndex(u => u.Email)
            .IsUnique();
    }
}