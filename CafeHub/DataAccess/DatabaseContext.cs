using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeHub.Models;
using Microsoft.EntityFrameworkCore;

namespace CafeHub
{
    public class DatabaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LSDGOD\\SQLEXPRESS;Initial Catalog=CafeHubDb;Integrated Security=True");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Shift> Shifts { get; set; }
    }
}
