namespace testProgSqLite.Models
{
    using System.Data.Entity;
    //using Microsoft.EntityFrameworkCore;

    public class LibraryContext : DbContext
    {
        public LibraryContext() : base("name=LibraryContext")
        {
        }
        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=new.db");
        }*/
        public DbSet<Cat> Cats { get; set; }
    }

}