using System.Text;

namespace LibraryDLL
{
    public static class TextWork
    {
        //task 2
        //1
        public static bool IsPalindrom(string value)
        {
            return (value.ToCharArray().Reverse().ToString() == value) ? true : false;
        }
        //2
        public static string GetReverse(string value)
        {
            return value.ToCharArray().Reverse().ToString();
        }
        //3
        public static int GetCountSentences(string value)
        {
            return value.Split(" ,.!?".ToCharArray(),StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}
