class Clock:
    def __init__(self, model_name, developer_name, year, price, clock_type):
        self._model_name = model_name
        self._developer_name = developer_name
        self._year = year
        self._price = price
        self._clock_type = clock_type

    #region props
    @property
    def model_name(self):
        return self._model_name

    @model_name.setter
    def model_name(self, model_name):
        self._model_name = model_name

    @property
    def developer_name(self):
        return self._developer_name

    @developer_name.setter
    def developer_name(self, developer_name):
        self._developer_name = developer_name

    @property
    def year(self):
        return self._year

    @year.setter
    def year(self, year):
        self._year = year

    @property
    def price(self):
        return self._price

    @price.setter
    def price(self, price):
        self._price = price

    @property
    def clock_type(self):
        return self._clock_type

    @clock_type.setter
    def clock_type(self, clock_type):
        self._clock_type = clock_type
    #endregion

    #region methods
    def __str__(self):
        return (f"Model name: {self._model_name}\n"
                f"Developer name: {self._developer_name}\n"
                f"Year: {self._year}\n"
                f"Price: {self._price}\n"
                f"Clock type: {self._clock_type}")

    def show(self):
        print(self)

    def input(self):
        self.model_name = input("Model name: ")
        self.developer_name = input("Developer name: ")
        self.year = input("Year: ")
        self.price = input("Price: ")
        self.clock_type = input("Clock type: ")
    #endregion

c1 = Clock("<NAME>", "<NAME>", "2009", 12, "Python")
c1.show()
c1.input()
print(c1)