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

        public CONTRAVIDBContext()
        {
            // Endereços fictícios
            Address = new List<Address>
            {
                new Address("BA", "44000-000", "Feira de Santana", "Centro", "Rua A", "123", "Apto 101"),
                new Address("SP", "01000-000", "São Paulo", "Jardins", "Avenida B", "456", "Casa"),
                new Address("RJ", "20000-000", "Rio de Janeiro", "Copacabana", "Rua C", "789", "Cobertura")
            };

            // Administradores fictícios
            Admins = new List<Admin>
            {
                new Admin("admin1", "11999999999", "admin1@email.com", Address[0], "admin123"),
                new Admin("admin2", "21999999999", "admin2@email.com", Address[1], "admin456")
            };

            // Motoristas fictícios
            Drivers = new List<Driver>
            {
                new Driver("driver1", "31999999999", "driver1@email.com", Address[0], "12345678900", "driver123"),
                new Driver("driver2", "41999999999", "driver2@email.com", Address[1], "98765432100", "driver456")
            };

            // Passageiros fictícios
            Passes = new List<Passenger>
            {
                new Passenger("passenger1", "51999999999", "passenger1@email.com", Address[0], "111222333444"),
                new Passenger("passenger2", "61999999999", "passenger2@email.com", Address[1], "555666777888")
            };

            // Veículos fictícios
            Vehicles = new List<Vehicle>
            {
                new Vehicle(1, "Toyota Corolla", "ABC-1234", 4),
                new Vehicle(2, "Honda Civic", "XYZ-5678", 4),
                new Vehicle(3, "Ford Ranger", "JKL-9101", 5)
            };

            // Rotas fictícias
            Roads = new List<RoadMap>
            {
                new RoadMap("Feira de Santana", "Salvador", "18:00"),
                new RoadMap("São Paulo", "Rio de Janeiro", "20:00")
            };

            // Viagens fictícias
            Trip = new List<Trip>
            {
                new Trip(Drivers[0].Id, Drivers[0], Vehicles[0].Id, Vehicles[0], Roads[0].Id, Roads[0], DateTime.Now, DateTime.Today),
                new Trip(Drivers[1].Id, Drivers[1], Vehicles[1].Id, Vehicles[1], Roads[1].Id, Roads[1], DateTime.Now, DateTime.Today)
            };
        }
    }
}
