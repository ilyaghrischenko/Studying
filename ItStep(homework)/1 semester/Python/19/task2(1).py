#1
def greet():
    name = input("Введіть ім'я: ")
    age = int(input("Введіть вік: "))
    if age < 0 or age > 130:
        raise Exception
    return f"Привіт, {name}! Твій вік - {age}"

try:
    print(greet())
except Exception:
    print("Ви ввели не коректний вік")