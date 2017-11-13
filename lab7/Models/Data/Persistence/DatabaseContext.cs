using lab7.Models.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace lab7.Models.Data.Persistence
{
    public sealed class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
            this.Database.EnsureCreated();
        }

        public DbSet<City> Cities { get; set; }
    }
}
