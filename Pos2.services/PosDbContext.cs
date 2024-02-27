using Microsoft.EntityFrameworkCore;
using Pos2.entities;

namespace Pos2.services
{
    public class PosDbContext : DbContext
    {
        public PosDbContext(DbContextOptions<PosDbContext> options) : base(options) { }

        public DbSet<Category> Categories { get; set; }
    }
}
