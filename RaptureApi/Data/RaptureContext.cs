using Microsoft.EntityFrameworkCore;
using RaptureApi.Models;

namespace RaptureApi.Data
{
    public class RaptureContext : DbContext
    {
        public DbSet<Rapture> Raptures { get; set; }

        public RaptureContext(DbContextOptions<RaptureContext> options)
        : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new RaptureConfiguration());
            new RaptureSeedData(modelBuilder);
        }
    }
}
