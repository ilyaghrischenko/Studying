using static System.Console;

namespace _12
{
    internal class Program
    {
        static bool Check(int choice)
        {
            List<int> variants = new() { 0, 1, 2, 3, 4, 5, 6 };
            return (variants.Contains(choice)) ? true : false;
        }

        //task 1
        /*
        static void AddBook(ref LinkedList<Book> library)
        {
            Write("Title: ");
            string title = ReadLine();
            Write("Author: ");
            string author = ReadLine();
            Write("Genre: ");
            string genre = ReadLine();
            Write("Year: ");
            int year = int.Parse(ReadLine() ?? "0");

            Book book = new Book(title, author, genre, year);
            library.AddLast(book);
        }
        static void DisplayBooks(LinkedList<Book> library)
        {
            foreach (var book in library)
            {
                WriteLine(book);
            }
        }
        */

        //task 2
        /*
        static void AddWord(ref Dictionary<string, List<string>> dict)
        {
            Write("English word: ");
            string word = ReadLine();
            if (string.IsNullOrEmpty(word)) throw new Exception("Word cannot be empty!");

            List<string> translations = new List<string>();
            string translation;
            do
            {
                Write("French translation (0 - exit): ");
                translation = ReadLine();
                if (translation != "0" && !string.IsNullOrEmpty(translation))
                {
                    translations.Add(translation);
                }
            } while (translation != "0");

            dict[word] = translations;
        }
        static void DisplayDictionary(Dictionary<string, List<string>> dict)
        {
            foreach (var kvp in dict)
            {
                Write($"{kvp.Key}: ");
                foreach (var translation in kvp.Value)
                {
                    Write($"{translation} ");
                }
                WriteLine();
            }
        }
        */

        static void Main(string[] args)
        {
            //task 1
            /*
            try
            {
                LinkedList<Book> library = new LinkedList<Book>();

                int choice = -1;
                while (choice != 0)
                {
                    WriteLine("========= Main Menu =========");
                    WriteLine("1 - Add Book");
                    WriteLine("2 - Remove Book");
                    WriteLine("3 - Update Book Info");
                    WriteLine("4 - Search Books");
                    WriteLine("5 - Display All Books");
                    WriteLine("0 - Exit");
                    WriteLine("=============================");

                    Write("Enter your choice: ");
                    if (!int.TryParse(ReadLine(), out choice))
                    {
                        throw new Exception("Invalid input! Please enter a number.");
                    }
                    if (!Check(choice)) throw new Exception("Invalid option!");

                    switch (choice)
                    {
                        case 1:
                            AddBook(ref library);
                            break;
                        case 2:
                            Write("Enter the title of the book to remove: ");
                            string titleToRemove = ReadLine();
                            bool removed = false;
                            foreach (var book in library)
                            {
                                if (book.Title.Equals(titleToRemove, StringComparison.OrdinalIgnoreCase))
                                {
                                    library.Remove(book);
                                    removed = true;
                                    break;
                                }
                            }
                            if (removed)
                            {
                                WriteLine($"Book '{titleToRemove}' removed successfully.");
                            }
                            else
                            {
                                WriteLine($"Book '{titleToRemove}' not found.");
                            }
                            break;

                        case 3:
                            Write("Enter the title of the book to update: ");
                            string titleToUpdate = ReadLine();
                            foreach (var book in library)
                            {
                                if (book.Title.Equals(titleToUpdate, StringComparison.OrdinalIgnoreCase))
                                {
                                    Write("New Title: ");
                                    string newTitle = ReadLine();
                                    Write("New Author: ");
                                    string newAuthor = ReadLine();
                                    Write("New Genre: ");
                                    string newGenre = ReadLine();
                                    Write("New Year: ");
                                    int newYear = int.Parse(ReadLine() ?? "0");

                                    book.Title = newTitle;
                                    book.Author = newAuthor;
                                    book.Genre = ReadLine();
                                    book.Year = newYear;

                                    WriteLine($"Book '{titleToUpdate}' updated successfully.");
                                    break;
                                }
                            }
                            break;

                        case 4:
                            Write("Enter the title of the book to search: ");
                            string searchTitle = ReadLine();
                            bool found = false;
                            foreach (var book in library)
                            {
                                if (book.Title.Equals(searchTitle, StringComparison.OrdinalIgnoreCase))
                                {
                                    WriteLine($"Book found: {book}");
                                    found = true;
                                    break;
                                }
                            }
                            if (!found)
                            {
                                WriteLine($"Book '{searchTitle}' not found.");
                            }
                            break;
                        case 5:
                            WriteLine("========= All Books =========");
                            DisplayBooks(library);
                            WriteLine("=============================");
                            break;
                        case 0:
                            WriteLine("Exiting...");
                            break;
                        default:
                            WriteLine("Invalid choice! Please choose a valid option.");
                            break;
                    }
                }
            }
            catch (Exception e)
            {
                WriteLine($"Error: {e.Message}");
            }
            */

            //task 2
            /*
            try
            {
                Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

                int choice = -1;
                while (choice != 0)
                {
                    WriteLine("========= Main Menu =========");
                    WriteLine("1 - Add Word and Translations");
                    WriteLine("2 - Remove Word");
                    WriteLine("3 - Remove Translations");
                    WriteLine("4 - Change Word");
                    WriteLine("5 - Change Translation");
                    WriteLine("6 - Search Translations");
                    WriteLine("0 - Exit");
                    WriteLine("=============================");

                    Write("Enter your choice: ");
                    if (!int.TryParse(ReadLine(), out choice))
                    {
                        throw new Exception("Invalid input! Please enter a number.");
                    }

                    switch (choice)
                    {
                        case 1:
                            AddWord(ref dict);
                            break;
                        case 2:
                            Write("Enter the English word to remove: ");
                            string wordToRemove = ReadLine();
                            if (dict.ContainsKey(wordToRemove))
                            {
                                dict.Remove(wordToRemove);
                                WriteLine($"Word '{wordToRemove}' removed successfully.");
                            }
                            else
                            {
                                WriteLine($"Word '{wordToRemove}' not found.");
                            }
                            break;

                        case 3:
                            Write("Enter the English word to remove translations: ");
                            string wordToRemoveTranslations = ReadLine();
                            if (dict.ContainsKey(wordToRemoveTranslations))
                            {
                                dict[wordToRemoveTranslations].Clear();
                                WriteLine($"Translations of '{wordToRemoveTranslations}' removed successfully.");
                            }
                            else
                            {
                                WriteLine($"Word '{wordToRemoveTranslations}' not found.");
                            }
                            break;

                        case 4:
                            Write("Enter the English word to change: ");
                            string wordToChange = ReadLine();
                            if (dict.ContainsKey(wordToChange))
                            {
                                Write("Enter new English word: ");
                                string newWord = ReadLine();
                                dict[newWord] = dict[wordToChange];
                                dict.Remove(wordToChange);
                                WriteLine($"Word '{wordToChange}' changed to '{newWord}' successfully.");
                            }
                            else
                            {
                                WriteLine($"Word '{wordToChange}' not found.");
                            }
                            break;

                        case 5:
                            Write("Enter the English word to change translation: ");
                            string wordToChangeTranslation = ReadLine();
                            if (dict.ContainsKey(wordToChangeTranslation))
                            {
                                Write("Enter the translation to change: ");
                                string translationToChange = ReadLine();
                                if (dict[wordToChangeTranslation].Contains(translationToChange))
                                {
                                    Write("Enter the new translation: ");
                                    string newTranslation = ReadLine();
                                    int index = dict[wordToChangeTranslation].IndexOf(translationToChange);
                                    dict[wordToChangeTranslation][index] = newTranslation;
                                    WriteLine($"Translation of '{wordToChangeTranslation}' changed successfully.");
                                }
                                else
                                {
                                    WriteLine($"Translation '{translationToChange}' not found.");
                                }
                            }
                            else
                            {
                                WriteLine($"Word '{wordToChangeTranslation}' not found.");
                            }
                            break;

                        case 6:
                            Write("Enter the English word to search translations: ");
                            string wordToSearch = ReadLine();
                            if (dict.ContainsKey(wordToSearch))
                            {
                                WriteLine($"Translations of '{wordToSearch}':");
                                foreach (var translation in dict[wordToSearch])
                                {
                                    WriteLine(translation);
                                }
                            }
                            else
                            {
                                WriteLine($"Word '{wordToSearch}' not found.");
                            }
                            break;

                        case 0:
                            WriteLine("Exiting...");
                            break;
                        default:
                            WriteLine("Invalid choice! Please choose a valid option.");
                            break;
                    }
                }
            }
            catch (Exception e)
            {
                WriteLine($"Error: {e.Message}");
            }
            */

            //task 3
            /*
            const int numPriorities = 3;
            var queue = new PriorityQueue<string>(numPriorities);

            WriteLine("Welcome to the clinic queue simulation!");

            try
            {
                int patientCount = 0;
                while (true)
                {
                    if (patientCount % numPriorities == 0 && patientCount > 0)
                    {
                        WriteLine("A high priority patient has arrived! They will be placed at the end of the queue.");
                        queue.Enqueue($"High Priority Patient {patientCount}", numPriorities - 1);
                    }
                    else
                    {
                        WriteLine("A patient has arrived! They will be placed in the queue.");
                        queue.Enqueue($"Patient {patientCount}", 0);
                    }

                    patientCount++;

                    if (!queue.IsEmpty())
                    {
                        var patient = queue.Dequeue();
                        WriteLine($"Doctor is now seeing: {patient}");
                        Thread.Sleep(2000);
                    }
                    else
                    {
                        WriteLine("No patients in the queue. Doctor is resting.");
                        Thread.Sleep(3000);
                    }
                }
            }
            catch (Exception ex)
            {
                WriteLine($"Error: {ex.Message}");
            }
            */
        }
    }
}
