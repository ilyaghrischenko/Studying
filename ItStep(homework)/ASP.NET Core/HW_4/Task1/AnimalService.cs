using System.Text.Json;
using Task1.Models;

namespace Task1;

public class AnimalService
{
    private const string FilePath = "animals.json";

    public void SaveAnimalsToFile(List<Animal> animals)
    {
        var options = new JsonSerializerOptions { WriteIndented = true };
        var json = JsonSerializer.Serialize(animals, options);
        File.WriteAllText(FilePath, json);
    }

    public List<Animal> LoadAnimalsFromFile()
    {
        if (!File.Exists(FilePath)) return new List<Animal>();

        var json = File.ReadAllText(FilePath);
        return JsonSerializer.Deserialize<List<Animal>>(json) ?? new List<Animal>();
    }
}