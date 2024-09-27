
using Microsoft.EntityFrameworkCore;


namespace WebMVC_2.Data
{
    public class DBContext : DbContext
    {
        public DBContext (DbContextOptions<DBContext> options)
            : base(options)
        {
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer
                ("data source=(localdb)\\MSSQLLocalDB;initial catalog=Auth_Book_DB;integrated security=True;MultipleActiveResultSets=true");

        public DbSet<Models.Auth> Auth { get; set; } = default!;
        public DbSet<Models.Book> Book { get; set; } = default!;
        public DbSet<Models.Publisher> Publisher { get; set; } = default!;
    }
}
