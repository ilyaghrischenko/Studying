class PersonaTemplate:
    def get_variant(self) -> int:
        return int(input('1 - Create\n'
                         '2 - Read\n'
                         '3 - Update\n'
                         '4 - Delete\n'
                         ': '))

    def print_result(self, text):
        print(text)