class Circle:
    def __init__(self, radius, length):
        if isinstance(radius and length, int or float):
            self._radius = radius
            self._length = length
        else:
            raise TypeError('radius and length must be an int or float')

    def __str__(self):
        return f"radius - {self._radius} length - {self._length}"

    #region props
    @property
    def radius(self):
        return self._radius

    @radius.setter
    def radius(self, radius):
        if isinstance(radius, int or float):
            self._radius = radius

    @property
    def length(self):
        return self._length

    @length.setter
    def length(self, length):
        if isinstance(length, int or float):
            self._length = length
    #endregion

    #region magic methods
    def __eq__(self, other):
        if isinstance(other, Circle):
            return self._radius == other._radius and self._length == other._length
        else:
            return False

    def __gt__(self, other):
        if isinstance(other, Circle):
            return self._radius > other._radius
        else:
            return False

    def __le__(self, other):
        if isinstance(other, Circle):
            return self._radius <= other._radius
        else:
            return False

    def __ge__(self, other):
        if isinstance(other, Circle):
            return self._radius >= other._radius
        else:
            return False

    def __add__(self, other):
        if isinstance(other, Circle):
            return Circle(self._radius + other._radius, self._length + other._length)
        else:
            raise TypeError('Parameter is not Circle')

    def __sub__(self, other):
        if isinstance(other, Circle):
            return Circle(self._radius - other._radius, self._length - other._length)
        else:
            raise TypeError('Parameter is not Circle')

    def __iadd__(self, number):
        if isinstance(number, int or float):
            multiplier = self._radius / self._radius + number
            self._radius += number
            self._length *= multiplier
            return self
        else:
            raise TypeError('Parameter is not int or float')

    def __isub__(self, number):
        if isinstance(number, int or float):
            multiplier = self._radius / self._radius - number
            self._radius -= number
            self._length /= multiplier
            return self
        else:
            raise TypeError('Parameter is not int or float')
    #endregion

c1 = Circle(5, 5)
c2 = Circle(7, 2)
print(f"first circle: {c1}")
print(f"second circle: {c2}\n")

print(f"c1 == c2: {c1 == c2}")
print(f"c1 > c2: {c1 > c2}")
print(f"c1 <= c2: {c1 <= c2}")
print(f"c1 >= c2: {c1 >= c2}\n")

c2 += 3
print(f"c2 += 3: {c2}")
c2 -= 6
print(f"c2 -= 6: {c2}")