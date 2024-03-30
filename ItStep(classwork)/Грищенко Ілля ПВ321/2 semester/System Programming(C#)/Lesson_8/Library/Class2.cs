using System.Text.RegularExpressions;
using static System.Console;

namespace Library
{
    public static class Class2
    {
        //4
        public static bool IsCorrectPib(string pib)
        {
            string pattern = @"^[A-Za-z]+$";
            return Regex.IsMatch(pib, pattern);
        }
        public static bool IsCorrectAge(string age)
        {
            string pattern = @"^\d+$";
            if (!Regex.IsMatch(age, pattern)) return false;
            if (int.Parse(age) > 120) return false;
            return true;
        }
        public static bool IsCorrectPhone(string phone)
        {
            string pattern = @"^\+\d+$";
            return Regex.IsMatch(phone, pattern);
        }
        public static bool IsCorrectEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, pattern);
        }

        //5
        public static Drib Multiply(Drib d1, Drib d2)
        {
            return new(d1.Chiselnik * d2.Chiselnik, d1.Znamenik * d2.Znamenik);
        }
        public static Drib Divide(Drib d1, Drib d2)
        {
            return new(d1.Chiselnik * d2.Znamenik, d1.Znamenik * d2.Chiselnik);
        }
    }
}
