using System.Transactions;

namespace _4
{
    internal class Program
    {
        static public void CreateVariable(out int var, string sentence = "number")
        {
            var = 0;

            bool isRight = false;
            while (!isRight)
            {
                Console.Write($"Enter a {sentence}: ");
                if (!int.TryParse(Console.ReadLine(), out var)) Console.WriteLine("Error! Try again\n");
                else isRight = true;
            }
        }
        static public int[] InitArr(int size)
        {
            Random rnd = new Random();
            int[] arr = new int[size];
            for(int i = 0; i < size; ++i)
            {
                arr[i] = rnd.Next(0, 10);
            }

            return arr;
        }
        static public void ShowArr(int[] arr, string name = "Array")
        {
            Console.WriteLine(name + ":");
            for(int i=0; i<arr.Length; ++i)
            {
                Console.Write(arr[i] + "  ");
            }
            Console.WriteLine();
        }

        //task 1
        /*
        static public void DrawSquare(int size, char symbol)
        {
            Console.WriteLine("\nSquare:");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(symbol + " ");
                }
                Console.WriteLine();
            }
        }
        */

        //task 2
        /*
        static public bool isPalindrom(int num)
        {
            string text = num.ToString();

            int i = text.Length - 1;
            for (int j = 0; j < text.Length; j++)
            {
                if (text[i--] != text[j]) return false;
            }
            return true;
        }
        */

        //task 3
        /*
        static public void FilterArray(ref int[] arr, int[] filter_arr, out int kilk_del)
        {
            kilk_del = 0;

            int new_size = arr.Length;
            foreach (var filter_el in filter_arr)
            {
                foreach (var arr_el in arr)
                {
                    if (filter_el == arr_el)
                    {
                        --new_size;
                        ++kilk_del;
                    }
                }
            }

            int[] new_arr = new int[new_size];
            int k = 0;
            foreach (var arr_el in arr)
            {
                bool isRight = true;
                foreach (var filter_el in filter_arr)
                {
                    if (arr_el == filter_el) isRight = false;
                }
                if (isRight) new_arr[k++] = arr_el;
            }

            arr = new_arr;
        }
        */

        static void Main(string[] args)
        {
            //task 1
            /*
            int size;
            CreateVariable(out size);

            DrawSquare(size, '*');
            */

            //task 2
            /*
            int num;
            CreateVariable(out num);

            if (isPalindrom(num)) Console.WriteLine($"{num} is palindrom");
            else Console.WriteLine($"{num} is NOT palindrom");
            */

            //task 3
            /*
            int kilk_del;
            int[] arr = InitArr(4);
            ShowArr(arr, "My arr");

            int[] filter = InitArr(2);
            ShowArr(filter, "Filter arr");

            FilterArray(ref arr, filter, out kilk_del);

            ShowArr(arr, "\nMy filtered arr");
            Console.WriteLine($"{kilk_del} - кількість видалень");
            */

            //task 4
            /*
            Website krnu = new Website();
            krnu.show();
            Console.ReadKey();

            krnu.input();
            krnu.show();
            Console.ReadKey();

            Website school = new Website("name", "url", "des", "ip");
            school.show();
            */

            //task 5
            /*
            Magazine magazine = new Magazine();
            magazine.show();
            Console.ReadKey();

            magazine.input();
            magazine.show();
            Console.ReadKey();

            Magazine magazine1 = new Magazine("name", 2024, "des", "number", "email");
            magazine1.show();
            */

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
