using System.Text.Json.Serialization;

namespace DB.Models;

public class Author
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    
    [JsonIgnore]
    public virtual ICollection<Book>? Books { get; set; } = new List<Book>();
    
    public Author() {}
    
    public Author(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
    
    public override string ToString()
        => $"{FirstName} {LastName}";
}