a = int(input("Введіть 1 число: "))
b = int(input("Введіть 2 число: "))
c = int(input("Введіть 3 число: "))

x = int(input("1 - максимум із трьох\n2 - мінімум із трьох\n3 - середньоарифметичне трьох чисел\n"))

if x == 1:
    if a > b and a > c:
        print(f"Максимальне число 1 - {a}")
    elif b > a and b > c:
        print(f"Максимальне число 2 - {b}")
    elif c > a and c > b:
        print(f"Максимальне число 3 - {c}")
elif x == 2:
    if a < b and a < c:
        print(f"Мінімальне число 1 - {a}")
    elif b < a and b < c:
        print(f"Мінімальне число 2 - {b}")
    elif c < a and c < b:
        print(f"Мінімальне число 3 - {c}")
elif x == 3:
    print((a + b + c) / 3)