using DB.Models;
using Microsoft.EntityFrameworkCore;

namespace DB;

public class Context : DbContext
{
    public Context() {}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer
            ("data source=(localdb)\\MSSQLLocalDB;initial catalog=AuthorsBooksDB;integrated security=True;MultipleActiveResultSets=true");

    public virtual DbSet<Book> Books { get; set; }
    public virtual DbSet<Author> Authors { get; set; }
}