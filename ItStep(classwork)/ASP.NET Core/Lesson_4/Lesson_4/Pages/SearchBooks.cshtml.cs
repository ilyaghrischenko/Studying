using System.Text.Json;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lesson_4.Pages;

public class SearchBooks : PageModel
{
    public List<Book> AllBooks { get; set; }
    
    public void OnGet()
    {
        using var file = System.IO.File.OpenRead("books.json");
        AllBooks = JsonSerializer.Deserialize<List<Book>>(file) ?? new();
    }

    public string Style { get; set; }
    public uint PublishingYear { get; set; }
    public string Name { get; set; }
    
    public List<Books>? FindedBooks { get; set; }
    
    public void OnPost(string name)
    {
        var findedBooks = AllBooks.Where(x=>x.)
    }
    public void OnPost(uint publishingYear)
    {
        
    }
}