using DB.Models;
using Microsoft.EntityFrameworkCore;

namespace DB;

public class WorkUAContext : DbContext
{
    public WorkUAContext() { }
    
    public WorkUAContext(DbContextOptions<WorkUAContext> options) : base(options) { }   
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer
            ("data source=(localdb)\\MSSQLLocalDB;initial catalog=WorkUA;integrated security=True;MultipleActiveResultSets=true");

    public virtual DbSet<Employer> Employers { get; set; }
    public virtual DbSet<Branch> Branches { get; set; }
    public virtual DbSet<Job> Jobs { get; set; }
    public virtual DbSet<JobSeeker> JobSeekers { get; set; }
    public virtual DbSet<JobApplication> JobApplications { get; set; }
}