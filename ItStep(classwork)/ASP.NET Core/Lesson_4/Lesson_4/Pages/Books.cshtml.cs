using System.Text.Json;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lesson_4.Pages;

public class Books : PageModel
{
    public List<Book> AllBooks { get; set; }
    
    public void OnGet()
    {
        using var file = System.IO.File.OpenRead("books.json");
        AllBooks = JsonSerializer.Deserialize<List<Book>>(file) ?? new();
    }
}