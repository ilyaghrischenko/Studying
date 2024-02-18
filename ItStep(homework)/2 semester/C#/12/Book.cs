using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _12
{
    public class Book
    {
        public enum BookGenre
        {
            Visions,
            ShortStory,
            Ode,
            Opus,
            Essay,
            Poem,
            Tale,
            Play
        }

        public string Name { get; set; } = "NoName";
        public string Pib { get; set; } = "NoPib";
        public BookGenre Genre { get; set; } = BookGenre.Tale;
        public int Year { get; set; } = 2024;

        public Book() { }
        public Book(string name, string pib, BookGenre genre, int year)
        {
            Name = name;
            Pib = pib;
            Genre = genre;
            Year = year;
        }

        public void Input()
        {
            Write("Name: ");
            Name = ReadLine();

            Write("Pib: ");
            Pib = ReadLine();

            Write("Genre: ");
            Genre = (BookGenre)Enum.Parse(typeof(BookGenre), ReadLine());

            Write("Year: ");
            Year = int.Parse(ReadLine());
        }
        public void Show()
        {
            WriteLine(this);
        }

        public override string ToString()
        {
            return $"Name: {Name} || Pib: {Pib} || Genre: {Genre} || Year: {Year}";
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || obj is not Book) return false;
            var other = obj as Book;
            return ToString() == other.ToString();
        }
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
    }
}
