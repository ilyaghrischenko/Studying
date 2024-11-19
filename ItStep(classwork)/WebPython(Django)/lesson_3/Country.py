class Country:
    def __init__(self, name, continent, citizens_count, phone_code, capital_name, cities):
        self._name = name
        self._continent = continent
        self._citizens_count = citizens_count
        self._phone_code = phone_code
        self._capital_name = capital_name
        self._cities = cities

    @property
    def name(self):
        return self._name

    @name.setter
    def name(self, value):
        self._name = value

    @property
    def continent(self):
        return self._continent

    @continent.setter
    def continent(self, value):
        self._continent = value

    @property
    def citizens_count(self):
        return self._citizens_count

    @citizens_count.setter
    def citizens_count(self, value):
        self._citizens_count = value

    @property
    def phone_code(self):
        return self._phone_code

    @phone_code.setter
    def phone_code(self, value):
        self._phone_code = value

    @property
    def capital_name(self):
        return self._capital_name

    @capital_name.setter
    def capital_name(self, value):
        self._capital_name = value

    @property
    def cities(self):
        return self._cities

    @cities.setter
    def cities(self, value):
        self._cities = value

    def __str__(self):
        return (f"Country: {self.name}, located in {self.continent}, has {self.citizens_count} citizens.\n"
                f"Phone code: {self.phone_code}, Capital: {self.capital_name}\n"
                f"Cities: {self.cities}")

    def print(self):
        print(self.__str__())
