using static System.Console;

namespace _12
{
    internal class Program
    {
        static bool Check(int choice)
        {
            int[] variants = { 0, 1, 2, 3, 4, 5, 6 };
            foreach (var item in variants)
            {
                if (choice == item) return true;
            }
            return false;
        }
        static void AddWord(ref Dictionary<string, List<string>> dict)
        {
            Write("English word: ");
            string word = ReadLine();
            if (word == string.Empty) throw new Exception();

            List<string> translates = new();
            while (true)
            {
                Write("french translation(0 - exit): ");
                string translate = ReadLine();
                if (translate == "0") break;
                if (translate == string.Empty) throw new Exception();
                translates.Add(translate);
            }

            dict.Add(word, translates);
        }

        static void Main(string[] args)
        {
            try
            {
                //task 1
                /*
                LinkedList<Book> library = new LinkedList<Book>();

                int size = 0;
                Write("Enter count of books: ");
                size = int.Parse(ReadLine());

                for (int i = 0; i < size; ++i)
                {
                    Book newBook = new Book();
                    newBook.Input();
                }

                int choice = -1;
                Book book = new();
                while (choice != 0)
                {
                    Write("1 - Add book\n2 - Del book\n3 - Change book info\n4 - Search\n5 - Add to start\n6 - Add to end\n7 - Add at index\n8 - Del first\n9 - Del last\n10 - Del at index\n0 - Exit\n: ");
                    switch (choice)
                    {
                        case 1:
                            WriteLine("Enter new book:");
                            book.Input();
                            library.AddLast(book);
                            break;
                        case 2:
                            library.RemoveLast();
                            break;
                        case 3:
                            Write("Enter index: ");
                            int index = int.Parse(ReadLine());
                            if (index < 0 || index > library.Count - 1) throw new Exception();

                            library.
                            break;
                    }
                }
                */

                //task 2
                Dictionary<string, List<string>> dict = new();
                Write("Enter count of words: ");
                int size = int.Parse(ReadLine());

                for (int i = 0; i < size; i++)
                {
                    AddWord(ref dict);
                }

                foreach (var item in dict)
                {
                    Write($"{item.Key}: ");
                    foreach (var translation in item.Value)
                    {
                        Write($"{translation} ");
                    }
                    WriteLine();
                }

                int choice = -1;
                while (choice != 0)
                {
                    Write("1 - Add new word and translations\n2 - Remove word\n3 - Remove translations\n4 - Change word\n5 - Change translation\n6 - Search translations\n0 - Exit\n: ");
                    if (!int.TryParse(ReadLine(), out choice))
                    {
                        throw new Exception();
                    }
                    if (!Check(choice)) throw new Exception();

                    switch (choice)
                    {
                        case 1:
                            AddWord(ref dict);
                            break;
                        case 2:
                            Write("Enter word: ");
                            string key = ReadLine() ?? "";
                            dict.Remove()
                            break;
                        case 3:
                            Write("Enter word: ");
                            string key = ReadLine() ?? "";
                            if (!dict.Remove(key)) throw new Exception();
                            WriteLine("Key successfully removed");
                            break;
                    }
                }
            }
            catch (Exception e)
            {
                WriteLine(e.Message);
            }
        }
    }
}
