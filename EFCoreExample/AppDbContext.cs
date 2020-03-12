using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreExample
{
    public class AppDbContext : DbContext
    {
        private const string ConnectionString =
            @"Server = (localdb)\MSSQLLocalDB;
                Database = EfCoreDb;
                Trusted_Connection=true;
                Integrated Security=true";

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);

        }

        public DbSet<Book> Books { get; set; }
    }
}
