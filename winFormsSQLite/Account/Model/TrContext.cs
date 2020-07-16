using System;
using Microsoft.EntityFrameworkCore;


namespace Account.Model
{

    public class TrContext : DbContext
    {
        public string NameDB { get; set; } = "TrDB";
        public TrContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(String.Format("Filename={0}.db", NameDB));
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
    }
}
