using BooksApp.Domain;
using Microsoft.EntityFrameworkCore;
using System;

namespace BooksApp.Data
{
    public class BooksContext : DbContext
    {
        private const string connectionsString =
                             "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = BooksApp.Data";

        public DbSet<Author> Authors { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionsString);
        }

    }
}
