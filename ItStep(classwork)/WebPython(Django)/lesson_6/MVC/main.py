from MVC.controller import GuessNumberController
from view import GuessNumberView

class GuessNumberApp:
    def __init__(self):
        self.controller = GuessNumberController()
        self.view = GuessNumberView()

    def run(self):
        while True:
            user_number = self.view.get_user_input()

            if self.controller.check(user_number):
                print('Correct!')

                choice = input('Do you want to continue?: ')
                if choice == 'n':
                    break
                else:
                    self.controller.generate_new_num()
            else:
                print('Incorrect!')

if __name__ == '__main__':
    app = GuessNumberApp()
    app.run()