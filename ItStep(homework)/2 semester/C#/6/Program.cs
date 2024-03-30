using System.Drawing;
using static System.Console;

namespace _6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task 1
            try
            {
                RGB rgb = new RGB(33, 12, 76);
                rgb.ToHex();
                rgb.ToHSL();
                rgb.ToCMYK();
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message);
            }
            //task 2
            /*
            try
            {
                Matrix matrix = new Matrix(3, 4);

                //Methods
                matrix.Show();
                WriteLine();
                ReadKey();

                matrix.Input();
                matrix.Show();
                WriteLine();
                ReadKey();

                WriteLine($"Max: {matrix.Max()}\nMin: {matrix.Min()}");
                WriteLine();
                ReadKey();

                //Indexator
                int value = matrix[1, 2];
                matrix[1, 2] = 42;
                matrix.Show();
                WriteLine();
                ReadKey();
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message);
            }
            */

            WriteLine();
            ReadKey();
        }
    }
}
