namespace DB.Models;

public class Branch
{
    public int Id { get; set; }
    public string Location { get; set; }
    public int EmployerId { get; set; }
    public Employer Employer { get; set; }
}