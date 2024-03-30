using System.Text.Json;
using static System.Console;

namespace _6
{
    internal class Program
    {
        static string filePath = "list.json";
        static List<int>? GetList()
        {
            return (File.Exists(filePath) && new FileInfo(filePath).Length != 0) ? JsonSerializer.Deserialize<List<int>>(File.ReadAllText(filePath)) : new();
        }

        static void Main(string[] args)
        {
            var list = GetList();
            int uniqueCount = list
                                  .Distinct()
                                  .Count();

            WriteLine($"List:");
            list
                .ForEach(x => Write($"{x} "));

            WriteLine($"\nUnique count: {uniqueCount}");
        }
    }
}
