using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Simple.EntityFramworkCore;
using Video.Domains;


namespace Video.EntityFrameworkCore
{
    public class VideoDbContext : MasterDbContext<VideoDbContext>
    {
        public DbSet<UserInfo> UserInfo { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<UserRole> UserRole { get; set; }
        public DbSet<Video.Domains.Video> Video { get; set; }
        public DbSet<Like> Likes { get; set; }
        public DbSet<Comment> Comment { get; set; }
        public DbSet<Classify> Classify { get; set; }
        public DbSet<BeanVermicelli> BeanVermicelli { get; set; }

        public VideoDbContext(DbContextOptions<VideoDbContext> options) : base(options) { }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //// 用户表
            builder.Entity<UserInfo>(u =>
            {
                u.ToTable("UserInfos");
                u.HasComment("用户表");

                u.HasKey(x => x.Id);
                u.HasIndex(x => x.Id);

                u.Property(x => x.UserName).HasComment("用户名");
                u.HasIndex(x => x.UserName).IsUnique();
            });

            builder.Entity<Role>(x =>
            {
                x.ToTable("Roles");
                x.HasComment("角色表");

                x.HasKey(x => x.Id);
                x.HasIndex(x => x.Id);
            });

            builder.Entity<UserRole>(x =>
            {
                x.ToTable("UserRoles");
                x.HasComment("用户角色配置表");

                x.HasKey(x => x.Id);
                x.HasIndex(x => x.Id);
                x.HasIndex(x => x.UserId);
                x.HasIndex(x => x.RoleId);
            });

            builder.Entity<Video.Domains.Video>(x =>
            {
                x.ToTable("Videos");
                x.HasComment("视频表");

                x.HasKey(x => x.Id);
                x.HasIndex(x => x.Id);

                x.HasIndex(x => x.ClassifyId);
                x.HasIndex(x => x.UserId);

            });

            builder.Entity<Video.Domains.Like>(x =>
            {
                x.ToTable("Likes");
                x.HasComment("点赞表");

                x.HasKey(x => x.Id);
                x.HasIndex(x => x.Id);

                x.HasIndex(x => x.VideoId);
                x.HasIndex(x => x.UserId);

            });

            builder.Entity<Video.Domains.Comment>(x =>
            {
                x.ToTable("Comments");
                x.HasComment("评论表");

                x.HasKey(x => x.Id);
                x.HasIndex(x => x.Id);

                x.HasIndex(x => x.ParentId);
                x.HasIndex(x => x.UserId);

            });

            builder.Entity<Video.Domains.Classify>(x =>
            {
                x.ToTable("Classifys");
                x.HasComment("视频分类表");

                x.HasKey(x => x.Id);
                x.HasIndex(x => x.Id);
            });

            builder.Entity<Video.Domains.BeanVermicelli
                >(x =>
            {
                x.ToTable("BeanVermicellis");
                x.HasComment("关注表");

                x.HasKey(x => x.Id);
                x.HasIndex(x => x.Id);

                x.HasIndex(x => x.UserId);
                x.HasIndex(x => x.BeFocusedId);
            });
        }

    }
}
