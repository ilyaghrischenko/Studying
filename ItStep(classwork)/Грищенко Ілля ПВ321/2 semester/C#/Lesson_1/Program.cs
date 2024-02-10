using System;

namespace Lesson_1
{
    internal class Program
    {
        static public void Reverse(string str)
        {
            for (int i = str.Length - 1; i > -1; i--)
            {
                Console.Write(str[i]);
            }
        }
        static public void ShowFibonachi(int start = 0, int end = 10)
        {
            int a = 0, b = 1, c;
            Console.WriteLine("Fibonachi numbers:");
            for (int i = start; i < end; i++) 
            {
                while (a <= end)
                {
                    if (a >= start) Console.Write(a + " ");
                    c = a + b;
                    a = b;
                    b = c;
                }
            }
        }

        static void Main(string[] args)
        {
            //task 1
            /*
            Console.WriteLine("It's easy to win forgiveness for being wrong;\nbeing right is what gets you into real trouble.\nBjarne Stroustrup");
            */

            //task 2
            /*
            int num = 0;
            int sum = 0;
            int dob = 1;
            int max = int.MinValue;
            int min = int.MaxValue;
            for (int i = 0; i < 5; ++i)
            {
                Console.Write("Enter a value: ");
                num = Convert.ToSingle(Console.ReadLine());
                sum += num;
                dob *= num;
                if (num > max) max = num;
                if (num < min) min = num;
            }

            Console.WriteLine($"\nSum - {sum} Dob - {dob} Max - {max} Min - {min}");
            */

            //task 3
            /*
            string num;
            do
            {
                Console.Write("Enter 6 significant number: ");
                num = Console.ReadLine();
            } while (num.Length != 6);
            Reverse(num);
            */

            //task 4
            /*
            ShowFibonachi(2, 40);
            */

            //task 5
            int a, b;
            Console.Write("Enter start: ");
            a=

            for(int i= a; i < b; ++i)
            {

            }
            
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}