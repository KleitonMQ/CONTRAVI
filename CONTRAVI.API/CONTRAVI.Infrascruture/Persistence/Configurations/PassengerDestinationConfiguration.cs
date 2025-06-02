using CONTRAVI.core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CONTRAVI.Infrascruture.Persistence.Configurations
{
    internal class PassengerDestinationConfiguration : IEntityTypeConfiguration<PassengerDestination>
    {
        public void Configure(EntityTypeBuilder<PassengerDestination> builder)
        {
            builder.HasKey(p => p.Id);

            builder.HasOne(p => p.Passenger)
                .WithMany()
                .HasForeignKey(k => k.PassengerId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
