using CONTRAVI.core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CONTRAVI.Infrascruture.Persistence.Configurations
{
    internal class TripConfigutarion : IEntityTypeConfiguration<Trip>
    {
        public void Configure(EntityTypeBuilder<Trip> builder)
        {
            builder.HasKey(p => p.Id);

            builder.HasOne(p => p.Vehicle)
                .WithMany()
                .HasForeignKey(k => k.VehicleId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(p => p.Driver)
                .WithMany()
                .HasForeignKey(k => k.DriverId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(p => p.RoadMap)
                .WithMany()
                .HasForeignKey(k => k.RoadMapId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(p => p.PassengerDestination)
                .WithOne()
                .HasForeignKey(k => k.TripId)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
