using Microsoft.EntityFrameworkCore;
using Rapture.Common.Models;

namespace Rapture.Repository
{
    public class RaptureContext : DbContext
    {
        public DbSet<RaptureModel> Raptures { get; set; }

        public RaptureContext() : base()
        { 
        }

        public RaptureContext(DbContextOptions<RaptureContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => 
            optionsBuilder.UseSqlite("Data Source=raptures.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new RaptureConfiguration());
            _ = new RaptureSeedData(modelBuilder);
        }
    }
}
