using System.Text.Json;

namespace Lesson_5.Models;

public static class CinemasStatic
{
    public static List<Cinema>? Cinemas = JsonSerializer.Deserialize<List<Cinema>>(File.ReadAllText("cinemas.json"));
}