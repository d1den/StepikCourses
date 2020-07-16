namespace SQLite.Models
{
    using System;
    //using System.Data.Entity;
    using System.Linq;
    using Microsoft.EntityFrameworkCore;

    public class TrContext : DbContext
    {
        private string nameDB;
        public TrContext(string DBname)
        {
            nameDB = DBname;
            if (System.IO.File.Exists(String.Format("{0}.db", nameDB)))
            {
                Database.Migrate();
            }
            else
            {
                Database.EnsureCreated();
            }
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(String.Format("Filename={0}.db", nameDB));
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Buy> Buys { get; set; }
    }

}