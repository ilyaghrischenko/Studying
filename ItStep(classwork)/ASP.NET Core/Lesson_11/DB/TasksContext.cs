using DB.Models;
using Microsoft.EntityFrameworkCore;

namespace DB;

public class TasksContext : DbContext
{
    public TasksContext()
    {

    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer
            ("data source=(localdb)\\MSSQLLocalDB;initial catalog=TasksDB;integrated security=True;MultipleActiveResultSets=true");

    public virtual DbSet<MyDate> MyDates { get; set; }
    public virtual DbSet<MyTask> MyTasks { get; set; }
}