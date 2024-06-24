using System.Text.Json;
using Lesson_5.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lesson_5.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public List<Cinema>? Cinemas { get; set; }
    public IActionResult OnGet()
    {
        using var file = System.IO.File.OpenRead("cinemas.json");
        Cinemas = JsonSerializer.Deserialize<List<Cinema>>(file);
        return Page();
    }
}