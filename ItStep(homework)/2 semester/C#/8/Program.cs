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
            /*
            try
            {
                Device[] devices =
                {
                    new Car("name","des","eng","mark","model",2024),
                    new Vaporizer("name","des",100,100),
                    new Microwave("name","des","coat",20.5),
                    new Kettle("name","des","maker",2024),
                };

                foreach (var item in devices)
                {
                    WriteLine(item);
                    item.Sound();
                }
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message);
            }
            */

            //task 3
            try
            {
                MusicInstrument[] musicInstruments =
                {
                    new Cello("name","description","producer","history","vulture","type"),
                    new Ukulele("name","description","producer","history",4,4),
                    new Trombone("name","description","producer","history","material",5.2),
                    new Violin("name","description","producer","history",10,"red")
                };

                foreach (var item in musicInstruments)
                {
                    item.Sound();
                    item.Desc();
                    item.Hist();
                    WriteLine();
                    item.Show();
                    WriteLine("----------");
                }
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
