using Ciot.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Ciot.Data;

public sealed class AppDbContext: DbContext
{
    public DbSet<Device> Devices { get; set; }
    public DbSet<Operation> Operations { get; set; }
    public DbSet<Parameter> Parameters { get; set; }
    public DbSet<User> Users { get; set; }
    
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        ChangeTracker.AutoDetectChangesEnabled = false;
        ChangeTracker.LazyLoadingEnabled = false;
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        
        base.OnModelCreating(modelBuilder);
    }
}