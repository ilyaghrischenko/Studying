using Microsoft.VisualBasic;
using System.Text;
using System.Text.Json;
using static System.Console;

namespace Lesson_3
{
    internal class Program
    {
        //task 1
        /*
        static int[] numbers = new int[1000];
        static object lockObject = new object();
        */

        static void Main(string[] args)
        {
            //task 1
            /*
            Random rand = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rand.Next(-2370, 5001);
            }

            Thread thread1 = new Thread(obj =>
            {
                int max = int.MinValue;

                lock (lockObject)
                {
                    for (int i = 0; i < numbers.Length; i += 3)
                    {
                        if (numbers[i] % 3 == 0 && numbers[i] > max)
                        {
                            max = numbers[i];
                        }
                    }
                    numbers[numbers.Length - 1] = max;
                }

                WriteLine("Max % 3: " + max);
            });
            Thread thread2 = new Thread(obj =>
            {
                int min = int.MaxValue;

                lock (lockObject)
                {
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        if (numbers[i] % 7 == 0 && numbers[i] >= 100 && numbers[i] <= 999 && numbers[i] < min)
                        {
                            min = numbers[i];
                        }
                    }
                    numbers[0] = min;
                }

                WriteLine("Min 3 digits number % 7: " + min);
            });
            Thread thread3 = new Thread(obj =>
            {
                double sum = 0;
                int count = 0;
                double average = 0;

                lock (lockObject)
                {
                    for (int i = numbers.Length / 2; i < numbers.Length; i++)
                    {
                        sum += numbers[i];
                        count++;
                    }
                    average = sum / count;
                    numbers[numbers.Length / 2] = (int)average;
                }

                WriteLine("Average among the numbers of the second half of the collection: " + average);
            });

            thread1.Start();
            thread2.Start();
            thread3.Start();

            Thread.Sleep(100);
            WriteLine();

            numbers
                .ToList()
                .ForEach(x => Write($"{x} "));
            */

            //task 2
            try
            {
                Thread t1 = new(obj =>
                {
                    string path = obj.ToString();
                    if (!File.Exists(path) || new FileInfo(path).Length == 0) throw new Exception("Error: File does not exist");

                    string? jsonContent = JsonSerializer.Deserialize<string>(File.ReadAllText(path));
                    string[] sentences = jsonContent.Split(".?!".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                    WriteLine($"Sentences count: {sentences.Length}");
                });

                Thread t2 = new(obj =>
                {

                })
            }
            catch (Exception e)
            {
                WriteLine(e.Message);
            }
        }
    }
}
