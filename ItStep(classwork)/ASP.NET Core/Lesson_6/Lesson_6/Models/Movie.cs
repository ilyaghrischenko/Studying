namespace Lesson_6.Models;

public class Movie
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Director { get; set; }
    public string Genre { get; set; }
    
    public Movie() {}
    public Movie(string title, string director, string genre)
    {
        Title = title;
        Director = director;
        Genre = genre;
    }

    public override string ToString()
        => $"Title: {Title}, Director: {Director}, Genre: {Genre}";
}