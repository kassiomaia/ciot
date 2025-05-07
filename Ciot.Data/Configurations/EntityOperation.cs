using Ciot.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ciot.Data.Configurations;

public class EntityOperation: IEntityTypeConfiguration<Operation>
{
    public void Configure(EntityTypeBuilder<Operation> builder)
    {
        builder
            .HasKey(o => o.Id);
        
        builder
            .Property(o => o.Name)
            .IsRequired()
            .HasMaxLength(100);
        
        builder
            .HasOne(o => o.Device)
            .WithMany(d => d.Operations)
            .HasForeignKey(o => o.DeviceId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}