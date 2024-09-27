using System.Text.Json.Serialization;

namespace DB.Models;

public class Book
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Author Author { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }

    public Book() { }

    public Book(string name, Author author, string description, decimal price)
    {
        Name = name;
        Author = author;
        Description = description;
        Price = price;
    }

    public override string ToString()
        => $"{Name} by {Author} - {Price}\n{Description}";
}