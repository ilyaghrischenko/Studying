using System.Text;

namespace _3
{
    internal class Program
    {
        static public void CreateString(out string text, string sen = "text")
        {
            Console.Write("Enter a " + sen + ": ");
            text = Console.ReadLine();
            if (text == string.Empty) text = "";
        }

        //task 1
        /*
        static public void CeasersChipher(ref string text, int key)
        {
            char[] charArray = text.ToCharArray();

            for (int i = 0; i < charArray.Length; i++)
            {
                char currentChar = charArray[i];

                if (char.IsUpper(currentChar)) charArray[i] = (char)((currentChar - 'A' + key) % 26 + 'A');
                else charArray[i] = (char)((currentChar - 'a' + key) % 26 + 'a');
            }

            text = new string(charArray);
            Console.WriteLine(text);
        }
        */

        //task 2
        /*
        static public int CalcText(string text)
        {
            string[] words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            if (words.Length != 3)
            {
                return 0;
            }

            int first, second;

            if (int.TryParse(words[0], out first) && int.TryParse(words[2], out second))
            {
                if (words[1] == "+")
                {
                    return first + second;
                }
                else if (words[1] == "-")
                {
                    return first - second;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }
        }
        */

        //task 3
        /*
        static public bool IsDate(string date)
        {
            string[] words = date.Split('/', StringSplitOptions.RemoveEmptyEntries);
            if (words.Length != 3) return false;
            if (words[0].Length != 2 || words[1].Length != 2 || words[2].Length != 4) return false;

            int day = int.Parse(words[0]);
            int month = int.Parse(words[1]);
            int year = int.Parse(words[2]);

            if (day < 1 || month < 1 || year < 1600 || day > 31 || year > 9999 || month > 12) return false;
            if (year % 4 == 0)
            {
                if (month == 2 && (day > 29)) return false;
            }
            else if (month == 2 && day > 28) return false;
            else if ((month == 4 || month == 6 || month == 9 || month == 11) && day > 30) return false;

            return true;
        }
        */

        //task 4
        /*
        static public bool IsReliable(string password)
        {
            if (password.Length < 8) return false;

            int kilkCapLet = 0, kilkSmLet = 0, kilkNum = 0;
            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsLetter(password[i]))
                {
                    if (char.IsUpper(password[i])) ++kilkCapLet;
                    else ++kilkSmLet;
                }
                else if (char.IsDigit(password[i])) ++kilkNum;
            }

            if (kilkCapLet >= 1 && kilkSmLet >= 1 && kilkNum >= 1) return true;
            return false;
        }
        */

        //task 5
        static public void ChangeInappropriateWords(ref string text, string words)
        {
            string[] inap_words = words.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string[] my_text = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < my_text.Length; ++i)
            {
                for (int j = 0; j < inap_words.Length; ++j)
                {
                    if (my_text[i] == inap_words[j])
                    {
                        for (int k = 0; k < my_text[i].Length; ++k)
                        {

                        }
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            //task 1
            /*
            string text;
            CreateString(out text);

            Console.WriteLine($"Start text: {text}");
            CeasersChipher(ref text, 3);
            Console.WriteLine($"End text: {text}");
            */

            //task 2
            /*
            string text;
            CreateString(out text, "math expression");

            int rez = CalcText(text);
            Console.WriteLine($"Text {text} result: {rez}");
            */

            //task 3
            /*
            string date;
            CreateString(out date);
            if (IsDate(date)) Console.WriteLine("True: it's date");
            else Console.WriteLine("False: it's NOT date");
            */

            //task 4
            /*
            string pass;
            CreateString(out pass, "password");

            if (IsReliable(pass)) Console.WriteLine("True: pass is reliable");
            else Console.WriteLine("False: pass is NOT reliable");
            */

            //task 5


            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
