using static System.Console;

namespace _7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task 1
            /*
            try
            {
                Magazine mag1 = new Magazine();
                WriteLine("Default constructor:");
                mag1.Show();

                Magazine mag2 = new Magazine("Magazine1", 2022, "Description1", "123456789", "email@example.com", 10);
                WriteLine("\nParameterized constructor:");
                mag2.Show();

                mag1.Name = "Magazine";
                mag1.Year = 2024;
                mag1.Description = "Description";
                mag1.Phone = "987654321";
                mag1.Email = "another_email@example.com";
                mag1.KilkEmployees = 5;

                mag1.Show();

                WriteLine($"mag1 == mag2: {mag1 == mag2}");
                WriteLine($"mag1 != mag2: {mag1 != mag2}");

                Magazine mag3 = new Magazine("Magazine3", 2023, "Description3", "987654321", "email3@example.com", 15);

                WriteLine($"mag1 > mag2: {mag1 > mag2}");
                WriteLine($"mag1 < mag3: {mag1 < mag3}");

                Magazine mag4 = mag1 + 3;
                Magazine mag5 = mag3 - 5;

                mag4.Show();
                mag5.Show();
            }
            catch (Exception ex)
            {
                WriteLine($"Exception: {ex.Message}");
            }
            */

            //task 2
            /*
            Book a = new Book("NAME", "DES", "AUTH", 2024);
            Book b = new Book("NAMEe", "DESe", "AUTHe", 2021);
            Book c = new Book("NAMEee", "DESee", "AUTHee", 2020);

            BookList bookList = new BookList(new Book[3] { a, b, c });
            bookList.Show();

            Book d = new Book();
            BookList newlist = bookList + d;
            newlist.Show();

            newlist -= 2;
            newlist.Show();
            */

            //task 3
            /*
            MorseTranslator translator = new MorseTranslator("Hello World");
            WriteLine(translator.ToMorse());
            WriteLine(translator.ToText());
            */

            WriteLine();
            ReadLine();
        }
    }
}
