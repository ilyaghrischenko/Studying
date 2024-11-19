from MVT.model import GuessNumberModel
from MVT.view import GuessNumberView
from MVT.template import GuessNumberTemplate


class GuessNumberApp:
    def __init__(self, view: GuessNumberView, template: GuessNumberTemplate):
        self.view = view
        self.template = template

    def run(self):
        while True:
            user_input = self.template.get_user_input()

            if self.view.check(user_input):
                if not self.view.ask_to_continue():
                    break