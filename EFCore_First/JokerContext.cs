using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCore_First.Models;
using Microsoft.EntityFrameworkCore;


namespace EFCore_First
{
    /// <summary>
    /// 数据库上下文类
    /// </summary>
    public class JokerContext : DbContext
    {
        public JokerContext()
        {

        }

        public JokerContext(DbContextOptions<JokerContext> options):base(options)
        {

        }

        public DbSet<Book> Book { get; set; }

        /// <summary>
        /// 配置上下文类
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connString = @"Data Source=LAPTOP-3HE8JVHO;Initial Catalog=EFCoreDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            optionsBuilder.UseSqlServer(connString);
        }

    }
}
