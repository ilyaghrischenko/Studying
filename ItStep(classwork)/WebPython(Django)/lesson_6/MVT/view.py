from MVT.model import GuessNumberModel
from random import randint

from MVT.template import GuessNumberTemplate


class GuessNumberView:
    def __init__(self, template: GuessNumberTemplate, min: int = 1, max: int = 5):
        self.rand_num = randint(min, max)
        self.template = template
        self.min = min
        self.max = max

    def check(self, user_input: int) -> bool:
        model = GuessNumberModel(user_input, self.rand_num)
        result = True if model.user_number == model.rand_num else False

        if result:
            self.template.print_result('Correct!')
            return True
        else:
            self.template.print_result('Wrong!')
            return False

    def generate_new_rand_num(self):
        self.rand_num = randint(self.min, self.max)

    def ask_to_continue(self) -> bool:
        choice = input('Do you want to continue? (y/n): ')
        return choice.lower() == 'y'