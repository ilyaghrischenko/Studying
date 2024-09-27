using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WA_EF_4.Models;

namespace WA_EF_4
{
    public class studContext : DbContext
    {
        public studContext (DbContextOptions<studContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Departments { get; set; } = default!;
        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        
    }
}
