using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    public static class StringExtension
    {
        public static bool IsRight(this string str)
        {
            List<char> tokens = new List<char> { '(', ')', '{', '}', '[', ']' };
            Dictionary<char, char> matchingBrackets = new Dictionary<char, char>
            {
                { '(', ')' },
                { '{', '}' },
                { '[', ']' }
            };

            Stack<char> stack = new Stack<char>();

            foreach (var item in str)
            {
                if (tokens.Contains(item))
                {
                    if (matchingBrackets.ContainsKey(item)) stack.Push(item);
                    else
                    {
                        if (stack.Count == 0 || matchingBrackets[stack.Pop()] != item) return false;
                    }
                }
            }

            return stack.Count == 0;
        }
    }
}
