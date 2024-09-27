namespace DB.Models;

public class MyTask(string name, string location, string details)
{
    public int Id { get; set; }
    public string Name { get; set; } = name;
    public string Location { get; set; } = location;
    public string Details { get; set; } = details;
    public MyDate Date { get; set; }

    public override string ToString()
        => $"Name: {name}, Location: {location}, Details: {details}";
}