using Library;
using static System.Console;

namespace LabWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            Class1.ShowInfo("MESSAGE");
            WriteLine();
            ReadKey();
            //2
            if (Class1.IsLeap(2024))
            {
                WriteLine("Year is leap.");
            }
            else WriteLine("Year is not leap.");
            WriteLine();
            ReadKey();
            //3
            Class1.ShowStatistic(new() { 4, 10, 3 });
            WriteLine();
            ReadKey();
            //4
            User user = new("IHV", 18, "+380970878346", "email@gmail.com");
            if (Class2.IsCorrectPib(user.Pib)) WriteLine("Pib correct!");
            if (Class2.IsCorrectAge(user.Age.ToString())) WriteLine("Age correct!");
            if (Class2.IsCorrectPhone(user.Phone)) WriteLine("Phone correct!");
            if (Class2.IsCorrectEmail(user.Email)) WriteLine("Email correct!");
            WriteLine();
            ReadKey();
            //5
            Drib d1 = new(2, 3);
            Drib d2 = new(5, 6);
            var result1 = Class2.Multiply(d1, d2);
            var result2 = Class2.Divide(d1, d2);
            WriteLine($"First: {d1}");
            WriteLine($"Second: {d2}");
            WriteLine($"Mult: {result1}");
            WriteLine($"Div: {result2}");
            WriteLine();
            ReadKey();
        }
    }
}
