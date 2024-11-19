class Complex:
    def __init__(self, real, imag):
        if isinstance(real and imag, (int, float)):
            self._real = real
            self._imag = imag
        else:
            raise TypeError('real and imag must be of type int or float')

    def __str__(self):
        return f"{self._real} + {self._imag}i"

    def __add__(self, other):
        if isinstance(other, Complex):
            return Complex(self._real + other._real, self._imag + other._imag)
        else:
            raise TypeError('other must be of type Complex')

    def __sub__(self, other):
        if isinstance(other, Complex):
            return Complex(self._real - other._real, self._imag - other._imag)
        else:
            raise TypeError('other must be of type Complex')

    def __mul__(self, other):
        if isinstance(other, Complex):
            real_part = self._real * other._real - self._imag * other._imag
            imag_part = self._real * other._imag + self._imag * other._real
            return Complex(real_part, imag_part)
        else:
            raise TypeError('other must be of type Complex')

    def __truediv__(self, other):
        if isinstance(other, Complex):
            denom = other._real ** 2 + other._imag ** 2
            real_part = (self._real * other._real + self._imag * other._imag) / denom
            imag_part = (self._imag * other._real - self._real * other._imag) / denom
            return Complex(real_part, imag_part)
        else:
            raise TypeError('other must be of type Complex')

complex1 = Complex(1, 2)
complex2 = Complex(4, 10)
print(f"complex1: {complex1}")
print(f"complex2: {complex2}\n")

print(f"complex1 + complex2: {complex1 + complex2}")
print(f"complex1 - complex2: {complex1 - complex2}")
print(f"complex1 * complex2: {complex1 * complex2}")
print(f"complex1 / complex2: {complex1 / complex2}")