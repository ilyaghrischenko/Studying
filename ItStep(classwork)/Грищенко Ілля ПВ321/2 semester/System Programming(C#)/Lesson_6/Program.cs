using System.ComponentModel;
using System.Text.Json;
using System.Text.Json.Nodes;
using static System.Console;

namespace Lesson_6
{
    internal class Program
    {
        //task 1,2
        /*
        static long CalcFactorial(int n)
        {
            if (n <= 0) return 1;

            long res = 1;
            Parallel.For(2, n + 1, i =>
            {
                res *= i;
            });
            return res;
        }
        static int CalcCount(long n)
        {
            return n.ToString().Length;
        }
        static int CalcSum(long n)
        {
            int sum = 0;
            while (n != 0)
            {
                sum += (int)(n % 10);
                n /= 10;
            }
            return sum;
        }
        */

        //task 3
        /*
        static string filePath = "table.json";
        static void ShowAndSaveTable(int start, int end)
        {
            string[] table = new string[end - start + 1];
            Parallel.For(start, end + 1, i =>
            {
                for (int j = 1; j <= 10; j++)
                {
                    table[i - start] += $"{i} * {j} = {i * j}\n";
                }
            });

            string t = string.Join('\n', table);
            WriteLine($"Table:\n{t}");
            File.WriteAllText(filePath, JsonSerializer.Serialize(t));
        }
        */

        //task 4,5
        /*
        static string filePath = "list.json";
        static List<int>? GetList()
        {
            return (File.Exists(filePath)) ? JsonSerializer.Deserialize<List<int>>(File.ReadAllText(filePath)) : new();
        }
        */

        static void Main(string[] args)
        {
            //task 1,2
            /*
            int number = new Random().Next(1, 10);
            long factorial = CalcFactorial(number);
            int digitCount = 0;
            int digitSum = 0;

            Task.Run(() => CalcFactorial(number)).ContinueWith((task) =>
            {
                Parallel.Invoke(
                        () => digitCount = CalcCount(task.Result),
                        () => digitSum = CalcSum(task.Result)
                    );
            }
            );

            WriteLine($"Number: {number}\nFactorial: {factorial}\nDigit count: {digitCount}\nDigit sum: {digitSum}");
            */

            //task 3
            /*
            ShowAndSaveTable(1, 4);
            */

            //task 4
            /*
            var list = GetList();
            var result = new List<int>();

            Parallel.ForEach(list, n =>
            {
                int res = 1;
                for (int i = 2; i <= n; i++)
                {
                    res *= i;
                }
                result.Add(res);
            });

            WriteLine("Factorials:");
            result.ForEach(x => Write($"{x} "));
            */

            //task 5
            /*
            var list = GetList();
            list.Sort();

            int sum = list
                          .AsParallel()
                          .Sum(i => i);
            int max = list
                          .AsParallel()
                          .Max(Math.Abs);
            int min = list
                          .AsParallel()
                          .Where(i => i % 7 == 0)
                          .Min();

            WriteLine($"List:");
            list
                .ForEach(x => Write($"{x} "));
            WriteLine();
            WriteLine($"Sum: {sum}\nMax: {max}\nMin: {min}");
            */
        }
    }
}
