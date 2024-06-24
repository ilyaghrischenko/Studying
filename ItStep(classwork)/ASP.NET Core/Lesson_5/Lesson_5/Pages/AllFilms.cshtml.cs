using System.Text.Json;
using Lesson_5.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lesson_5.Pages;

public class AllFilms : PageModel
{
    public List<Film> Films { get; set; } = new();
    public string CinemaName { get; set; }
    
    public IActionResult OnGet(string name)
    {
        var currentCinema = CinemasStatic.Cinemas.First(x => x.Name == name);
        CinemaName = currentCinema.Name;
        Films = currentCinema.Films;
        return Page();
    }
}