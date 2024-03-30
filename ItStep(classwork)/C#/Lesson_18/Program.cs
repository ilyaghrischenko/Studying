using System.Text.Json;
using System.Xml.Serialization;
using static System.Console;

namespace Lesson_18
{
    internal class Program
    {
        static bool IsPrime(int number)
        {
            if (number <= 1)
                return false;

            if (number == 2)
                return true;

            if (number % 2 == 0)
                return false;

            for (int i = 3; i <= Math.Sqrt(number); i += 2)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }

        static void Main(string[] args)
        {
            //task 1
            /*
            List<int> ints = new();
            Random rnd = new Random();
            for (int i = 0; i < rnd.Next(5, 20); ++i)
            {
                ints.Add(rnd.Next(1, 100));
            }

            int choice = -1;
            while (choice != 0)
            {
                ints
                    .ForEach(x => Write(x + " "));
                WriteLine("\n");

                Write("0 - Exit\n1 - Add random numbers\n2 - Get 2 lists: prime and nonprimary\n3 - Serialize\n4 - Save to file\n5 - Desirialize to obj\n: ");
                choice = int.Parse(ReadLine() ?? "0");
                switch (choice)
                {
                    case 1:
                        Write("Enter size: ");
                        int size = int.Parse(ReadLine() ?? "3");

                        Random random = new();
                        for (int i = 0; i < size; ++i)
                        {
                            ints.Add(random.Next(-100, 100));
                        }
                        break;
                    case 2:
                        List<int> primary = ints
                            .Where(x => IsPrime(x))
                            .ToList();
                        List<int> nonprimary = ints
                            .Where(x => !IsPrime(x))
                            .ToList();

                        WriteLine("Primary list:");
                        primary
                            .ForEach(x => Write(x + " "));
                        WriteLine("\n");

                        WriteLine("Nonprimary list:");
                        nonprimary
                            .ForEach(x => Write(x + " "));
                        break;
                    case 3:
                        string jsonString = JsonSerializer.Serialize(ints);
                        WriteLine($"JSON serialized: {jsonString}");
                        break;
                    case 4:
                        jsonString = JsonSerializer.Serialize(ints);
                        File.WriteAllText("jsonInts.json", jsonString);

                        XmlSerializer serializer = new XmlSerializer(typeof(List<int>));
                        serializer.Serialize(File.OpenWrite("xmlInts.txt"), ints);
                        
                        WriteLine("Saved!");
                        break;
                    case 5:
                        jsonString = JsonSerializer.Serialize(ints);
                        ints = JsonSerializer.Deserialize<List<int>>(jsonString);
                        WriteLine($"JSON: {ints}");

                        serializer = new XmlSerializer(typeof(List<int>));
                        ints = (List<int>)serializer.Deserialize(File.OpenRead("xmlInts.txt"));
                        WriteLine($"XML: {ints}");
                        break;
                }
                WriteLine();
                ReadKey();
                Clear();
            }
            */

            //task 2
            /*
            MusicAlbum musicAlbum = null;
            bool isEmpty = true;
            try
            {
                if (File.Exists("musicAlbum.json"))
                {
                    musicAlbum = JsonSerializer.Deserialize<MusicAlbum>(File.OpenRead("musicAlbum.json"));
                    isEmpty = false;
                }

                int choice = -1;
                while (choice != 0)
                {
                    Write("0 - Exit\n1 - Show\n2 - Input\n3 - Serialize and save\n4 - Deserialize from file\n: ");
                    choice = int.Parse(ReadLine() ?? "0");

                    switch (choice)
                    {
                        case 1:
                            if (!isEmpty) musicAlbum.Show();
                            break;
                        case 2:
                            if (isEmpty)
                            {
                                musicAlbum = new();
                            }
                            musicAlbum.Input();
                            break;
                        case 3:
                            string json = JsonSerializer.Serialize(musicAlbum);
                            File.WriteAllText("musicAlbum.json", json);
                            WriteLine("Saved");
                            break;
                        case 4:
                            MusicAlbum fromFile = JsonSerializer.Deserialize<MusicAlbum>(File.OpenRead("musicAlbum.json"));
                            fromFile.Show();
                            break;
                    }
                    WriteLine();
                    ReadKey();
                    Clear();
                }
            }
            catch (Exception e)
            {
                WriteLine(e.Message);
            }
            */
        }
    }
}
