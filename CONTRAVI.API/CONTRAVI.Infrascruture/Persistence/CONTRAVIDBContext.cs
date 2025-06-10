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
        public DbSet<Admin> Admin { get; set; }
        public DbSet<Driver> Driver { get; set; }
        public DbSet<Passenger> Passenger { get; set; }
        public DbSet<PassengerDestination> PassengerDestination { get; set; }
        public DbSet<RoadMap> Roads { get; set; }
        public DbSet<Trip> Trip { get; set; }
        public DbSet<Vehicle> Vehicle { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CONTRAVIDBContext).Assembly);
        }
    }
}
