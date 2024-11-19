from model import GuessNumberModel
from random import randint

class GuessNumberController:
    def __init__(self, min: int = 1, max: int = 5):
        self.min = min
        self.max = max
        self.random_number = randint(min, max)

    def generate_new_num(self):
        self.random_number = randint(self.min, self.max)

    def check(self, input: int) -> bool:
        model = GuessNumberModel(input, self.random_number)
        return True if model.user_number == self.random_number else False