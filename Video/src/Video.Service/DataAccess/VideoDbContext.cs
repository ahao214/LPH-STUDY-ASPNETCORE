namespace Video.Service.DataAccess
{
    public class VideoDbContext : MasaDbContext
    {
        //public DbSet<UserEntity> { get; set; }

        public VideoDbContext(MasaDbContextOptions<VideoDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreatingExecuting(ModelBuilder modelBuilder)
        {
            base.OnModelCreatingExecuting(modelBuilder);
            ConfigEntities(modelBuilder);
        }

        private static void ConfigEntities(ModelBuilder modelBuilder)
        {
            //TODO:Configure Entities.
        }
    }
}
