using static System.Console;

namespace _8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task 1
            /*
            try
            {
                Product product = new Product(new Money(47, 50), "Product");
                product.Show();
                product.DecreasePrice(new Money(12, 50));
                product.Show();
                product.IncreasePrice(new Money(100, 10));
                product.Show();

                product -= new Money(100, 0);
                product.Show();
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message);
            }
            */

            //task 2
            try
            {
                Device[] devices = { new Car("123", "123",) };
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message);
            }
        }
    }
}
