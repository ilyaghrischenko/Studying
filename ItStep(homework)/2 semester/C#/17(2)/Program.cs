using System.Text.Json;
using static System.Console;

namespace _17_2_
{
    internal class Program
    {
        //task 1
        /*
        static List<Drib>? InputList(int count)
        {
            List<Drib> list = new();
            int chiselnik, znamenik;
            for (int i = 0; i < count; ++i)
            {
                Write("Chiselnik: ");
                chiselnik = int.Parse(ReadLine());
                Write("Znamenik: ");
                znamenik = int.Parse(ReadLine());

                list.Add(new Drib(chiselnik, znamenik));
            }

            return list;
        }
        static void SaveList(List<Drib> list, string path)
        {
            File.WriteAllText(path, JsonSerializer.Serialize(list));
        }
        static List<Drib>? GetFromFile(string path)
        {
            return (File.Exists(path) && new FileInfo(path).Length > 0) ? JsonSerializer.Deserialize<List<Drib>>(File.ReadAllText(path)) : new();
        }
        */

        //task 2,3
        /*
        static void Save(Magazine magazine, string path)
        {
            File.WriteAllText(path, JsonSerializer.Serialize(magazine));
        }
        static Magazine? GetFromFile(string path)
        {
            return (File.Exists(path) && new FileInfo(path).Length > 0) ? JsonSerializer.Deserialize<Magazine>(File.ReadAllText(path)) : null;
        }
        */

        //task 4
        static void Save(List<Magazine> list, string path)
        {
            File.WriteAllText(path, JsonSerializer.Serialize(list));
        }
        static List<Magazine>? GetFromFile(string path)
        {
            return (File.Exists(path) && new FileInfo(path).Length > 0) ? JsonSerializer.Deserialize<List<Magazine>>(File.ReadAllText(path)) : null;
        }

        static void Main(string[] args)
        {
            //task 1
            /*
            int choice = -1;
            List<Drib>? list = null;
            while (choice != 0)
            {
                Write("0 - Exit\n1 - Input list\n2 - Serialize\n3 - Save\n4 - Get from file\n: ");
                choice = int.Parse(ReadLine());

                switch (choice)
                {
                    case 1:
                        Write("Enter count: ");
                        int count = int.Parse(ReadLine());
                        list = InputList(count);
                        WriteLine("List:");
                        list?.ForEach(WriteLine);
                        break;
                    case 2:
                        if (list == null)
                        {
                            WriteLine("List is null");
                            break;
                        }
                        WriteLine($"Serialized list: {JsonSerializer.Serialize(list)}");
                        break;
                    case 3:
                        if (list == null)
                        {
                            WriteLine("List is null");
                            break;
                        }
                        SaveList(list, "list.json");
                        WriteLine("Saved!");
                        break;
                    case 4:
                        list = GetFromFile("list.json");
                        WriteLine("Data was read from a file!");
                        break;
                }

                if (choice != 0)
                {
                    ReadKey();
                    Clear();
                }
            }
            */

            //task 2,3,4
            int choice = -1;
            List<Magazine>? list = null;
            while (choice != 0)
            {
                Write("0 - Exit\n1 - Input\n2 - Show\n3 - Serialize\n4 - Save\n5 - Get from file\n: ");
                choice = int.Parse(ReadLine());

                switch (choice)
                {
                    case 1:
                        if (list == null) list = new();
                        Write("Count: ");
                        int count = int.Parse(ReadLine());
                        for (int i = 0; i < count; ++i)
                        {
                            list.Add(new Magazine());
                            list[i].Input();
                            WriteLine();
                        }
                        break;
                    case 2:
                        if (list == null)
                        {
                            WriteLine("List is null");
                            break;
                        }
                        WriteLine("List:");
                        foreach (var item in list)
                        {
                            item.Show();
                        }
                        break;
                    case 3:
                        if (list == null)
                        {
                            WriteLine("List is null");
                            break;
                        }
                        WriteLine($"Serialized list: {JsonSerializer.Serialize(list)}");
                        break;
                    case 4:
                        if (list == null)
                        {
                            WriteLine("List is null");
                            break;
                        }
                        Save(list, "list.json");
                        WriteLine("Saved!");
                        break;
                    case 5:
                        list = GetFromFile("list.json");
                        if (list == null)
                        {
                            WriteLine("File does not exists or empty");
                            break;
                        }
                        WriteLine("Data red from file");
                        break;
                }

                if (choice != 0)
                {
                    ReadKey();
                    Clear();
                }
            }
        }
    }
}