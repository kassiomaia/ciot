using Ciot.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ciot.Data.Configurations;

internal class DeviceEntityConfig: IEntityTypeConfiguration<Device>
{
    public void Configure(EntityTypeBuilder<Device> builder)
    {   
        builder.HasKey(d => d.Id);
        builder
            .Property(d => d.Name)
            .IsRequired()
            .HasMaxLength(100);
        builder
            .HasMany(d => d.Operations)
            .WithOne(o => o.Device)
            .HasForeignKey(o => o.DeviceId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}