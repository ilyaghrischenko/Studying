using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_11
{
    public static class StringExtensions
    {
        public static int GetCountSentences(this string text) => text.Split(".?!".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Length;
        public static int GetCountSame(this string text)
        {
            int count = 0;

            text = text.ToLower();
            string[] tokens = text.Split(" ,.?!".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in tokens)
            {
                if (item[0] == item[item.Length - 1]) ++count;
            }

            return count;
        }
    }
}
