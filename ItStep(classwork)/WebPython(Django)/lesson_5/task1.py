class Digit:
    def __init__(self, value):
        if isinstance(value, int):
            self._value = value
        else:
            self._value = 0

    def __str__(self):
        return str(self._value)

    #region operations
    def __add__(self, other):
        if isinstance(other, Digit):
            return self._value + other._value
        else:
            raise TypeError

    def __sub__(self, other):
        if isinstance(other, Digit):
            return self._value - other._value
        else:
            raise TypeError

    def __mul__(self, other):
        if isinstance(other, Digit):
            return self._value * other._value
        else:
            raise TypeError

    def __truediv__(self, other):
        if isinstance(other, Digit):
            return self._value / other._value
        else:
            raise TypeError
    #endregion

first = Digit('string')
print(f"{first}\n")

first = Digit(13)
second = Digit(2)
print(first + second)
print(first - second)
print(first * second)
print(first / second)

second = 2
try:
    print(first + second)
except TypeError:
    print('TypeError')