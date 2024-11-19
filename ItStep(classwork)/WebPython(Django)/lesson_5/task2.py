class Fraction:
    def __init__(self, numerator, denominator):
        if isinstance(numerator and denominator, int or float):
            self._numerator = numerator

            if denominator != 0:
                self._denominator = denominator
            else:
                raise ZeroDivisionError("Denominator cannot be zero.")
        else:
            raise TypeError

        if denominator < 0:
            numerator = -numerator
            denominator = -denominator

        gcd = self._gcd(abs(numerator), abs(denominator))
        self._numerator = numerator // gcd
        self._denominator = denominator // gcd

    # region props
    @property
    def numerator(self):
        return self._numerator

    @numerator.setter
    def numerator(self, numerator):
        self._numerator = numerator

    @property
    def denominator(self):
        return self._denominator

    @denominator.setter
    def denominator(self, denominator):
        self._denominator = denominator

    # endregion

    # region methods
    def _gcd(self, a, b):
        while b != 0:
            a, b = b, a % b
        return a

    def _lcm(self, a, b):
        return abs(a * b) // self._gcd(a, b)

    def __str__(self):
        return f"{self._numerator}/{self._denominator}"

    # endregion

    #region operations
    def __add__(self, fraction):
        lcm = self._lcm(self._denominator, fraction.denominator)
        new_numerator_self = self._numerator * (lcm // self._denominator)
        new_numerator_fraction = fraction.numerator * (lcm // fraction.denominator)
        new_numerator = new_numerator_self + new_numerator_fraction
        return Fraction(new_numerator, lcm)

    def __sub__(self, fraction):
        lcm = self._lcm(self._denominator, fraction.denominator)
        new_numerator_self = self._numerator * (lcm // self._denominator)
        new_numerator_fraction = fraction.numerator * (lcm // fraction.denominator)
        new_numerator = new_numerator_self - new_numerator_fraction
        return Fraction(new_numerator, lcm)

    def __mul__(self, fraction):
        new_numerator = self._numerator * fraction.numerator
        new_denominator = self._denominator * fraction.denominator
        return Fraction(new_numerator, new_denominator)

    def __truediv__(self, fraction):
        if fraction.numerator == 0:
            raise ZeroDivisionError("Cannot divide by a fraction with a numerator of zero.")
        new_numerator = self._numerator * fraction.denominator
        new_denominator = self._denominator * fraction.numerator
        return Fraction(new_numerator, new_denominator)
    # endregion

f1 = Fraction(1, 2)
f2 = Fraction(34, 52)

print(f"first: {f1}")
print(f"second: {f2}\n")

print(f"plus: {f1 + f2}")
print(f"substract: {f1 - f2}")
print(f"divide: {f1 / f2}")
print(f"multiply: {f1 * f2}\n")

try:
    f3 = Fraction(2, 0)
except ZeroDivisionError:
    print("ZeroDivisionError")
