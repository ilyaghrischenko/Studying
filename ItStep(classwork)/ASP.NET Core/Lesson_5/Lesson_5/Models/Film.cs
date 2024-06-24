using System.Text;

namespace Lesson_5.Models;

public class Film(string name, string director, string style, string shortDescription, List<Session>? sessions = null)
{
    public string Name { get; set; } = name;
    public string Director { get; set; } = director;
    public string Style { get; set; } = style;
    public string ShortDescription { get; set; } = shortDescription;
    public List<Session>? Sessions { get; set; } = sessions;
    
    public override string ToString()
    {
        StringBuilder res = new();
        res.Append($"Name: {Name}, Director: {Director}, Style: {Style}, Short description: {ShortDescription}\n");
        if (Sessions != null) res.Append($"Sessions: [{string.Join("\n", Sessions)}]");
        return res.ToString();
    }
}