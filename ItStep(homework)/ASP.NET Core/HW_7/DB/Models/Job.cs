namespace DB.Models;

public class Job
{
    public int Id { get; set; }
    public string Title { get; set; }  
    public decimal Salary { get; set; }
    public bool IsRemote { get; set; }
    public int EmployerId { get; set; }
    public Employer Employer { get; set; }
}