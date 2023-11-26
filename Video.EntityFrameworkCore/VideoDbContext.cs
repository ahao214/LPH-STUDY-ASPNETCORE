using Microsoft.EntityFrameworkCore;
using Simple.EntityFramworkCore;

namespace Video.EntityFrameworkCore
{
    public class VideoDbContext : MasterDbContext<VideoDbContext>
    {
        protected VideoDbContext(DbContextOptions<VideoDbContext> options) : base(options) { }


    }
}
