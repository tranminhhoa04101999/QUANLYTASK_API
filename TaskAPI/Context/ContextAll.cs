using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskAPI.Entities;

namespace TaskAPI.Context
{
    public class ContextAll : DbContext
    {
        private const string sqlserver = @"Data Source=DESKTOP-9RHI76C,1433;Initial Catalog=QUANLYTASK_TTTN;User ID=sa;Password=123456";
        public DbSet<Users> Users { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(sqlserver);
        }
    }
}
