using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using static System.Console;

namespace Lesson_5
{
    internal class Program
    {
        static public void CreateVariable(out string variable, string name = "text")
        {
            variable = "";

            bool isRight = false;
            while (!isRight)
            {
                Write($"Enter {name}: ");
                variable = ReadLine();
                if (variable == String.Empty)
                {
                    WriteLine("Error! Try again");
                    continue;
                }
                isRight = true;
            }
        }

        //task 1
        /*
        static public int ToInt(string text)
        {
            if (text == string.Empty) throw new Exception("Empty string argument");
            for (int i = 0; i < text.Length; i++)
            {
                if (!char.IsDigit(text[i])) throw new FormatException("Invalid text format");
            }

            if (long.Parse(text) > int.MaxValue || long.Parse(text) < int.MinValue) throw new FormatException("greater than MaxValue or lower than MinValue");
            int num;
            if (!int.TryParse(text, out num)) throw new Exception("TryParse error");
            return num;
        }
        */

        //task 2
        /*
        static public int ToDecimal(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != '0' && text[i] != '1')
                {
                    throw new FormatException("Format error");
                }
            }

            long num = Convert.ToInt64(text);
            if (num < int.MinValue || num > int.MaxValue)
            {
                throw new Exception("Greater than MaxValue or lower than MinValue");
            }

            return Convert.ToInt32(text, 2);
        }
        */

        //task 4
        /*
        static public long MultiplyText(string text)
        {
            if (text == "") throw new ArgumentException("Invalid argument");
            foreach (var word in text)
            {
                if (!char.IsDigit(word) && word != '*' && word != ' ') throw new ArgumentException("Invalid argument");
            }

            string[] words = text.Split("* ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            long rez = 1;
            foreach (var word in words)
            {
                rez *= int.Parse(word);
            }

            return rez;
        }
        */

        static void Main(string[] args)
        {
            //task 1
            /*
            string text;
            CreateVariable(out text);

            int rez = 0;
            try
            {
                rez = ToInt(text);
            }
            catch(FormatException error)
            {
                WriteLine(error.Message);
            }
            catch(Exception error)
            {
                WriteLine(error.Message);
            }

            WriteLine(rez);
            */

            //task 2
            /*
            string text;
            CreateVariable(out text);

            int rez = 0;
            try
            {
                rez = ToDecimal(text);
            }
            catch(FormatException er)
            {
                WriteLine(er.Message);
            }
            catch(Exception er)
            {
                WriteLine(er.Message);
            }
            if (rez != 0) WriteLine($"Decimal format of number {text} = {rez}");
            */

            //task 3
            /*
            CreditCard card = new CreditCard();

            try
            {
                card.input();
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            card.show();
            */

            //task 4
            /*
            string text;
            CreateVariable(out text);

            long rez = 0;
            try
            {
                rez = MultiplyText(text);
            }
            catch(ArgumentException ex)
            {
                WriteLine(ex.Message);
            }

            if (rez != 0) WriteLine($"{text} = {rez}");
            */

            WriteLine();
            ReadKey();
        }
    }
}