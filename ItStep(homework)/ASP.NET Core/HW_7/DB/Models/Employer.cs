namespace DB.Models;

public class Employer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public List<Branch> Branches { get; set; } = new();
    public List<Job> Jobs { get; set; } = new List<Job>();
}