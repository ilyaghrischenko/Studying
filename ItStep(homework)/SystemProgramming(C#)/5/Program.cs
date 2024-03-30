using static System.Console;

namespace _5
{
    internal class Program
    {
        //task 1,2
        /*
        static string GetStatistic(string data, int choice)
        {
            int countSentences = data
                                    .Split(".!?".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                                    .Count();
            int countSymbols = data.Length;
            int countWords = data
                                 .Split(" ,.!?;:".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                                 .Count();
            int countInterrogativesSen = data
                                             .Where(x => x == '?')
                                             .Count();
            int countExclamatorySen = data
                                          .Where(x => x == '!')
                                          .Count();

            if (choice == 0)
            {
                return $"Sentences: {countSentences}\n" +
                    $"Symbols: {countSymbols}\n" +
                    $"Words: {countWords}\n" +
                    $"Interrogatives: {countInterrogativesSen}\n" +
                    $"Exclamatory: {countExclamatorySen}";
            }
            else if (choice == 1)
            {
                return $"Sentences: {countSentences}\n" +
                       $"Words: {countWords}";
            }
            else if (choice == 2)
            {
                return $"Symbols: {countSymbols}\n" +
                       $"Sentences: {countSentences}";
            }
            else if (choice == 3)
            {
                return $"Interrogatives: {countInterrogativesSen}\n" +
                       $"Exclamatory: {countExclamatorySen}";
            }
            else
            {
                throw new Exception("Error: Invalid choice.");
            }
        }
        static void Save(string path, string statistic)
        {
            File.WriteAllText(path, statistic);
        }
        */

        static void Main(string[] args)
        {
            //task 1,2
            /*
            try
            {
                Task.Run(() =>
                {
                    int choice = -1;
                    Write("1. File statistics\n2. Input statistics\n: ");
                    choice = int.Parse(ReadLine());

                    string text;
                    if (choice == 1)
                    {
                        Write("Path: ");
                        string path = ReadLine();
                        text = File.ReadAllText(path);
                        WriteLine("Data red from file.");
                    }
                    else if (choice == 2)
                    {
                        Write("Enter text: ");
                        text = ReadLine();
                    }
                    else
                    {
                        WriteLine("Invalid choice.");
                        return;
                    }

                    Write("0. All\n1. Sentences and words\n2. Symbols and sentences\n3. Interrogatives and Exclamatory\n: ");
                    int statisticsChoice = int.Parse(ReadLine());

                    string result = GetStatistic(text, statisticsChoice);
                    WriteLine($"Result:\n{result}");

                    Write("1. Save\n2. No\n: ");
                    choice = int.Parse(ReadLine());
                    if (choice == 1)
                    {
                        Write("Path: ");
                        string path = ReadLine();
                        Save(path, result);
                        WriteLine("Saved.");
                    }
                }).Wait();
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message);
            }
            */
        }
    }
}
