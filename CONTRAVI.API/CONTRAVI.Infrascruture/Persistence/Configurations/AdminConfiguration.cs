using CONTRAVI.core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CONTRAVI.Infrascruture.Persistence.Configurations
{
    public class AdminConfiguration : IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> builder)
        {
            builder.ToTable("Admins", b => b.IsTemporal(false));
            builder.UseTpcMappingStrategy();

            builder.HasKey(a => a.Id);
            builder.Property(a => a.UserName).IsRequired().HasMaxLength(100);
            builder.Property(a => a.PhoneNumber).HasMaxLength(20);
            builder.Property(a => a.Email).IsRequired().HasMaxLength(100);
            builder.Property(a => a.Login).IsRequired().HasMaxLength(50);
            builder.Property(a => a.Password).IsRequired().HasMaxLength(100);

            builder.OwnsOne(a => a.Adress);
        }
    }
}
