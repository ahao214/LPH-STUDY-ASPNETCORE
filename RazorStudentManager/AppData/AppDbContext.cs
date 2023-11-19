using Microsoft.EntityFrameworkCore;
using RazorStudentManager.Model;


namespace RazorStudentManager.AppData
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Student> Students { get; set; }
        public DbSet <StudentClass> StudentClasses { get; set; }


    }
}
