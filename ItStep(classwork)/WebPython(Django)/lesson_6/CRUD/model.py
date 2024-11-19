class Persona:
    def __init__(self, name: str, surname: str, age: int):
        self.name = name
        self.surname = surname
        self.age = age

    def __str__(self) -> str:
        return f"{self.name}, {self.surname}, {self.age}"