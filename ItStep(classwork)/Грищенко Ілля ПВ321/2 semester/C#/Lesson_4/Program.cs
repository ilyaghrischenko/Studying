using Microsoft.VisualBasic.FileIO;

namespace Lesson_4
{
    internal class Program
    {
        static public void Swap<T>(ref T first,ref T second)
        {
            T temp = first;
            first = second;
            second = temp;
        }
        static public bool Check(out int num)
        {
            if (!int.TryParse(Console.ReadLine(), out num))
            {
                return false;
            }
            return true;
        }
        static public bool Check(out float num)
        {
            if (!float.TryParse(Console.ReadLine(), out num))
            {
                return false;
            }
            return true;
        }
        static public bool Check(out string text)
        {
            text = Console.ReadLine();
            if (text == "") return false;
            else return true;
        }

        static public int[][] InitArr(int n)
        {
            int[][] arr = new int[n][];
            Random r = new Random();
            for(int  i = 0; i < n; i++)
            {
                int m = r.Next(2, 6);
                arr[i] = new int[m];
                for(int j = 0; j < m; j++)
                {
                    arr[i][j] = r.Next(-20, 20);
                }
            }
            return arr;
        }
        static public int[][] InitArr(int n, int m)
        {
            int[][] arr = new int[n][];
            Random ran = new Random();
            for (int i = 0; i < arr.Length; ++i)
            {
                arr[i] = new int[m];
                for (int j = 0; j < m; j++)
                {
                    arr[i][j] = ran.Next(-20, 20);
                }
            }
            return arr;
        }
        static public void ShowArr(int[][] arr, string name = "2D Array")
        {
            Console.WriteLine(name + ":");
            foreach (var mas in arr)
            {
                foreach (var el in mas)
                {
                    Console.Write($"{el,4:D}");
                }
                Console.WriteLine();
            } 
        }

        //task 1
        /*
        static public long GetDob(int start,int end)
        {
            if (start > end) Swap(ref start, ref end);

            long dob = 1;
            for (int i = start; i <= end; ++i) dob *= i;
            return dob;
        }
        */

        //task 2
        /*
        static public bool IsFibonacci(ref int n, out int number)
        {
            int a = 0, b = 1;
            int count = 1;

            while (a < n)
            {
                int temp = a;
                a = b;
                b = temp + b;
                count++;
            }
            number = count;

            bool isFib = a == n;
            if (isFib)
            {
                
                return true;
            }
            n = a;
            return false;
        }
        */

        //task 3
        /*
        static public int[] Init1DArr(int size)
        {
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = 0;
            }
            return arr;
        }

        static public void AddSumRow(ref int[][] arr)
        {
            int[] sum = Init1DArr(arr.Length);

            for (int i = 0; i < arr.Length; ++i)
            {
                sum[i] = arr[i].Sum();
            }

            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = sum;
        }
        */
        
        //task 4
        /*
        static public void ChangeStr(ref string text)
        {
            string[] words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; ++i)
            {
                if (words[i].IndexOf(words[i][0], 1) != -1)
                {
                    words[i] = words[i].ToUpper();
                }
            }
            text = string.Join(' ', words);
        }
        */

        static void Main(string[] args)
        {
            //task 1
            /*
            int rez = GetDob(1, 10);
            Console.WriteLine(rez);
            */

            //task 2
            /*
            int el;
            Console.Write("Enter number: ");
            if (!Check(out el))
            {
                Console.WriteLine("Error!");
                return;
            }

            int number;
            if (IsFibonacci(el, out number)) Console.WriteLine($"Number {el} is Fibonachi");
            else Console.WriteLine($"Number {el} is not Fibonachi");
            */

            //task 3
            /*
            int[][] arr = InitArr(4);
            ShowArr(arr);
            */

            //task 4
            /*
            string text;
            Console.Write("Enter a sentence: ");
            if (!Check(out text))
            {
                Console.WriteLine("Error!");
                return;
            }

            ChangeStr(ref text);
            Console.WriteLine($"Changed str: {text}");
            */
        }
    }
}