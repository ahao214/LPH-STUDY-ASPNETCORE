using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.Module;
using Microsoft.EntityFrameworkCore;


namespace Blog.EntityFrameworkCore
{
    public class BlogDbContext : DbContext
    {
        public DbSet<BlogComment> BlogComments { get; set; }
        public DbSet<BlogLikes> BlogLikes { get; set; }
        public DbSet<Blogs> Blogs { get; set; }
        public DbSet<BlogTypes> BlogTypes { get; set; }
        public DbSet<Users> Users { get; set; }


        public BlogDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
#if DEBUG
            // 显示更详细的异常信息
            optionsBuilder.EnableDetailedErrors();
#endif
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Blogs>(x =>
            {
                x.ToTable("Blogs");
                // 表的描述
                x.HasComment("博客文章");
                // ID
                x.HasKey(x => x.Id);
                // 索引
                x.HasIndex(x => x.Id);
                x.HasIndex(x => x.TypeId);
                x.HasIndex(x => x.AuthorId);
                x.HasIndex(x => x.Title);
            });

            modelBuilder.Entity<Users>(x =>
            {
                x.ToTable("Users");
                // 表的描述
                x.HasComment("用户表");
                // ID
                x.HasKey(x => x.Id);
                // 索引
                x.HasIndex(x => x.Id);
                // IsUnique 表示UserName是唯一的
                x.HasIndex(x => x.UserName).IsUnique();

            });

            modelBuilder.Entity<BlogTypes>(x =>
            {
                x.ToTable("BlogTypes");
                // 表的描述
                x.HasComment("博客类型");
                // ID
                x.HasKey(x => x.Id);
                // 索引
                x.HasIndex(x => x.Id);
                x.HasIndex(x => x.Name);
            });

            modelBuilder.Entity<BlogLikes>(x =>
            {
                x.ToTable("BlogLikes");
                // 表的描述
                x.HasComment("博客浏览量");
                // ID
                x.HasKey(x => x.Id);
                // 索引
                x.HasIndex(x => x.Id);
            });

            modelBuilder.Entity<BlogComment>(x =>
            {
                x.ToTable("BlogComments");
                // 表的描述
                x.HasComment("博客评论");
                // ID
                x.HasKey(x => x.Id);
                // 索引
                x.HasIndex(x => x.Id);
            });
        }










    }
}
