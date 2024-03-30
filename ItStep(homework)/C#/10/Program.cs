using static System.Console;

namespace _10
{
    internal class Program
    {
        //task 1
        /*
        private static bool IsFibonachi(int n)
        {
            if (n == 0 || n == 1)
                return true;

            int a = 0;
            int b = 1;

            while (b < n)
            {
                int temp = b;
                b = a + b;
                a = temp;
            }

            return b == n;
        }

        private static void ShowPair(int[] arr)
        {
            Write("Pair: ");
            foreach (var item in arr)
            {
                if (item % 2 == 0) Write($"{item} ");
            }
            WriteLine();
        }
        private static void ShowNotPair(int[] arr)
        {
            Write("Not pair: ");
            foreach (var item in arr)
            {
                if (item % 2 != 0) Write($"{item} ");
            }
            WriteLine();
        }
        private static void ShowSimple(int[] arr)
        {
            Write("Simple: ");
            foreach (var item in arr)
            {
                bool isSimple = true;
                for (int i = 2; i <= item; ++i)
                {
                    if (item % i == 0 && i != item) isSimple = false; 
                }
                if (isSimple) Write($"{item} ");
            }
            WriteLine();
        }
        private static void ShowFibonachi(int[] arr)
        {
            Write("Fibonachi: ");
            foreach (var item in arr)
            {
                if (IsFibonachi(item)) Write($"{item} ");
            }
            WriteLine();
        }

        public delegate void ShowValues(int[] arr);
        */

        //task 3
        /*
        private static bool IsContain(string text, string subString) => text.Contains(subString);
        */

        static void Main(string[] args)
        {
            try
            {
                //task 1
                /*
                int[] arr = new int[10];
                Random random = new Random();
                for (int i = 0; i < arr.Length; ++i)
                {
                    arr[i] = random.Next(1, 20);
                }

                ShowValues showInfo = null;
                showInfo += ShowPair;
                showInfo += ShowNotPair;
                showInfo += ShowSimple;
                showInfo += ShowFibonachi;

                foreach (var item in arr)
                {
                    Write($"{item} ");
                }
                WriteLine("\n");
                showInfo(arr);
                */

                //task 2
                /*
                Action showTime = () => WriteLine($"Time: {DateTime.Now.TimeOfDay}\n");
                Action showDate = () => WriteLine($"Date: {DateTime.Now}\n");
                Action showDayOfWeek = () => WriteLine($"Day of week: {DateTime.Now.DayOfWeek}\n");
                Func<int, int, double> getTriangleSquare = (a, h) => (a * h) / 2;
                Func<int, int, int> getRectangleSquare = (a, b) => a * b;

                showTime();
                showDate();
                showDayOfWeek();
                WriteLine(getTriangleSquare(3, 4));
                WriteLine(getRectangleSquare(5, 2));
                */

                //task 3
                /*
                Write("Text: ");
                string text = ReadLine();

                Write("Sub string: ");
                string subString = ReadLine();

                if (IsContain(text, subString)) WriteLine("Your sub string contains in text");
                else WriteLine("Your sub string is not contains in text");
                */

                //task 4
                /*
                Func<int[], int> getKilkKratSeven = (arr) =>
                {
                    int kilk = 0;
                    foreach (var item in arr)
                    {
                        if (item % 7 == 0) ++kilk;
                    }
                    return kilk;
                };

                int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                WriteLine(getKilkKratSeven(arr));
                */

                //task 5
                /*
                Func<int[], int> getKilkPos = (arr) =>
                {
                    int kilk = 0;
                    foreach (var item in arr)
                    {
                        if (item >= 0) ++kilk;
                    }
                    return kilk;
                };
                int[] arr = { 1, -2, -3, 4, 5, 6, -7, 8, 9, -10 };
                WriteLine(getKilkPos(arr));
                */

                //task 6
                /*
                int[] arr = new int[10];
                Random random = new Random();
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = random.Next(-10, 10);
                }

                foreach (var item in arr)
                {
                    Write($"{item} ");
                }
                WriteLine("\n");

                var showUniqueNeg = (int[] arr) =>
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (arr[i] >= 0) continue;
                        bool isAccepted = true;
                        for (int j = 0; j < arr.Length; j++)
                        {
                            if (j == i) continue;
                            if (arr[i] == arr[j]) isAccepted = false;
                        }
                        if (isAccepted)
                        {
                            Write($"{arr[i]} ");
                            WriteLine();
                        }
                    }
                };
                showUniqueNeg(arr);
                */

                //task 7
                /*
                string test1 = "{}[]";
                string test2 = "(())";
                string test3 = "[{}]";
                string test4 = "[}";
                string test5 = "[[{]}]";

                WriteLine($"Is '{test1}' valid? {test1.IsRight()}");
                WriteLine($"Is '{test2}' valid? {test2.IsRight()}");
                WriteLine($"Is '{test3}' valid? {test3.IsRight()}");
                WriteLine($"Is '{test4}' valid? {test4.IsRight()}");
                WriteLine($"Is '{test5}' valid? {test5.IsRight()}");
                */

                //task 8
                /*
                List<int> list = new List<int> { 1, 2, 3, 4, 5 };
                list.GetNewArray((x) => x % 2 == 0);

                foreach (var item in list)
                {
                    WriteLine(item);
                }
                */

                WriteLine();
                ReadKey();
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message);
            }
        }
    }
}
