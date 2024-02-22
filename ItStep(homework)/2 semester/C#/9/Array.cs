using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lesson_9
{
    public class ArrayINT : IOutput, IMath, ISort, ICalc, IOutput2, ICalc2
    {
        private int[] _arr;
        private int _size;

        public ArrayINT()
        {
            _arr = new int[3] { 1, 2, 3 };
            _size = 3;
        }
        public ArrayINT(int size)
        {
            Random random = new Random();
            _arr = new int[size];

            for (int i = 0; i < size; ++i)
            {
                _arr[i] = random.Next(-100, 100);
            }
        }
        public ArrayINT(int[] arr, int size)
        {
            _size = size;
            _arr = new int[_size];
            _arr = arr;
        }

        public int[] Arr
        {
            get { return _arr; }
            set
            {
                if (value == null || value.Length < 2) throw new Exception("Invalid arr argument");
                _arr = value;
            }
        }
        public int Size
        {
            get { return _size; }
            set
            {
                if (value < 2) throw new Exception("Invalid size argument");
                _size = value;
                Array.Resize(ref _arr, _size);
            }
        }

        public void Input()
        {
            Write("Size: ");
            if (!int.TryParse(ReadLine(), out int size))
            {
                throw new Exception("Input(): size error");
            }
            Size = size;

            Write("Arr:\n");
            for (int i = 0; i < _size; ++i)
            {
                Write($"[{i}] object = ");
                if (!int.TryParse(ReadLine(), out int element))
                {
                    throw new Exception("Input(): arr error");
                }
                _arr[i] = element;
            }
        }
        public void Show()
        {
            foreach (var item in _arr)
            {
                Write($"{item, 5}");
            }
            WriteLine("\n");
        }
        public void Show(string info)
        {
            WriteLine(info);
            Show();
        }

        public override string ToString()
        {
            string text = "";
            foreach (var item in _arr)
            {
                text += item.ToString() + " ";
            }
            return (text + $" {Size.ToString()}").Trim();
        }
        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (obj.GetType() != GetType()) return false;

            var other = (ArrayINT)obj;
            return ToString().Equals(other.ToString());
        }
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
        public void Add(int value)
        {
            Array.Resize(ref _arr, _size += 1);
            _arr[_size + 1] = value;
        }
        public void Delete()
        {
            if (_size < 2) throw new Exception("Delete(): Size error!");
            Array.Resize(ref _arr, _size -= 1);
        }

        public int Max()
        {
            return _arr.Max();
        }
        public int Min()
        {
            return _arr.Min();
        }
        public float Avg()
        {
            return (float)_arr.Average();
        }
        public bool Search(int value)
        {
            foreach (var item in _arr)
            {
                if (item == value) return true;
            }
            return false;
        }

        public void SortAsc()
        {
            Array.Sort(_arr);
        }
        public void SortDesc()
        {
            SortAsc();
            Array.Reverse(_arr);
        }
        public void SortByParam(bool isAsc)
        {
            if (isAsc)
            {
                SortAsc();
            }
            else SortDesc();
        }

        public int Less(int value)
        {
            int kilk = 0;
            foreach (var item in _arr)
            {
                if (item < value) ++kilk; 
            }
            return kilk;
        }
        public int Greater(int value)
        {
            int kilk = 0;
            foreach (var item in _arr)
            {
                if (item > value) ++kilk;
            }
            return kilk;
        }

        public void ShowEven()
        {
            foreach (var item in _arr)
            {
                if (item % 2 == 0) Write(item + " ");
                WriteLine();
            }
            WriteLine();
        }
        public void ShowOdd()
        {
            foreach (var item in _arr)
            {
                if (item % 2 != 0) Write(item + " ");
                WriteLine();
            }
            WriteLine();
        }

        public int CountDistinct()
        {
            int kilk = 0;
            for (int i = 0; i < _arr.Length; i++)
            {
                int cur = _arr[i];
                bool isDistinct = true;
                for (int j = 0; j < _arr.Length; j++)
                {
                    if (i == j) continue;
                    if (cur == _arr[j]) isDistinct = false;
                }
                if (isDistinct) ++kilk;
            }
            return kilk;
        }
        public int EqualToValue(int value)
        {
            int kilk = 0;
            foreach (var item in _arr)
            {
                if (item == value) ++kilk;
            }
            return kilk;
        }
    }
}
