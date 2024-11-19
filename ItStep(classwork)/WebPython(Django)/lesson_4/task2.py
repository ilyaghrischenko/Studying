from abc import ABC, abstractmethod

#region classes
class Detail(ABC):
    @abstractmethod
    def get_info(self):
        pass

    @abstractmethod
    def calculate_price(self):
        pass

class Wheel(Detail):
    def __init__(self, size, price):
        self.size = size
        self.price = price

    def get_info(self):
        return f"Wheel: {self.size} inches"

    def calculate_price(self):
        return self.price


class Engine(Detail):
    def __init__(self, power, price):
        self.power = power
        self.price = price

    def get_info(self):
        return f"Engine: {self.power} HP"

    def calculate_price(self):
        return self.price


class Door(Detail):
    def __init__(self, material, price):
        self.material = material
        self.price = price

    def get_info(self):
        return f"Door: {self.material} material"

    def calculate_price(self):
        return self.price


class Car(Wheel, Engine, Door):
    def __init__(self, wheel_size, engine_power, door_material):
        Wheel.__init__(self, wheel_size, 100)
        Engine.__init__(self, engine_power, 3000)
        Door.__init__(self, door_material, 500)

    def get_full_info(self):
        wheel_info = self.get_info()
        engine_info = Engine.get_info(self)
        door_info = Door.get_info(self)

        return f"{wheel_info}, {engine_info}, {door_info}"

    def calculate_total_price(self):
        return self.calculate_price() + Engine.calculate_price(self) + Door.calculate_price(self)
#endregion

car = Car(17, 150, "Steel")

print(car.get_full_info())  # Виведе: Wheel: 17 inches, Engine: 150 HP, Door: Steel material
print(f"Total Car Price: ${car.calculate_total_price()}")