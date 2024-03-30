using System.Diagnostics;
using static System.Console;

namespace Lesson_1
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Process> processes = Process
                .GetProcesses()
                .ToList();
            foreach (var item in processes)
            {
                try
                {
                    WriteLine($"{item.Id} {item.ProcessName} {item.StartTime} Threads: {item.Threads}\n");
                }
                catch { }
            }

            WriteLine();
            ReadKey();
        }
    }
}