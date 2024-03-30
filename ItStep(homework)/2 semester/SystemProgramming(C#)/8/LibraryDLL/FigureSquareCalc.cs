using static System.Console;

namespace LibraryDLL
{
    public class FigureSquareCalc
    {
        //task 1
        //1
        public static int SquareKv(int x)
        {
            return (int)Math.Pow(x, 2);
        }
        //2
        public static int SquarePr(int x, int y)
        {
            return x * y;
        }
        //3
        public static double SquareTr(int a, int b, int c)
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
