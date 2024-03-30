using static System.Console;

namespace HW_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //task 1,2,3
                Play play = new();
                play.Show();
                play.Dispose();

                WriteLine();

                Shop shop = new();
                shop.Show();
                shop.Dispose();
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message);
            }
            WriteLine();
            ReadKey();
        }
    }
}