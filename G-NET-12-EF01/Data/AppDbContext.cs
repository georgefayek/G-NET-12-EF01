using G_NET_12_EF01.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_12_EF01.Data
{
    internal class AppDbContext : DbContext
    {
        // Tables
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=.;Database=BookStoreDB;Trusted_Connection=True;TrustServerCertificate=True");
        }
    }
}
