class Date:
    def __init__(self, year, month, day):
        if isinstance(year and month and day, int):
            self._year = year
            self._month = month
            self._day = day
        else:
            raise TypeError

    def __str__(self):
        return f"{self._year}/{self._month}/{self._day}"

    #region methods
    def is_leap_year(self, year):
        if year % 4 == 0:
            if year % 100 == 0:
                if year % 400 == 0:
                    return True
                return False
            return True
        return False

    def days_in_month(self, month, year):
        if month == 2:
            if self.is_leap_year(year):
                return 29
            else:
                return 28
        elif month in [4, 6, 9, 11]:
            return 30

        return 31

    def total_days(self):
        days = self._day
        for month in range(1, self._month):
            days += self.days_in_month(month, self._year)

        for year in range(1, self._year):
            if self.is_leap_year(year):
                days += 366
            else:
                days += 365

        return days

    def add_days(self, days):
        while days > 0:
            days_left_in_month = self.days_in_month(self._month, self._year) - self._day

            if days <= days_left_in_month:
                self._day += days
                break

            days -= days_left_in_month + 1
            self._day = 1
            self._month += 1

            if self._month > 12:
                self._month = 1
                self._year += 1
    #endregion

    #region operations
    def __sub__(self, other):
        if isinstance(other, Date):
            return abs(self.total_days() - other.total_days())
        else:
            raise TypeError("Subtraction only supported between Date objects.")

    def __iadd__(self, days):
        if isinstance(days, int):
            self.add_days(days)
            return self
        else:
            raise TypeError("Days must be an integer.")
    #endregion

d1 = Date(2024, 10, 18)
d2 = Date(2023, 3, 3)
print(f"first date: {d1}")
print(f"second date: {d2}")

result = d1 - d2
print(f"sub result: {result}")

d2 += 3234
print(f"second date + 3234 days: {d2}")