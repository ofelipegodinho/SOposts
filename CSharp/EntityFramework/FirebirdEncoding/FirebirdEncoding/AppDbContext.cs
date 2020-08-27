using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FirebirdEncoding
{
    public class AppDbContext : DbContext
    {
        private readonly string _connectionString;
        public DbSet<Product> Products { get; set; }

        public AppDbContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseFirebird(_connectionString);
        }
    }
}
