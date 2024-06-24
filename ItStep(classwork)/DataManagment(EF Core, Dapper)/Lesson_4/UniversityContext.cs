using Lesson_4.Models;
using Microsoft.EntityFrameworkCore;

namespace Lesson_4
{
    public class UniversityContext : DbContext
    {
        public UniversityContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer
            ("data source=(localdb)\\MSSQLLocalDB;initial catalog=University;integrated security=True;MultipleActiveResultSets=true");

        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Address> Addresses { get; set; }
    }
}
