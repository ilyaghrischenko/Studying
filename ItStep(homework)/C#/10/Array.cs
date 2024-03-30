using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    public static class Array
    {
        public static List<int> GetNewArray(this List<int> array, Predicate<int> predicate)
        {
            for (int i = 0; i < array.Count; ++i)
            {
                if (!predicate(array[i])) array.Remove(array[i]);
            }
            return array;
        }
    }
}
