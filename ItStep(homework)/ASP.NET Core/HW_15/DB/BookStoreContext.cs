using DB.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DB;

public class BookStoreContext : DbContext
{
    public BookStoreContext() { }

    public BookStoreContext(DbContextOptions<BookStoreContext> options, IConfiguration configuration)
        : base(options)
    {
        _configuration = configuration;
    }

    private readonly IConfiguration _configuration;
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=(localdb);Database=BookStoreDB;Trusted_Connection=True;MultipleActiveResultSets=true");

    public DbSet<Book> Books { get; set; }
    public DbSet<Author> Authors { get; set; }
}