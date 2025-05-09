using CONTRAVI.core.Entities;
using Microsoft.EntityFrameworkCore;


namespace CONTRAVI.Infrascruture.Persistence
{
    public class CONTRAVIDBContext : DbContext
    {
        public CONTRAVIDBContext(DbContextOptions<CONTRAVIDBContext> options) : base(options)
        {

        }
        public DbSet<Address> Address { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Passenger> Passes { get; set; }
        public DbSet<PassengerDestination> PassesDestination { get; set; }
        public DbSet<RoadMap> Roads { get; set; }
        public DbSet<Trip> Trip { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }

    }
}
