try:
    name = input("Введіть ім'я: ")
    age = int(input("Введіть вік: "))
    if age < 0 or age > 130:
        raise Exception
    print(f"Привіт, {name}! Твій вік - {age}")
except Exception:
    print("Ви ввели не коректний вік")