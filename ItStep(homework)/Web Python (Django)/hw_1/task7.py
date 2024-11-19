class Book:
    def __init__(self, author, title, genre, year, pages, publisher):
        self.author = author
        self.title = title
        self.genre = genre
        self.year = year
        self.pages = pages
        self.publisher = publisher

    def __repr__(self):
        return f"Book(Author: {self.author}, Title: {self.title}, Genre: {self.genre}, Year: {self.year}, Pages: {self.pages}, Publisher: {self.publisher})"


class BookCollection:
    def __init__(self):
        self.books = {}

    def add_book(self, book):
        self.books[book.title] = book
        print(f"Book '{book.title}' added.")

    def remove_book(self, title):
        if title in self.books:
            del self.books[title]
            print(f"Book '{title}' removed.")
        else:
            print(f"Book with title '{title}' not found.")

    def find_book(self, title):
        return self.books.get(title, f"Book with title '{title}' not found.")

    def update_book(self, title, **kwargs):
        book = self.books.get(title)
        if book:
            for key, value in kwargs.items():
                if hasattr(book, key):
                    setattr(book, key, value)
            print(f"Book '{title}' updated.")
        else:
            print(f"Book with title '{title}' not found.")

    def list_books(self):
        if self.books:
            for book in self.books.values():
                print(book)
        else:
            print("The book collection is empty.")


# Example usage
collection = BookCollection()

# Adding books
book1 = Book("William Shakespeare", "Hamlet", "Tragedy", 1603, 200, "English Publishing House")
book2 = Book("Leo Tolstoy", "War and Peace", "Novel", 1869, 1225, "Russian Publishing House")

collection.add_book(book1)
collection.add_book(book2)

# Finding a book
print(collection.find_book("Hamlet"))

# Updating book data
collection.update_book("Hamlet", pages=220, publisher="New English Publishing House")

# Removing a book
collection.remove_book("War and Peace")

# Listing all books
collection.list_books()
