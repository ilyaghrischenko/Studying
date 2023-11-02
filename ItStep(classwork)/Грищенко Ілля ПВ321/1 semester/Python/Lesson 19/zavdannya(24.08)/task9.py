try:
    x = input("Введіть ім'я файлу: ")
    y = open(f"data/{x}")
    file_y = y.read()
    print("Кількість символів -", len(file_y))
except FileNotFoundError:
    print("Такого файлу не існує!")