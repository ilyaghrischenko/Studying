using static System.Console;

namespace Library
{
    public static class Class1
    {
        //1
        public static void ShowInfo(string message)
        {
            WriteLine(message);
        }
        //2
        public static bool IsLeap(int year)
        {
            return (year % 4 == 0) ? true : false;
        }
        //3
        public static void ShowStatistic(List<int> numbers)
        {
            if (numbers.Count != 3)
            {
                WriteLine("Invalid count.");
                return;
            }
            WriteLine($"Max: {numbers.Max()}\nMin: {numbers.Min()}\nSum: {numbers.Sum()}");
        }
    }
}
