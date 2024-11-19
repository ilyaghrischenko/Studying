class City:
    def __init__(self, name, region, country, citizens_count, mail_index, phone_code):
        self._name = name
        self._region = region
        self._country = country
        self._citizens_count = citizens_count
        self._mail_index = mail_index
        self._phone_code = phone_code

    @property
    def name(self):
        return self._name

    @name.setter
    def name(self, value):
        self._name = value

    @property
    def region(self):
        return self._region

    @region.setter
    def region(self, value):
        self._region = value

    @property
    def country(self):
        return self._country

    @country.setter
    def country(self, value):
        self._country = value

    @property
    def citizens_count(self):
        return self._citizens_count

    @citizens_count.setter
    def citizens_count(self, value):
        self._citizens_count = value

    @property
    def mail_index(self):
        return self._mail_index

    @mail_index.setter
    def mail_index(self, value):
        self._mail_index = value

    @property
    def phone_code(self):
        return self._phone_code

    @phone_code.setter
    def phone_code(self, value):
        self._phone_code = value

    def __str__(self):
        return (f"Name: {self.name}\n"
                f"Region: {self.region}\n"
                f"Citizens count: {self.citizens_count}\n"
                f"Mail index: {self.mail_index}\n"
                f"Phone code: {self.phone_code}")

    def print(self):
        print(self.__str__())
