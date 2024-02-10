using static System.Console;

internal class Program
{
    //task 1
    /*
    private static void Show(string message) => WriteLine(message);
    private delegate void ShowMessage(string message);
    */

    //task 2
    /*
    private static int Add(int first, int second) => first + second;
    private static int MiNus(int first, int second) => first - second;
    private static int Multiply(int first, int second) => first * second;
    private delegate int CalcNumbers(int first, int second);
    */

    //task 3
    private static void Check(int number, Predicate<int> del)
    {
        WriteLine($"number: {number}");
        if (del(number))
        {
            WriteLine("TRUE");
        }
        WriteLine();
    }
    private static bool IsFibonachi(int number)
    {
        if (number < 0)
        {
            return false;
        }

        int a = 0, b = 1;

        while (b < number)
        {
            int temp = a;
            a = b;
            b = temp + b;
        }

        return b == number;
    }

    private static void Main(string[] args)
    {
        //task 1
        /*
        ShowMessage del = Show;
        del("WOW");
        */

        //task 2
        /*
        try
        {
            char oper = ' ';
            Write("Enter operation(+, -, *): ");
            if (!char.TryParse(ReadLine(), out oper))
            {
                throw new Exception();
            }

            CalcNumbers del = null;
            switch (oper)
            {
                case '+':
                    del = Add;
                    break;
                case '-':
                    del = MiNus;
                    break;
                case '*':
                    del = Multiply;
                    break;
                default:   //throw new Exception();
                    WriteLine("Error operation");
                    break;
            }

            WriteLine("Result: " + del?.Invoke(3, 3));
        }
        catch (Exception ex)
        {
            WriteLine(ex.Message);
        }
        */

        //task 3
        int ran = new Random().Next(1, 10);
        Check(ran, x => x % 2 == 0);
        Check(ran, x => x % 2 != 0);
        Check(ran, IsFibonachi);
    }
}
