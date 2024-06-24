namespace Lesson_5.Models;

public class Cinema
{
    public string Name { get; set; }
    public string City { get; set; }
    public List<Film> Films { get; set; }
    
    public Cinema() {}
    public Cinema(string name, string city, List<Film> films)
    {
        Name = name;
        City = city;
        Films = films;
    }
    
    public override string ToString()
    {
        return $"{Name} ({City})";
    }
}