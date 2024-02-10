namespace Lesson_2
{
    internal class Program
    {
        static public int[] InitArr(int size)
        {
            int[] arr = new int[size];

            Random random = new Random();
            for (int i = 0; i < size; ++i)
            {
                arr[i] = random.Next(-10, 10);
            }

            return arr;
        }
        static public int[][] InitArr(int row, int col)
        {
            Random random = new Random();

            int[][] arr = new int[row][];
            for (int i = 0; i < row; ++i)
            {
                arr[i] = new int[col];
                for (int j = 0; j < col; ++j)
                {
                    arr[i][j] = random.Next(-10, 10);
                }
            }
            return arr;
        }
        static public void InitArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; ++i)
            {
                Console.Write($"Enter {i + 1} element: ");
                if (!int.TryParse(Console.ReadLine(), out arr[i]))
                {
                    Console.WriteLine("Error!");
                    return;
                }
            }
        }
        static public void ShowArr(int[] arr, string name = "Array")
        {
            Console.WriteLine();

            Console.WriteLine(name + ":");
            foreach (var value in arr)
            {
                Console.Write(value + " ");
            }

            Console.WriteLine();
        }
        static public void ShowArr(int[][] arr, string name = "Array")
        {
            Console.WriteLine(name + ":");
            for (int i = 0; i < arr.Length; ++i)
            {
                for(int j = 0; j < arr[i].Length; ++j)
                {
                    Console.Write($"{arr[i][j],5}");
                }
                Console.WriteLine();
            }
        }

        //task 1
        /*
        static public void ShowStatistics(int[] arr)
        {
            int kilk_p = 0, kilk_np = 0, kilk_u = 0;
            for (int i = 0; i < arr.Length; ++i)
            {
                if (arr[i] % 2 == 0) ++kilk_p;
                else ++kilk_np;

                bool IsUnique = true;
                for (int j = 0; j < arr.Length; ++j)
                {
                    if (j == i) continue;
                    if (arr[j] == arr[i]) IsUnique = false;
                }
                if (IsUnique) ++kilk_u;
            }

            Console.WriteLine($"Kilk parn = {kilk_p} Kilk neparn = {kilk_np} Kilk unique = {kilk_u}");
        }
        */

        //task 2
        /*
        static public int GetKilk(int[] arr, int value)
        {
            int kilk = 0;
            foreach (var item in arr)
            {
                if (item < value)
                { 
                    Console.Write(item + " ");
                    ++kilk;
                }
            }
            Console.WriteLine();

            return kilk;
        }
        */

        //task 3
        /*
        static public int GetKilkPovt(int[] arr, int[] arr_povt)
        {
            int kilk = 0;
            //for (int i = 0; i < arr.Length - 2; ++i)
            //{
            //    if (arr[i] == arr_povt[0] && arr[i + 1] == arr_povt[1] && arr[i + 2] == arr_povt[2]) ++kilk;
            //}
            int index=-1;
            while ((index = Array.IndexOf(arr, arr_povt[0])) != -1 && index< arr.Length - 2)
            {
                if (arr[index+1] == arr_povt[1] && arr[index + 2] == arr_povt[2]) ++kilk;
                index = -1;
            }

            return kilk;
        }
        */

        //task 4
        /*
        static public int GetSizeUnique(int[] first, int[] second)
        {
            int size = 0;
            for (int i = 0; i < first.Length; ++i)
            {
                bool isUnique = true;
                for (int j = 0; j < first.Length; ++j)
                {
                    if (i == j) continue;
                    if (first[i] == first[j]) isUnique = false;
                }
                if (isUnique) ++size;
            }

            for (int i = 0; i < second.Length; ++i)
            {
                bool isUnique = true;
                for (int j = 0; j < first.Length; ++j)
                {
                    if (second[i] == first[j]) isUnique = false;
                }
                for(int j = 0; j < second.Length; ++j)
                {
                    if (i == j) continue;
                    if (second[i] == second[j]) isUnique = false;
                }
                if (isUnique) ++size;
            }
            return size;
        }
        static public int[] GetNewArr(int[] first, int[] second)
        {
            int size = GetSizeUnique(first, second);
            int[] arr = new int[first.Length + second.Length];
            int index = 0;
            for (int i = 0; i < first.Length; i++)
            {
                bool isUnique = true;
                for (int j = 0; j < first.Length; ++j)
                {
                    if (i == j) continue;
                    if (first[i] == first[j])
                    { 
                        isUnique = false;
                        break;
                    }
                }
                if(isUnique) arr[index++] = first[i];
            }

            for (int i = 0; i < second.Length; ++i)
            {
                bool isUnique = true;
                for (int j = 0; j < first.Length; ++j)
                {
                    if (second[index] == first[j])
                    {
                        isUnique = false;
                        break;
                    }
                }

                if (isUnique == false) continue;
                for (int j = 0; j < second.Length; ++j)
                {
                    if (i == j) continue;
                    if (second[i] == second[j])
                    {
                        isUnique = false;
                        break;
                    }
                }
                if (isUnique)
                {
                    arr[index++] = second[i];
                }
            }

            Array.Resize(ref arr, index);
            return arr;
        }
        */
        
        //task 5
        /*
        static public int GetMin(int[][] arr)
        {
            int min = int.MaxValue;
            for(int i=0;i< arr.Length; i++)
            {
                for(int j=0;j< arr[i].Length; j++)
                {
                    if (arr[i][j] < min) min = arr[i][j];
                }
            }

            return min;
        }
        static public int GetMax(int[][] arr)
        {
            int max = int.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    if (arr[i][j] > max) max = arr[i][j];
                }
            }

            return max;
        }
        */

        //task 6
        static public int GetSum(int[] arr)
        {
            int sum = 0;
            for(int i=0;i<arr.Length; ++i)
            {
                if (i % 2 == 0) sum += arr[i];
            }
            return sum;
        }
        //static public void Sort(ref int[] arr)
        //{
        //}

        static void Main(string[] args)
        {
            //task 1
            /*
            int[] arr = InitArr(3);
            ShowArr(arr);
            ShowStatistics(arr);
            */

            //task 2
            /*
            int[] arr = InitArr(4);
            ShowArr(arr);


            int kilk = GetKilk(arr, 5);

            Console.WriteLine($"Кiлькiсть менше 5 = {kilk}");
            */

            //task 3
            /*
            int[] arr = { 1, 2, 3, 1, 3, 2, 3 };
            ShowArr(arr);

            int[] arr_povt = new int[3];
            InitArr(arr_povt);
            
            Console.WriteLine($"Kilk povt = {GetKilkPovt(arr, arr_povt)}");
            */

            //task 4
            /*
            int[] m = InitArr(5);
            ShowArr(m, "M");

            int[] n = InitArr(5);
            ShowArr(n, "N");

            int[] arr = GetNewArr(n, m);
            ShowArr(arr, "New arr");
            */

            //task 5
            /*
            int[][] arr = InitArr(3, 5);
            ShowArr(arr);
            Console.WriteLine($"Min:{GetMin(arr)} Max:{GetMax(arr)}");
            */

            //task 6
            int[] arr = InitArr(10);
            ShowArr(arr);

            Console.WriteLine($"sum = {GetSum(arr)}");
            Sort(ref arr);
            ShowArr(arr);

            Console.ReadKey();
            Console.WriteLine();
        }
    }
}