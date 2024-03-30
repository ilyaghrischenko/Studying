using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _7
{
    public class BookList(Book[] books)
    {
        private Book[] _books = books;

        public Book[] Books
        {
            get { return _books; }
            set
            {
                if (value.Length < 2) throw new Exception("Books: Invalid value");
                _books = value;
            }
        }

        public void Show()
        {
            WriteLine("List of books:");
            foreach (var item in Books)
            {
                item.Show();
            }
            WriteLine();
        }
        public void Input()
        {
            for (int i = 0; i < _books.Length; i++)
            {
                WriteLine($"{i})");
                _books[i].Input();
            }
        }

        public void Add(Book book)
        {
            Array.Resize(ref _books, Books.Length + 1);
            _books[Books.Length - 1] = book;
        }
        public void Remove()
        {
            Array.Resize(ref _books, Books.Length - 1);
        }
        public bool IsHere(Book book)
        {
            foreach (var item in _books)
            {
                if (item.ToString() == book.ToString()) return true;
            }
            return false;
        }

        static public BookList operator +(BookList my, Book book)
        {
            my.Add(book);
            return my;
        }
        static public BookList operator -(BookList my, int kilk)
        {
            for (int i = 0; i < kilk; ++i)
            {
                my.Remove();
            }
            return my;
        }
    }
}
