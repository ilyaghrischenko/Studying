using System.Text.Json;
using static System.Console;

namespace _17
{
    internal class Program
    {
        //task 1
        /*
        static string prostPath = "prost.json";
        static string fibonPath = "fibonacchi.json";
        static bool IsProst(int value)
        {
            if (value <= 1) return false;
            if (value == 2) return true;
            if (value % 2 == 0) return false;
            for (int i = 3; i <= Math.Sqrt(value); i += 2)
            {
                if (value % i == 0) return false;
            }
            return true;
        }
        static bool IsFibon(int value)
        {
            return IsPerfectSquare(5 * value * value + 4) || IsPerfectSquare(5 * value * value - 4);
        }
        static bool IsPerfectSquare(int value)
        {
            int sqrt = (int)Math.Sqrt(value);
            return sqrt * sqrt == value;
        }
        */

        //task 2
        /*
        static string filePath = "text.txt";
        */

        //task 3
        /*
        static void Moderator(string textPath, string wordsForModeration)
        {
            List<string> moderationWords = File.ReadAllText(wordsForModeration)
                                                     .Split(" ,.!?;:".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                                                     .ToList();
            List<string> text = File.ReadAllText(textPath)
                                         .Split(" ,.!?;:".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                                         .ToList();

            List<string> newText = text;
            for (int i = 0; i < newText.Count; ++i)
            {
                foreach (var item in moderationWords)
                {
                    if (newText[i] == item) newText[i] = new string('*', newText[i].Length);
                }
            }

            File.WriteAllText(textPath, string.Join(' ', newText));
            WriteLine("Changed and saved!");
        }
        */

        //task 4
        /*
        static void SearchAndDeleteFiles(string directoryPath, string searchPattern)
        {
            if (!Directory.Exists(directoryPath)) throw new Exception($"Folder '{directoryPath}' does not exists.");

            string[] files = Directory.GetFiles(directoryPath, searchPattern, SearchOption.AllDirectories);

            foreach (string file in files)
            {
                try
                {
                    File.Delete(file);
                    WriteLine($"File '{file}' deleted.");
                }
                catch (Exception ex)
                {
                    WriteLine($"Error with deliting '{file}': {ex.Message}");
                }
            }

            WriteLine($"Count deleted files: {files.Length}");
        }
        */

        //task 5
        /*
        static void GenerateListAndSave(string path)
        {
            List<int> list = new();
            Random rnd = new();
            for (int i = 0; i < 100000; ++i)
            {
                list.Add(rnd.Next(-100000, 100000));
            }

            File.WriteAllText(path, JsonSerializer.Serialize(list));
        }
        static List<int>? GetListFromFile(string path)
        {
            return (File.Exists(path) && new FileInfo(path).Length > 0) ? JsonSerializer.Deserialize<List<int>>(File.ReadAllText(path)) : new();
        }
        static void ShowInfo(List<int> list)
        {
            int kilkDodat = list
                                .Where(x => x > 0)
                                .Count();
            int kilkVid = list
                              .Where(x => x < 0)
                              .Count();
            int kilk2Zn = list
                              .Where(x => x.ToString().Length == 2)
                              .Count();
            int kilk5Zn = list
                              .Where(x => x.ToString().Length == 5)
                              .Count();

            WriteLine($"Kilk dodat: {kilkDodat}\nKilk vid: {kilkVid}\nKilk 2 zn: {kilk2Zn}\nKilk 5 zn: {kilk5Zn}");
        }
        */

        //task 6
        /*
        static void MoveDirectory(string sourceDirectoryPath, string targetDirectoryPath)
        {
            if (!Directory.Exists(sourceDirectoryPath))
            {
                WriteLine($"Original folder '{sourceDirectoryPath}' does not exists.");
                return;
            }

            if (!Directory.Exists(targetDirectoryPath))
            {
                WriteLine($"Target folder '{targetDirectoryPath}' does not exists.");
                return;
            }

            try
            {
                string sourceDirectoryName = new DirectoryInfo(sourceDirectoryPath).Name;

                string newTargetDirectoryPath = Path.Combine(targetDirectoryPath, sourceDirectoryName);

                if (Directory.Exists(newTargetDirectoryPath))
                {
                    WriteLine($"Folder with name '{sourceDirectoryName}' already exists in target path.");
                    return;
                }

                Directory.Move(sourceDirectoryPath, newTargetDirectoryPath);

                WriteLine($"Folder successfuly moved to '{newTargetDirectoryPath}'.");
            }
            catch (Exception ex)
            {
                WriteLine($"Error: {ex.Message}");
            }
        }
        */

        static void Main(string[] args)
        {
            //task 1
            /*
            List<int> list = new();
            Random rnd = new();
            for (int i = 0; i < 100; ++i)
            {
                list.Add(rnd.Next(-10000, 10000));
            }

            WriteLine("List:");
            list
                .ForEach(WriteLine);

            var fibonList = list
                                .Where(IsFibon)
                                .ToList();
            var prostList = list
                                .Where(IsProst)
                                .ToList();

            WriteLine("\nFibonacchi list:");
            fibonList
                     .ForEach(x => Write($"{x} "));

            WriteLine("\nProst list:");
            prostList
                     .ForEach(x => Write($"{x} "));
            WriteLine();

            File.WriteAllText(fibonPath, JsonSerializer.Serialize(fibonList));
            File.WriteAllText(prostPath, JsonSerializer.Serialize(prostList));

            WriteLine("\nSaved to file!");
            */

            //task 2
            /*
            Write("Search word: ");
            string? search = ReadLine();

            Write("Replace word: ");
            string? replace = ReadLine();

            var text = File.ReadAllText(filePath);
            var tokens = text.Split(" ,.?!:;".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < tokens.Length; ++i)
            {
                if (tokens[i] == search) tokens[i] = replace;
            }

            string newText = string.Join(' ', tokens);
            File.WriteAllText(filePath, newText);

            WriteLine("\nReplaced and saved!");
            WriteLine($"New text: {newText}");
            */

            //task 3
            /*
            Moderator("textFile.txt", "moderation.txt");
            */

            //task 4
            /*
            SearchAndDeleteFiles("C:\\github\\Studying\\ItStep(homework)\\2 semester\\C#\\17\\bin\\Debug\\net8.0\\FOLDER", "*.txt");
            */

            //task 5
            /*
            string path = "Collection.json";
            GenerateListAndSave(path);

            var list = GetListFromFile(path);
            WriteLine("List:");
            list?.ForEach(WriteLine);

            ShowInfo(list);
            */

            //task 6
            /*
            MoveDirectory("C:\\github\\Studying\\ItStep(homework)\\2 semester\\C#\\17\\bin\\Debug\\net8.0\\myFolder", "C:\\github\\Studying\\ItStep(homework)\\2 semester\\C#\\17\\bin\\Debug\\net8.0\\FOLDER");
            */
        }
    }
}
