namespace Lesson_3
{
    internal class Program
    {
        //task 1
        /*
        static public int CalcKilkWords(string text)
        {
            return text.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
        }
        static public void CoutWords(string text)
        {
            string[] str = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("Upper:");
            foreach (var el in str)
            {
                if (char.IsUpper(el[0])) Console.WriteLine(el);
            }
            Console.WriteLine("end 'a':");
            foreach(var el in str)
            {
                if (el[el.Length - 1] == 'a') Console.WriteLine(el);
            }
        }
        */

        //task 2
        /*
        static public void ReverseWords(ref string text)
        {
            string[] arr = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            text = "";
            for (int i = 0; i < arr.Length; i++)
            {
                char[] reversed_word = arr[i].ToCharArray();
                Array.Reverse(reversed_word);
                
                text += new string(reversed_word);
                if (i < arr.Length - 1) text += " ";
            }
        }
        */

        //task 3
        /*
        static public void ChangeRegister(ref string text)
        {
            string[] arr = text.Split('.', StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < arr.Length; i++)
            {
                if (char.IsLower(arr[i][0])) arr[i] = char.ToUpper(arr[i][0]) + arr[i].Substring(1);
            }

            text = string.Join(".", arr);
        }
        */

        //task 4
        static public int GetKilkVhod(string sentence, string find)
        {
            int kilk = 0;

            string[] words = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int index = 0, i = 0;
            while (index != -1)
            {
                index = words[i].IndexOf(find, i++);
                if (index != -1) ++kilk;
            }

            return kilk;
        }

        static void Main(string[] args)
        {
            //task 1
            /*
            string sentence;
            Console.Write("Enter a sentence: ");
            sentence = Console.ReadLine();
            if (sentence != String.Empty)
            {
                Console.WriteLine($"Count of words: {CalcKilkWords(sentence)}");
                CoutWords(sentence);
            }
            else
            {
                Console.WriteLine("Empty str");
            }
            */

            //task 2
            /*
            string text;
            Console.Write("Enter a sentence: ");
            text = Console.ReadLine();
            if (text != String.Empty)
            {
                ReverseWords(ref text);
                Console.WriteLine($"Modified text: {text}");
            }
            else
            {
                Console.WriteLine("Empty str");
            }
            */

            //task 3
            /*
            string text;
            Console.Write("Enter a sentence: ");
            text = Console.ReadLine();
            if (text != String.Empty)
            {
                ChangeRegister(ref text);
                Console.WriteLine($"Modified text: {text}");
            }
            else
            {
                Console.WriteLine("Empty str");
            }
            */

            //task 4
            string sentence;
            Console.Write("Enter a sentence: ");
            sentence = Console.ReadLine();

            string find;
            Console.Write("Enter a word: ");
            find = Console.ReadLine();

            if (sentence != String.Empty && find != String.Empty) 
            {
                int kilk = GetKilkVhod(sentence, find);
                Console.WriteLine($"Count of vhod: {kilk}");
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}