using Ciot.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ciot.Data.Configurations;

public class EntityParameter: IEntityTypeConfiguration<Parameter>
{
    public void Configure(EntityTypeBuilder<Parameter> builder)
    {
        builder
            .HasKey(o => o.Id);
        
        builder
            .Property(o => o.Name)
            .IsRequired()
            .HasMaxLength(100);
        
        builder
            .HasOne(o => o.Operation)
            .WithMany(d => d.Parameters)
            .HasForeignKey(o => o.OperationId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}