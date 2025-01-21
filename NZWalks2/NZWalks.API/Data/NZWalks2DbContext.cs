using Microsoft.EntityFrameworkCore;
using NZWalks.API.Models.Domain;

namespace NZWalks.API.Data
{
    public class NZWalks2DbContext : DbContext
    {
        public NZWalks2DbContext(DbContextOptions<NZWalks2DbContext> dbContext) 
            : base(dbContext)
        {
            
        }

        // Create three properties
        // Create the following tables for us in the database.

        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }

        public DbSet<WalkDifficulty> WalkDifficulties { get; set; }
    }
}
  