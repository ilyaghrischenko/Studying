try:
    k = int(input("Введіть кількість елементів у списку: "))
    x = [int(input(f"Введіть {i+1} елемент: ")) for i in range(k)]
except ValueError:
    print("Не правильний ввід")
    exit()
try:
    def mas():
        while True:
            n = int(input("\nОберіть дію\n0 - Вийти\n1 - Відображення списку\n2 - Отримання максимального значення у списку\n3 - Отримання мінімального значення у списку\n4 - Відображення значення елемента за індексом, введеним користувачем\n5 - Видалення елемента за індексом, введеним користувачем\n"))
            print()
            if n == 0:
                print("Програму завершено")
                break
            if n == 1:
                print(x)
            if n == 2:
                print(max(x))
            if n == 3:
                print(min(x))
            if n == 4:
                i = int(input("Введіть індекс: "))
                if IndexError:
                    return IndexError
                print(x[i])
            if n == 5:
                i = int(input("Введіть індекс: "))
                if IndexError:
                    return IndexError
                del x[i]
            l = input("Натисніть будь-яку клавішу...")
except IndexError:
    print("Недопустимий індекс")

mas()