using Microsoft.EntityFrameworkCore;
using Server.Data.UserModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        private string DbPath { get; set; }
        public AppDbContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = Path.Join(path, "users.db");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
          optionsBuilder.UseSqlite($"Data Source={DbPath}");
    }
}
