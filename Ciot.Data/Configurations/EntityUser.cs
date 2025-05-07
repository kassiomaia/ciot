using Ciot.Core.Entities;
using Ciot.Data.Configurations.Seeders;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ciot.Data.Configurations;

public class EntityUser: IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder
            .HasKey(u => u.Id);

        builder
            .Property(u => u.Name)
            .IsRequired()
            .HasMaxLength(100);

        builder
            .HasIndex(u => u.Email)
            .IsUnique();
    }
}