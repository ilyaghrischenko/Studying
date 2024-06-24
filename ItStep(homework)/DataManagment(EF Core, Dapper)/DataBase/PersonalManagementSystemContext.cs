using DataBase.Models;
using Microsoft.EntityFrameworkCore;

namespace DataBase
{
    public class PersonalManagementSystemContext : DbContext
    {
        public PersonalManagementSystemContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer
            ("data source=(localdb)\\MSSQLLocalDB;initial catalog=PersonalManagementSystem;integrated security=True;MultipleActiveResultSets=true");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().UseTpcMappingStrategy();
        }

        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<Branch> Branches { get; set; }
        public virtual DbSet<BusinessTrip> BusinessTrips { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Instructor> Instructors { get; set; }
        public virtual DbSet<Insurance> Insurances { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<Training> Trainings { get; set; }
        public virtual DbSet<Manager> Managers { get; set; }
    }
}
