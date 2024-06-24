using Lesson_5.Models.Client;
using Lesson_5.Models.Data;
using Lesson_5.Models.Personal;
using Lesson_5.Models.Product;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace Lesson_5
{
    public class InternetStoreContext : DbContext
    {
        public InternetStoreContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer
            ("data source=(localdb)\\MSSQLLocalDB;initial catalog=InternetStore;integrated security=True;MultipleActiveResultSets=true");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().UseTpcMappingStrategy();
            modelBuilder.Entity<Client>().UseTpcMappingStrategy();
            modelBuilder.Entity<Personal>().UseTpcMappingStrategy();
        }

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Technique> Techniques { get; set; }
        public virtual DbSet<Clothe> Clothes { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Provider> Providers { get; set; }
        public virtual DbSet<Personal> Personals { get; set; }
        public virtual DbSet<Manager> Managers { get; set; }
        public virtual DbSet<Consultant> Consultants { get; set; }
        public virtual DbSet<Call> Calls { get; set; }
        public virtual DbSet<Purchase> Purchases { get; set; }
        public virtual DbSet<Supply> Supplies { get; set; }
    }
}
