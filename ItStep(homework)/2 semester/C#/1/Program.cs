namespace _1
{
    internal class Program
    {
        static public void ShowArr(int[] arr)
        {
            for(int i=0; i<arr.Length; i++)
            {
                Console.Write(arr[i]);
            }
            Console.WriteLine();
        }

        //task 1
        /*
        static public void FizzBuzz(int n)
        {
            if (n % 3 == 0 && n % 5 == 0) Console.WriteLine("Fizz Buzz");
            else if (n % 3 == 0) Console.WriteLine("Fizz");
            else if (n % 5 == 0) Console.WriteLine("Buzz");
        }
        */

        //task 2
        /*
        static public float Percent(int number, int percent)
        {
            return number * ((float)percent / 100);
        }
        */

        //task 3
        /*
        static public int NewNumber(int[] arr)
        {
            return arr[0] * 1000 + arr[1] * 100 + arr[2] * 10 + arr[3];
        }
        */

        //task 4
        /*
        static public void ChangeNumber(ref int[] number, int first, int second)
        {
            int temp = 0;
            temp = number[first - 1];
            number[first - 1] = number[second - 1];
            number[second - 1] = temp;
        }
        */

        //task 5
        /*
        static string GetDayOfWeek(int day,int month,int year)
        {
            DateTime date = new DateTime(year, month, day);
            return date.DayOfWeek.ToString();
        }
        static string GetSeason(int month)
        {
            if (month >= 3 && month <= 5) return "Spring";
            if (month >= 6 && month <= 8) return "Summer";
            if (month >= 9 && month <= 11) return "Autumn";
            else return "Winter";
        }
        static public void ShowDate(int[] date)
        {
            Console.WriteLine($"\n{GetSeason(date[1])} {GetDayOfWeek(date[0], date[1], date[2])}");
        }
        */

        //task 6
        /*
        static public void Convert(ref int t, int n)
        {
            t = (n == 1) ? t * 9 / 5 + 32 : (t - 32) * 5 / 9;
        }
        */

        //task 7
        /*
        static public void ShowAllParn(int start,int end)
        {
            if (start > end)
            {
                int temp = start;
                start = end;
                end = temp;
            }

            for (int i = start; i <= end; i++)
            {
                if (i % 2 == 0) Console.Write(i + " ");
            }
        }
        */

        static void Main(string[] args)
        {
            //task 1
            /*
            int number = 0;
            Console.Write("Enter a value: ");
            if (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Error");
                return;
            }
            FizzBuzz(number);
            */

            //task 2
            /*
            int number = 0;
            Console.Write("Enter a value: ");
            if (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Error!");
                return;
            }

            int percent = 0;
            Console.Write("Enter a value: ");
            if (!int.TryParse(Console.ReadLine(), out percent))
            {
                Console.WriteLine("Error!");
                return;
            }

            float rezult = Percent(number, percent);
            Console.WriteLine($"{percent}% of {number} = {rezult}");
            */

            //task 3
            /*
            int[] arr = new int[4];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"Enter {i + 1} value: ");
                if (!int.TryParse(Console.ReadLine(), out arr[i]))
                {
                    Console.WriteLine("Error!");
                    return;
                }
            }
            Console.WriteLine();

            int rezult = NewNumber(arr);
            Console.WriteLine($"New number: {rezult}");
            */

            //task 4
            /*
            int[] arr = new int[6];
            Console.WriteLine("Enter 6 significant number:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"Enter {i + 1} element: ");
                if (!int.TryParse(Console.ReadLine(), out arr[i]))
            {
                Console.WriteLine("Error!");
                return;
            }
            }
            ChangeNumber(ref arr, 1, 6);
            Console.Write("New number: ");
            ShowArr(arr);
            */

            //task 5
            /*
            int[] date = new int[3];
            Console.WriteLine("Enter a day, month, year one by one:");
            for (int i = 0; i < date.Length; i++)
            {
                if(!int.TryParse(Console.ReadLine(), out date[i]))
                {
                    Console.WriteLine("Error!");
                    return;
                }
            }
            ShowDate(date);
            */

            //task 6
            /*
            int t = 0;
            Console.Write("Enter a temperature: ");
            if (!int.TryParse(Console.ReadLine(), out t))
            {
                Console.WriteLine("Error!");
                return;
            }
            Convert(ref t, 2);
            Console.WriteLine(t);
            */

            //task 7
            /*
            int start = 0, end = 0;
            Console.WriteLine("Enter start and end one by one:");
            if (!int.TryParse(Console.ReadLine(), out start))
            {
                Console.WriteLine("Error!");
                return;
            }
            if (!int.TryParse(Console.ReadLine(), out end))
            {
                Console.WriteLine("Error!");
                return;
            }
            ShowAllParn(start, end);
            */

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
