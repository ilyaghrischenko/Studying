namespace WebMVC_2.Models;

public class Publisher
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string? Country { get; set; }
    
    public virtual ICollection<Book>? Books { get; set; } = new List<Book>();
}