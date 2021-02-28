using LibraryApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApi.Data
{
    public class LibraryDataContext : DbContext
    {
        public DbSet<User> User { get; set; }

        public LibraryDataContext(DbContextOptions<LibraryDataContext> options) : base(options)
        {
           
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
       .ToTable("tblBarrower");
            modelBuilder.Entity<Book>()
       .ToTable("tblBook");
            modelBuilder.Entity<Transaction>()
       .ToTable("tblTransaction");
        }


        public DbSet<LibraryApi.Models.Book> Book { get; set; }


        public DbSet<LibraryApi.Models.Transaction> Transaction { get; set; }

    }
}
