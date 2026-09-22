using Microsoft.EntityFrameworkCore;
using WebBuilderAPI.Models;

namespace WebBuilderAPI.Data
{
    public class BuilderDbContext : DbContext
    {
        public BuilderDbContext(DbContextOptions<BuilderDbContext> options) : base(options) { }

        public DbSet<Page> Pages { get; set; }
    }
}