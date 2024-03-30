using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12
{
    public class BookManager
    {
        private LinkedList<Book> library = new LinkedList<Book>();

        public void AddBook(Book book)
        {
            library.AddLast(book);
        }

        public void RemoveBook(Book book)
        {
            library.Remove(book);
        }

        public void UpdateBook(Book oldBook, Book newBook)
        {
            var node = library.Find(oldBook);
            if (node != null)
            {
                node.Value = newBook;
            }
        }

        public void AddBookToStart(Book book)
        {
            library.AddFirst(book);
        }
        public void AddBookToEnd(Book book)
        {
            library.AddLast(book);
        }

        public void InsertBookAt(int index, Book book)
        {
            if (index < 0 || index > library.Count)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }

            var node = library.First;
            for (int i = 0; i < index; i++)
            {
                node = node.Next;
            }

            library.AddBefore(node, book);
        }
        public void RemoveFirstBook()
        {
            if (library.Count > 0)
            {
                library.RemoveFirst();
            }
        }
        public void RemoveLastBook()
        {
            if (library.Count > 0)
            {
                library.RemoveLast();
            }
        }

        public void RemoveBookAt(int index)
        {
            if (index < 0 || index >= library.Count)
            {
                throw new ArgumentOutOfRangeException("Invalid index");
            }

            var node = library.First;
            for (int i = 0; i < index; i++)
            {
                node = node.Next;
            }

            library.Remove(node);
        }
    }
}
