using Microsoft.AspNetCore.Mvc.RazorPages;
using Task2.Models;

public class SquareModel : PageModel
{
    public Square Square { get; set; }

    public void OnGet()
    {
        Square = new Square(5, "Blue");
    }
}