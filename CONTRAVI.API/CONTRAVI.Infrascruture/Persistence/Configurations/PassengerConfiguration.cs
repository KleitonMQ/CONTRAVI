using CONTRAVI.core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CONTRAVI.Infrascruture.Persistence.Configurations
{
    public class PassengerConfiguration : IEntityTypeConfiguration<Passenger>
    {
        public void Configure(EntityTypeBuilder<Passenger> builder)
        {
            builder.ToTable("Passengers", b => b.IsTemporal(false));
            builder.UseTpcMappingStrategy();

            builder.HasKey(p => p.Id);
            builder.Property(p => p.UserName).IsRequired().HasMaxLength(100);
            builder.Property(p => p.PhoneNumber).HasMaxLength(20);
            builder.Property(p => p.Email).IsRequired().HasMaxLength(100);
            builder.Property(p => p.CNS).IsRequired().HasMaxLength(20);

            builder.OwnsOne(p => p.Adress);
        }
    }
}
