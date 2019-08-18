using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace RaptureApi.Data
{
    public class ContextFactory : IDesignTimeDbContextFactory<RaptureContext>
    {
        public RaptureContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
             .SetBasePath(Directory.GetCurrentDirectory())
             .AddJsonFile("appsettings.json")
             .Build();

            var builder = new DbContextOptionsBuilder<RaptureContext>();

            var connectionString = configuration.GetConnectionString("RaptureDatabase");

            builder.UseSqlServer(connectionString);

            return new RaptureContext(builder.Options);
        }
    }
}
