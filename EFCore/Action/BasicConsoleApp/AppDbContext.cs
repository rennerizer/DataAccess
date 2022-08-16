using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConsoleApp
{
    public class AppDbContext : DbContext
    {
        private const string _connectionString = @"Server=(localdb)\mssqllocaldb;Database=BasicEFCoreDatabase;Trusted_Connection=True";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }

        public DbSet<Book> Books { get; set; }
    }
}
