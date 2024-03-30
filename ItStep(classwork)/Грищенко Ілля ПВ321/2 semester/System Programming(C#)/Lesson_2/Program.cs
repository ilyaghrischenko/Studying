using static System.Console;

namespace Lesson_2
{
    internal class Program
    {
        //task 1
        /*
        static void ThreadMethod(object obj)
        {
            var range = (Range)obj;
            for (int i = range.Start; i <= range.End; ++i)
            {
                WriteLine($"{Thread.CurrentThread.ManagedThreadId}: {i}");
            }
        }
        */

        //task 2
        /*
        static void FindMax(object obj)
        {
            var list = (List<int>)obj;
            int max = list
                .Where(x => x % 2 != 0)
                .Max();
            WriteLine($"Max: {max}");
        }

        static bool IsPrime(int number)
        {
            if (number <= 1)
                return false;
            if (number == 2)
                return true;
            if (number % 2 == 0)
                return false;

            int boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }
        static void FindMin(object obj)
        {
            var list = (List<int>)obj;
            int min = list
                .Where(IsPrime)
                .Min();
            WriteLine($"Min: {min}");
        }

        static void FindAverage(object obj)
        {
            var list = (List<int>)obj;
            double avg = list
                .Where(x => !IsPrime(x))
                .Average();
            WriteLine($"Average: {avg}");
        }
        */

        static void Main(string[] args)
        {
            //task 1
            /*
            Write("Start: ");
            int start = int.Parse(ReadLine());
            Write("End: ");
            int end = int.Parse(ReadLine());
            Range range = new() { Start = start, End = end };

            Thread thread = new Thread(ThreadMethod);
            WriteLine("Thread started\n");
            thread.Start(range);
            thread.Join();
            WriteLine("\nThread ended");
            */

            //task 2
            /*
            List<int> list = new();
            for (int i = 0; i < 10000; ++i)
            {
                list.Add(new Random().Next(-100, 100));
            }

            Thread thread1 = new(FindMax);
            Thread thread2 = new(FindMin);
            Thread thread3 = new(FindAverage);

            thread1.Start(list);
            thread2.Start(list);
            thread3.Start(list);
            thread1.Join();
            thread2.Join();
            thread3.Join();
            */

            //task 3
            /*
            Random random = new Random();
            Thread createInt = new(obj =>
            {
                List<int> list = new();
                for (int i = 0; i < 100; ++i)
                {
                    list.Add(random.Next(-100, 100));
                }

                list
                    .ForEach(x => WriteLine($"{Thread.CurrentThread.ManagedThreadId}: {x}"));
            });
            Thread createString = new(obj =>
            {
                string tokens = "qwertyuiopasdfghjklzxcvbnm";
                List<char> list = new();
                for (int i = 0; i < 100; ++i)
                {
                    list.Add(tokens[random.Next(tokens.Length)]);
                }

                list
                    .ForEach(x => WriteLine($"{Thread.CurrentThread.ManagedThreadId}: {x}"));
            });
            Thread createSymbols = new(obj =>
            {
                string symbols = "!@#$%^&*()_+[]|;',./<>?:{}~";
                List<char> list = new();
                for (int i = 0; i < 100; ++i)
                {
                    list.Add(symbols[random.Next(symbols.Length)]);
                }

                list
                    .ForEach(x => WriteLine($"{Thread.CurrentThread.ManagedThreadId}: {x}"));
            });

            createInt.Priority = ThreadPriority.Highest;
            createString.Priority = ThreadPriority.Lowest;
            createSymbols.Priority = ThreadPriority.Normal;

            createInt.Start();
            createString.Start();
            createSymbols.Start();

            createInt.Join();
            createString.Join();
            createSymbols.Join();
            */
        }
    }
}
