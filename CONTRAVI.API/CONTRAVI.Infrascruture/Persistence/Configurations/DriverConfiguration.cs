using CONTRAVI.core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CONTRAVI.Infrascruture.Persistence.Configurations
{
    public class DriverConfiguration : IEntityTypeConfiguration<Driver>
    {
        public void Configure(EntityTypeBuilder<Driver> builder)
        {
            builder.ToTable("Drivers", b => b.IsTemporal(false));
            builder.UseTpcMappingStrategy();

            builder.HasKey(d => d.Id);
            builder.Property(d => d.UserName).IsRequired().HasMaxLength(100);
            builder.Property(d => d.PhoneNumber).HasMaxLength(20);
            builder.Property(d => d.Email).IsRequired().HasMaxLength(100);
            builder.Property(d => d.Login).IsRequired().HasMaxLength(50);
            builder.Property(d => d.Password).IsRequired().HasMaxLength(100);
            builder.Property(d => d.CNH).IsRequired().HasMaxLength(20);

            builder.OwnsOne(d => d.Adress);
        }
    }
}
