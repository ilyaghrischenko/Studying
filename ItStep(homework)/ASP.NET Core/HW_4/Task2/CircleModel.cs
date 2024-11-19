using Microsoft.AspNetCore.Mvc.RazorPages;
using Task2.Models;

public class CircleModel : PageModel
{
    public Circle Circle { get; set; }

    public void OnGet()
    {
        Circle = new Circle(5, "Red"); 
    }
}