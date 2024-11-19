class Flat:
    def __init__(self, square, price):
        if isinstance(square and price, (int, float)):
            self._square = square
            self._price = price
        else:
            raise TypeError

    def __str__(self):
        return f"square - {self._square}, price - {self._price}"

    #region magic methods
    def __eq__(self, other):
        if isinstance(other, Flat):
            return self._square == other._square
        else:
            return False

    def __ne__(self, other):
        if isinstance(other, Flat):
            return self._square != other._square
        else:
            return True

    def __gt__(self, other):
        if isinstance(other, Flat):
            return self._price > other._price
        else:
            raise TypeError

    def __le__(self, other):
        if isinstance(other, Flat):
            return self._price <= other._price
        else:
            raise TypeError

    def __ge__(self, other):
        if isinstance(other, Flat):
            return self._price >= other._price
        else:
            raise TypeError
    #endregion

f1 = Flat(100, 10000)
f2 = Flat(80, 8000)
print(f"f1: {f1}")
print(f"f2: {f2}\n")

print(f"f1 == f2: {f1 == f2}")
print(f"f1 != f2: {f1 != f2}")
print(f"f1 > f2: {f1 > f2}")
print(f"f1 <= f2: {f1 <= f2}")
print(f"f1 >= f2: {f1 >= f2}")