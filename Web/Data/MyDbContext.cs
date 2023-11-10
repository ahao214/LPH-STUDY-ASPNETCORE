using Microsoft.EntityFrameworkCore;

namespace Web.Data
{
    public class MyDbContext:DbContext
    {
        public MyDbContext(DbContextOptions options):base(options)
        {

        }

       

        public DbSet<User> Users { get; set; }
    }
}
