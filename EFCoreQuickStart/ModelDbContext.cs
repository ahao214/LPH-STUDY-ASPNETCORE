
using Microsoft.EntityFrameworkCore;


namespace EFCoreQuickStart
{
    public class ModelDbContext : DbContext
    {
        public DbSet<Model> Models { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=model.db");
        }
    }
}
