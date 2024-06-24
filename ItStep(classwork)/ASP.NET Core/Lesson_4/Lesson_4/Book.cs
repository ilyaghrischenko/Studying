namespace Lesson_4;

public class Book
{
    public string Name { get; set; }
    public string AuthorPIB { get; set; }
    public string Style { get; set; }
    public uint PublishingYear { get; set; }
    public decimal Price { get; set; }
    
    public Book() {}
    public Book(string name, string authorPib, string style, uint publishingYear, decimal price)
    {
        Name = name;
        AuthorPIB = authorPib;
        Style = style;
        PublishingYear = publishingYear;
        Price = price;
    }

    public override string ToString() 
        => $"Name: {Name}, Author pib: {AuthorPIB}, Style: {Style}," +
           $"Publishing year: {PublishingYear}, Price: {Price}";
}