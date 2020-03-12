using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreExample
{
    class AppDbContext : DbContext
    {
        private const string ConnectionString =
            @"Server = DESKTOP-JI6RI4R;
                Database = EfCoreDb;
                Trusted_Connection=true";

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);

        }

        public DbSet<Book> Books { get; set; }
    }
}
