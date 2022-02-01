using System;
using Microsoft.EntityFrameworkCore;

namespace Library.Database
{
    public class BookStoreContext : DbContext

    {
        public BookStoreContext(DbContextOptions<BookStoreContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<Books> Books { get; set; }
        public DbSet<Language> Languages { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=.;Database=BookStore;Integrated Security=true;");
        //    base.OnConfiguring(optionsBuilder);
        //}
    }
}
