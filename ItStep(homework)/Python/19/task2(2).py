#2
def greet():
    try:
        name = input("Введіть ім'я: ")
        age = int(input("Введіть вік: "))
        if age < 0 or age > 130:
            raise Exception
    except Exception:
        print("Ви ввели не коректний вік")
    return f"Привіт, {name}! Твій вік - {age}"

print(greet())