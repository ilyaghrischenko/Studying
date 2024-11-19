class Airplane:
    def __init__(self, plane_type, count_passengers, max_count_passengers):
        self._plane_type = plane_type

        if isinstance(count_passengers and max_count_passengers, int):
            self._count_passengers = count_passengers
            self._max_count_passengers = max_count_passengers
        else:
            raise TypeError('count_passengers and max_count_passengers must be integers')

    def __str__(self):
        return (f"plane type: {self._plane_type} count_passengers: {self._count_passengers} max_count_passengers: {self._max_count_passengers}")

    #region magic methods
    def __eq__(self, other):
        if isinstance(other, Airplane):
            return self._plane_type == other._plane_type
        else:
            return False

    def __add__(self, other):
        if isinstance(other, int):
            return Airplane(self._plane_type, self._count_passengers + other, self._max_count_passengers)
        else:
            raise TypeError

    def __sub__(self, other):
        if isinstance(other, int):
            return Airplane(self._plane_type, self._count_passengers - other, self._max_count_passengers)
        else:
            raise TypeError

    def __iadd__(self, other):
        if isinstance(other, int):
            self._count_passengers += other
            return self
        else:
            raise TypeError

    def __isub__(self, other):
        if isinstance(other, int):
            self._count_passengers -= other
            return self
        else:
            raise TypeError

    def __gt__(self, other):
        if isinstance(other, Airplane):
            return self._max_count_passengers > other._max_count_passengers
        else:
            raise TypeError

    def __le__(self, other):
        if isinstance(other, Airplane):
            return self._max_count_passengers <= other._max_count_passengers
        else:
            raise TypeError

    def __ge__(self, other):
        if isinstance(other, Airplane):
            return self._max_count_passengers >= other._max_count_passengers
        else:
            raise TypeError
    #endregion

ap1 = Airplane('1', 10, 25)
ap2 = Airplane('2', 40, 42)
print(f"ap1: {ap1}")
print(f"ap2: {ap2}\n")

print(f"ap1 == ap2: {ap1 == ap2}")
print(f"ap1 + 10: {ap1 + 10}")
print(f"ap1 - 4: {ap1 - 4}\n")
ap1 += 2
print(f"ap1 += 2: {ap1}")
ap1 -= 1
print(f"ap1 -= 1: {ap1}")

print(f"ap1 > ap2: {ap1 > ap2}")
print(f"ap1 <= ap2: {ap1 <= ap2}")
print(f"ap1 >= ap2: {ap1 >= ap2}")