using Task1;
using Task1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class AnimalsModel : PageModel
{
    private readonly AnimalService _animalService;

    public List<Animal> Animals { get; set; }

    public AnimalsModel()
    {
        _animalService = new AnimalService();
        Animals = new List<Animal>
        {
            new Cat("Kitty"),
            new Dog("Buddy")
        };
    }

    public void OnGet()
    {
        
    }

    public IActionResult OnPost(string action)
    {
        if (action == "save")
        {
            _animalService.SaveAnimalsToFile(Animals);
        }
        else if (action == "load")
        {
            Animals = _animalService.LoadAnimalsFromFile();
        }

        return Page();
    }
}