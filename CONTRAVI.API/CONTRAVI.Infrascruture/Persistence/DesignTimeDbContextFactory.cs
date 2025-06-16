using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace CONTRAVI.Infrascruture.Persistence
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<CONTRAVIDBContext>
    {
        public CONTRAVIDBContext CreateDbContext(string[] args)
        {
            // Garante que está lendo o appsettings da raiz correta
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../CONTRAVI.API"))
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();


            var connectionString = configuration.GetConnectionString("CONTRAVIDBCs");

            var optionsBuilder = new DbContextOptionsBuilder<CONTRAVIDBContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new CONTRAVIDBContext(optionsBuilder.Options);
        }
    }
}
