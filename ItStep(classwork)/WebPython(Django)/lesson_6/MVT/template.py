class GuessNumberTemplate:
    def get_user_input(self) -> int:
        return int(input("Enter a number: "))

    def print_result(self, result: str):
        print(result)
