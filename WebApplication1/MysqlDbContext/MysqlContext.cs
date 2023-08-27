using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.MysqlDbContext
{
    public class MysqlContext : DbContext
    {
        public MysqlContext(DbContextOptions<MysqlContext> options) : base(options)
        {

        }
        //建立表与模型的映射关系
        public DbSet<User> User { get; set; }
        public DbSet<Department> Department { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
