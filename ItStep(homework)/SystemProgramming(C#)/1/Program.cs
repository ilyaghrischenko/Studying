using System.Diagnostics;
using static System.Console;

namespace _1
{
    internal class Program
    {
        //task 1
        /*
        static void RunAndWait()
        {
            WriteLine("Starting child process...");
            Process process = new();
            process.StartInfo.FileName = "C:\\github\\Studying\\ItStep(homework)\\2 semester\\C#\\8\\bin\\Debug\\net8.0\\8.exe";
            process.Start();
            process.WaitForExit();
            WriteLine($"Child process finished with exit code: {process.ExitCode}");
        }
        static void RunAndKill()
        {
            WriteLine("Starting child process...");
            Process process = new Process();
            process.StartInfo.FileName = "C:\\github\\Studying\\ItStep(homework)\\2 semester\\C#\\8\\bin\\Debug\\net8.0\\8.exe";
            process.Start();

            if (!process.WaitForExit(2000))
            {
                process.Kill();
                WriteLine("The child process was forcibly terminated due to a timeout");
            }
            else
            {
                WriteLine($"Child process finished with exit code: {process.ExitCode}");
            }
        }
        */

        //task 2


        static void Main(string[] args)
        {
            //task 1
            /*
            Write("1. Start a child process and wait for it to complete\n" +
                  "2. Start a child process and force it to terminate\n" +
                  ": ");
            int choice = int.Parse(ReadLine());

            switch (choice)
            {
                case 1:
                    RunAndWait();
                    break;
                case 2:
                    RunAndKill();
                    break;
                default:
                    WriteLine("Invalid choice!");
                    break;
            }
            */

            //task 2
            
        }
    }
}
