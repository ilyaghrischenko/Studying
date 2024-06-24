using Lesson_3.Models;
using Microsoft.EntityFrameworkCore;

namespace Lesson_3
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer
            ("data source=(localdb)\\MSSQLLocalDB;initial catalog=_GameDB;integrated security=True;MultipleActiveResultSets=true");

        public virtual DbSet<Game> Games { get; set; }
        public virtual DbSet<Studio> Studios { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
    }
}
