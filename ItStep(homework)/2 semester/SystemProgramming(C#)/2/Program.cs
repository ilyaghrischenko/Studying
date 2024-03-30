using static System.Console;

namespace _2
{
    internal class Program
    {
        //task 1,2
        /*
        static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
            {
                if (number % i == 0) return false;
            }

            return true;
        }
        static bool IsPerfectSquare(int n)
        {
            int sqrt = (int)Math.Sqrt(n);
            return sqrt * sqrt == n;
        }
        static bool IsFibonacci(int n)
        {
            return IsPerfectSquare(5 * n * n + 4) || IsPerfectSquare(5 * n * n - 4);
        }
        static void GeneratePrimesInRange(int start, int? end)
        {
            for (int number = start; number <= end || end == null; ++number)
            {
                if (IsPrime(number))
                {
                    WriteLine(number);
                }
            }
        }
        static void GenerateFibonnachiInRange(int start, int? end)
        {
            for (int number = start; number <= end || end == null; ++number)
            {
                if (IsFibonacci(number))
                {
                    WriteLine(number);
                }
            }
        }
        */

        //task 3
        /*
        static void CalcAndShow(string? path, string? word)
        {
            if (path == string.Empty || word == string.Empty)
            {
                WriteLine("Path or word is null.");
                return;
            }
            if (!File.Exists(path) || new FileInfo(path).Length == 0)
            {
                WriteLine("File does not exist or empty.");
                return;
            }

            string fileContent = File.ReadAllText(path);
            int count = fileContent
                           .Split(" ,.?!:;".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                           .ToList()
                           .Where(x => x == word)
                           .Count();
            WriteLine($"Count: {count}");
        }
        */
        static void Main(string[] args)
        {
            //task 1,2
            /*
            WriteLine("Enter start (default - 2):");
            string startInput = ReadLine();
            int start = string.IsNullOrEmpty(startInput) ? 2 : int.Parse(startInput);

            WriteLine("Enter end (leave blank for infinite generation):");
            string endInput = ReadLine();
            int? end = string.IsNullOrEmpty(endInput) ? null : int.Parse(endInput);

            Write("1 - Prost\n2 - Fibonnachi\n: ");
            int choice = int.Parse(ReadLine());

            Thread t;
            if (choice == 1) t = new(() => GeneratePrimesInRange(start, end));
            else t = new(() => GenerateFibonnachiInRange(start, end));
            t.Start();
            t.Join();
            */

            //task 3
            /*
            Write("Path: ");
            string? path = ReadLine();
            Write("Searching word: ");
            string? word = ReadLine();

            Thread t = new(() => CalcAndShow(path, word));
            t.Start();
            t.Join();
            */
        }
    }
}
