#region classes
class Car:
    def __init__(self, wheel_size, engine_power, door_material):
        self.wheel_size = wheel_size
        self.engine_power = engine_power
        self.door_material = door_material

    def get_info(self):
        return f"Car with wheels: {self.wheel_size} inches, engine: {self.engine_power} HP, doors: {self.door_material}"

    def __str__(self):
        return self.get_info()


class CarPark:
    def __init__(self):
        self.cars = []

    def add_car(self, car):
        self.cars.append(car)
        print(f"Car added: {car}")

    def remove_car(self, car):
        if car in self.cars:
            self.cars.remove(car)
            print(f"Car removed: {car}")
        else:
            print("Car not found in the park.")

    def print_cars(self):
        if not self.cars:
            print("The car park is empty.")
        else:
            print("Cars in the park:")
            for car in self.cars:
                print(car)
#endregion

park = CarPark()

car1 = Car(17, 150, "Steel")
car2 = Car(19, 200, "Aluminum")
car3 = Car(16, 120, "Plastic")

park.add_car(car1)
park.add_car(car2)

park.print_cars()
park.remove_car(car1)
park.print_cars()
park.remove_car(car3)