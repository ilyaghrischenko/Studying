class Human:
    def __init__(self, pib, birth_date, phone, city, country, address):
        self._pib = pib
        self._birth_date = birth_date
        self._phone = phone
        self._city = city
        self._country = country
        self._address = address

    @property
    def pib(self):
        return self._pib

    @pib.setter
    def pib(self, value):
        self._pib = value

    @property
    def birth_date(self):
        return self._birth_date

    @birth_date.setter
    def birth_date(self, value):
        self._birth_date = value

    @property
    def phone(self):
        return self._phone

    @phone.setter
    def phone(self, value):
        self._phone = value

    @property
    def city(self):
        return self._city

    @city.setter
    def city(self, value):
        self._city = value

    @property
    def country(self):
        return self._country

    @country.setter
    def country(self, value):
        self._country = value

    @property
    def address(self):
        return self._address

    @address.setter
    def address(self, value):
        self._address = value

    def __str__(self):
        return (f"Full name (PIB): {self.pib}\n"
                f"Birth date: {self.birth_date}\n"
                f"Phone: {self.phone}\n"
                f"City: {self.city}\n"
                f"{self.country}\n"
                f"Address: {self.address}")

    def print(self):
        print(self.__str__())
