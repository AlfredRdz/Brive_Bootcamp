using Brive.Bootcamp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Brive.Bootcamp.API
{
    public class BootcampContext : DbContext
    {
        public BootcampContext(DbContextOptions<BootcampContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>(entity =>
            {
                entity.HasKey(e => new { e.Id });
            });
        }

        public DbSet<Person> Person { get; set; }
    }
}
