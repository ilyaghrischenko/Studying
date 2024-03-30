using System.Text.Encodings.Web;
using static System.Console;

namespace Lesson_5
{
    internal class Program
    {
        static bool IsPrime(int number)
        {
            if (number <= 1)
                return false;

            if (number <= 3)
                return true;

            if (number % 2 == 0 || number % 3 == 0)
                return false;

            for (int i = 5; i * i <= number; i += 6)
            {
                if (number % i == 0 || number % (i + 2) == 0)
                    return false;
            }

            return true;
        }
        static uint PrimeCount(int start, int end)
        {
            uint count = 0;
            for (int i = start; i <= end; i++)
            {
                if (IsPrime(i)) ++count;
            }
            return count;
        }
        static bool IsFibonacci(int number)
        {
            int a = 0, b = 1;
            while (b < number)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return b == number;
        }

        static void Main(string[] args)
        {
            //task 1
            /*
            Task task1 = new(() =>
            {
                Thread.Sleep(2000);
                WriteLine($"Task1\n{DateTime.Now}\n");
            });
            task1.Start();
            task1.Wait();

            Task.Factory.StartNew(() =>
            {
                Thread.Sleep(300);
                WriteLine($"Task2\n{DateTime.Now}\n");
            }).Wait();

            Task.Run(() =>
            {
                Thread.Sleep(5050);
                WriteLine($"Task3\n{DateTime.Now}\n");
            }).Wait();
            */

            //task 2,3
            /*
            Random random = new();
            int start = random.Next(1, 50);
            int end = random.Next(50, 100);

            Task<uint> primeTask = Task.Run(() => PrimeCount(start, end));

            uint primeCount = primeTask.Result;
            WriteLine($"Count prime numbers between {start} and {end}: {primeCount}");
            */

            //task 4
            /*
            Random random = new();
            List<int> list = new();
            for (int i = 0; i < random.Next(10, 40); ++i)
            {
                list.Add(random.Next(1, 100000));
            }

            List<Task<object?>> tasks = new()
            {
                Task.Run(() =>
                {
                    var newList = list.Where(x => IsFibonacci(x) && x > 213);
                    return (newList!=null)?(object)newList.ToList():null;
                }),
                Task.Run(() =>
                {
                    var newList = list.Where(x => IsPrime(x) && x % 28 == 0).ToList();
                    return (newList != null && newList.Count > 0) ? (object)newList.Max() : null;
                }),
                Task.Run(() =>
                {
                    var newList = list
                                      .Where(x => x.ToString().Split().Contains("1") && x.ToString().Split().Contains("7"));
                    return (newList!=null) ? (object)list.Average() : null;
                }),
                Task.Run(() =>
                {
                    WriteLine("Start: ");
                    int start = int.Parse(ReadLine());
                    WriteLine("End: ");
                    int end = int.Parse(ReadLine());

                    int sum = 0;
                    foreach (var item in list)
                    {
                        sum += item;
                    }
                    return (sum != null) ? (object)sum : null;
                })
            };
            Task.WaitAll(tasks.ToArray());

            if (tasks[0].Result == null || (tasks[0].Result as List<int>)?.Count == 0) WriteLine($"{tasks[0].Id}: null");
            else
            {
                WriteLine($"{tasks[0].Id}:");
                (tasks[0].Result as List<int>)?
                                               .ForEach(x => Write($"{x} "));
            }
            for (int i = 1; i < tasks.Count; ++i)
            {
                var result = tasks[i].Result;
                if (result == null) result = "null";
                WriteLine($"{tasks[i].Id}: {result}");
            }
            */

            //task 5

        }
    }
}
