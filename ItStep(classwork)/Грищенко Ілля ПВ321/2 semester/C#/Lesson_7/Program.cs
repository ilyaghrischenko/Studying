using static System.Console;

namespace Lesson_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task 3
            /*
            WriteLine("Square:");
            Square.ShowFigure Square = new Square.ShowFigure { Side = 4, Symbol = '#' };
            Square.Show();

            WriteLine();
            ReadKey();

            WriteLine("Rectangle:");
            Rectangle.ShowFigure Rectangle = new Rectangle.ShowFigure { Lenght = 7, Height = 3, Symbol = '$' };
            Rectangle.Show();

            WriteLine();
            ReadKey();

            WriteLine("Triangle:");
            Triangle.ShowFigure Triangle = new Triangle.ShowFigure { Lenght = 3, Height = 5, Symbol = '&' };
            Triangle.Show();
            */

            //task 4
            Task4.GuessNumber game = new Task4.GuessNumber();
            game.Game();

            WriteLine();
            ReadKey();
        }
    }
}