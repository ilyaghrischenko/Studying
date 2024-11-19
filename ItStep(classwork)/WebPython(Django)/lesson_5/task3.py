class Library:
    def __init__(self, name, address, books_count):
        self._name = name
        self._address = address

        if isinstance(books_count, int):
            self._books_count = books_count
        else:
            raise TypeError("Books count must be an integer")

        self._error_count_message = "Books count must be an integer"
        self._error_library_message = "Parameter is not Library"

    def __str__(self):
        return f"books count - {self._books_count}"

    @property
    def books_count(self):
        return self._books_count

    @books_count.setter
    def books_count(self, value):
        self._books_count = value

    #region operations
    def __add__(self, number):
        if isinstance(number, int):
            return Library(self._name, self._address, self._books_count + number)
        else:
            raise TypeError(self._error_count_message)

    def __sub__(self, number):
        if isinstance(number, int):
            return Library(self._name, self._address, self._books_count - number)
        else:
            raise TypeError(self._error_count_message)

    def __iadd__(self, number):
        if isinstance(number, int):
            self._books_count += number
            return self
        else:
            raise TypeError(self._error_count_message)

    def __isub__(self, number):
        if isinstance(number, int):
            self._books_count -= number
            return self
        else:
            raise TypeError(self._error_count_message)
    #endregion

    #region comp operations
    def __le__(self, other):
        if isinstance(other, Library):
            return self._books_count <= other.books_count
        else:
            raise TypeError(self._error_library_message)

    def __ge__(self, other):
        if isinstance(other, Library):
            return self._books_count >= other.books_count
        else:
            raise TypeError(self._error_library_message)

    def __eq__(self, other):
        if isinstance(other, Library):
            return self._books_count == other.books_count
        else:
            raise TypeError(self._error_library_message)

    def __neq__(self, other):
        if isinstance(other, Library):
            return self._books_count != other.books_count
        else:
            raise TypeError(self._error_library_message)
    #endregion

l1 = Library('1', '1', 10)

print(f"add: {l1 + 2}")
print(f"sub: {l1 - 2}")

l1 += 10
print(f"iadd: {l1}")
l1 -= 2
print(f"isub: {l1}\n")

l2 = Library('2', '2', 20)
print(f"l1: {l1}\n"
      f"l2: {l2}")

print(f"l1 <= l2: {l1 <= l2}")
print(f"l1 >= l2: {l1 >= l2}")
print(f"l1 == l2: {l1 == l2}")
print(f"l1 != l2: {l1 != l2}")