namespace DB.Models;

public class JobSeeker
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string ContactInfo { get; set; } 
    public List<JobApplication> JobApplications { get; set; } = new();
}