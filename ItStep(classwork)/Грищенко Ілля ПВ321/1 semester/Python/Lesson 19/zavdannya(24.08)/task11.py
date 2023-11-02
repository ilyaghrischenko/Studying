try:
    x = input("Введіть ім'я файлу: ")
    y = open(f"data/{x}")
    file_y = y.read()
    print("Кількість слів -", len(file_y.split()))
except FileNotFoundError:
    print("Такого файлу не існує!")