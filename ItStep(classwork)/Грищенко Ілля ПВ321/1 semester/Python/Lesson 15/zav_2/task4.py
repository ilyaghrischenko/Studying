def bil(x, y):
    if x > y:
        print(x, "Більше число")
    elif x == y:
        print("Числа рівні")
    else:
        print(y, "Більше число")

x = int(input("Введіть 1 число: "))
y = int(input("Введіть 2 число: "))

bil(x, y)