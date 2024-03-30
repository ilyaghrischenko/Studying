using System.Runtime.ExceptionServices;

namespace _2
{
    internal class Program
    {
        static public int[] InitArr(int size)
        {
            Random random = new Random();

            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; ++i)
            {
                arr[i] = random.Next(-20, 20);
            }

            return arr;
        }
        static public void InputArr(ref int[] arr, string name = "Array")
        {
            Console.WriteLine($"Input {name}:");
            for (int i = 0; i < arr.Length; ++i)
            {
                Console.Write($"{i + 1} value: ");
                if(!int.TryParse(Console.ReadLine(), out arr[i]))
                {
                    Console.WriteLine("Error!");
                    return;
                }
            }
            Console.WriteLine();
        }
        static public void ShowArr(int[] arr, string name = "Array")
        {
            Console.WriteLine(name + ":");
            for(int i=0;i< arr.Length; ++i)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        static public float[][] InitArr(int n, int m)
        {
            Random r = new Random();

            float[][] arr = new float[n][];
            for (int i = 0; i < n; ++i)
            {
                arr[i]= new float[m];
                for (int j = 0; j < m; ++j)
                {
                    float ran = r.NextSingle() * (20.7f - (-20.7f)) + (-20.7f);
                    arr[i][j] = (float)Math.Round(ran, 3);
                }
            }

            return arr;
        }
        static public void ShowArr(float[][] arr, string name = "2d Array")
        {
            Console.WriteLine(name + ":");
            for(int i=0;i< arr.Length;++i)
            {
                for(int j=0; j< arr[i].Length; ++j)
                {
                    Console.Write($"{arr[i][j],10}");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        static public int[][] InitINTArr(int n, int m)
        {
            Random r = new Random();

            int[][] arr = new int[n][];
            for (int i = 0; i < n; ++i)
            {
                arr[i] = new int[m];
                for (int j = 0; j < m; ++j)
                {
                    arr[i][j] = r.Next(-100, 100);
                }
            }

            return arr;
        }
        static public void ShowArr(int[][] arr, string name = "2d Array")
        {
            Console.WriteLine(name + ":");
            for (int i = 0; i < arr.Length; ++i)
            {
                for (int j = 0; j < arr[i].Length; ++j)
                {
                    Console.Write($"{arr[i][j],10}");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        //task 1
        /*
        static public float[] InitFloatArr(int size)
        {
            float[] arr = new float[size];
            for (int i = 0; i < arr.Length; ++i)
            {
                arr[i] = 1;
            }

            return arr;
        }
        static public void ShowStatistics(int[] arr, string name = "Array")
        {
            int max = int.MinValue, min = int.MaxValue;
            int sum = 0, sum_p = 0, dob = 1;
            foreach (var el in arr)
            {
                if (el < min) min = el;
                if (el > max) max = el;
                if (el % 2 == 0) sum_p += el;
                sum += el;
                dob *= el;
            }

            Console.WriteLine($"\nMax: {max} Min: {min} Sum: {sum} Sum_p: {sum_p} Dob: {dob}");
        }
        static public void ShowStatistics(float[][] arr, string name = "2d Array")
        {
            float max = float.MinValue, min = float.MaxValue;
            float sum = 0, sum_nst = 0;
            float dob_r = 1, dob_st = 1;

            float sum_even_columns = 0, sum_odd_columns = 0;

            foreach (var mas in arr)
            {
                foreach (var el in mas)
                {
                    if (el < min) min = el;
                    if (el > max) max = el;
                    sum += el;
                }
            }

            int k = 0, l = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                float rowProduct = 1;

                for (int j = 0; j < arr[i].Length; j++)
                {
                    dob_r *= arr[i][j];
                    dob_st *= arr[j][i];

                    rowProduct *= arr[i][j];

                    if (j % 2 == 0) sum_even_columns += arr[i][j];
                    else sum_odd_columns += arr[i][j];
                }
                ++k;
                ++l;

                Console.WriteLine($"Product in row {i + 1}: {rowProduct}");
            }

            Console.WriteLine($"\nMax: {max} Min: {min} Sum: {sum} Sum_nst: {sum_nst} Dob_r: {dob_r} Dob_st: {dob_st}");
            Console.WriteLine($"Sum of even columns: {sum_even_columns}");
            Console.WriteLine($"Sum of odd columns: {sum_odd_columns}");
        }
        */

        //task 2
        /*
        static public int GetSumMinMax(int[][] arr)
        {
            int[] index_min = new int[2], index_max = new int[2];
            int min = int.MaxValue, max = int.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    if (arr[i][j] < min)
                    {
                        min = arr[i][j];
                        index_min[0] = i;
                        index_min[1] = j;
                    }
                    if (arr[i][j] > max)
                    {
                        max = arr[i][j];
                        index_max[0] = i;
                        index_max[1] = j;
                    }
                }
            }

            Console.WriteLine($"Min:{min} Max:{max}");

            if (index_min[0] > index_max[0] || (index_min[0] == index_max[0] && index_min[1] > index_max[1]))
            {
                (min, max) = (max, min);
            }

            int sum_min_max = 0;
            bool isPlus = false;
            foreach(var mas in arr)
            {
                foreach(var el in mas)
                {
                    if (el == min) isPlus = true;
                    if (isPlus) sum_min_max += el;
                    if (el == max) isPlus = false;
                }
            }

            return sum_min_max;
        }
        */

        //task 3
        /*
        static public int[][] CreateMatrix(int size, int start = -100, int end = 100)
        {
            Random r = new Random();

            int[][] matrix = new int[size][];
            for (int i = 0; i < size; ++i)
            {
                matrix[i] = new int[size];
                for (int j = 0; j < size; ++j)
                {
                    matrix[i][j] = r.Next(start, end);
                }
            }

            return matrix;
        }

        static public void MultiplyMatrixNumber(ref int[][] arr, int number)
        {
            for (int i = 0; i < arr.Length; ++i)
            {
                for (int j = 0; j < arr[i].Length; ++j)
                {
                    arr[i][j] *= number;
                }
            }
        }
        static public void AddMatrix(ref int[][] matrix1, int[][] matrix2)
        {
            if (matrix1.Length != matrix2.Length) return;
            for (int i = 0; i < matrix1.Length; ++i)
            {
                if (matrix1[i].Length != matrix2[i].Length) return;
            }

            for (int i = 0; i < matrix1.Length; ++i)
            {
                for (int j = 0; j < matrix1[i].Length; j++)
                {
                    matrix1[i][j] += matrix2[i][j];
                }
            }
        }
        static public void MultiplyMatrix(ref int[][] arr1, int[][] arr2)
        {
            int rowsA = arr1.Length;
            int colsA = arr1[0].Length;
            int rowsB = arr2.Length;
            int colsB = arr2[0].Length;

            if (colsA != rowsB) return;

            int[][] result = new int[rowsA][];
            for (int i = 0; i < rowsA; i++)
            {
                result[i] = new int[colsB];
            }

            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < colsB; j++)
                {
                    int sum = 0;
                    for (int k = 0; k < colsA; k++)
                    {
                        sum += arr1[i][k] * arr2[k][j];
                    }
                    result[i][j] = sum;
                }
            }

            arr1 = result;
        }
        */

        //task 4
        /*
        static public void FilterArray(ref int[] main, int[] filter)
        {
            if (main == null || filter == null) return;
            if (main.SequenceEqual(filter))
            {
                main = new int[0];
                return;
            }

            int kilk = 0;
            foreach (var el in filter)
            {
                foreach (var it in main)
                {
                    if (el == it)
                    {
                        ++kilk;
                        break;
                    }
                }
            }
            if (kilk == 0) return;

            int[] new_arr = new int[main.Length - kilk];
            int k = 0;
            for (int i = 0; i < main.Length; ++i)
            {
                int cur = main[i];
                bool isAdd = true;
                for (int j = 0; j < filter.Length; ++j)
                {
                    if (cur == filter[j])
                    {
                        isAdd = false;
                        break;
                    }
                }
                if (isAdd)
                {
                    new_arr[k] = cur;
                    ++k;
                }
            }

            main = new_arr;
        }
        */

        static void Main(string[] args)
        {
            //task 1
            /*
            int[] arr = InitArr(5);
            InputArr(ref arr, "A");
            ShowArr(arr, "A");

            ShowStatistics(arr, "A");

            float[][] arr2 = InitArr(3, 4);
            ShowArr(arr2, "B");

            ShowStatistics(arr2, "B");
            */

            //task 2
            /*
            int[][] arr = InitINTArr(4, 5);
            ShowArr(arr);

            int sum = GetSumMinMax(arr);
            Console.WriteLine($"Sum min - max: {sum}");
            */

            //task 3
            /*
            int[][] matr = CreateMatrix(4);
            ShowArr(matr, "Matrix");
            MultiplyMatrixNumber(ref matr, 3);
            ShowArr(matr, "After multiply by 3");

            Console.ReadKey();
            Console.Clear();

            int[][] matr1 = CreateMatrix(4);
            int[][] matr2 = CreateMatrix(4);

            ShowArr(matr1, "First");
            ShowArr(matr2, "Second");

            AddMatrix(ref matr1, matr2);
            ShowArr(matr1, "New first");

            Console.ReadKey();
            Console.Clear();

            int[][] mat1 = CreateMatrix(3);
            int[][] mat2 = CreateMatrix(3);

            ShowArr(mat1, "First");
            ShowArr(mat2, "Second");

            MultiplyMatrix(ref mat1, mat2);
            ShowArr(mat1, "New first");
            */

            //task 4
            /*
            int[] main_arr = InitArr(5);
            int[] filter = InitArr(3);

            ShowArr(main_arr, "Main array");
            ShowArr(filter, "Filter array");

            FilterArray(ref main_arr, filter);
            ShowArr(main_arr, "Filtered main array");
            */

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
