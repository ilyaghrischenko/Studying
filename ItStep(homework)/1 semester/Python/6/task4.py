x = int(input("Введіть 1 число: "))
y = int(input("Введіть 2 число: "))

if x != y:
    if x > y:
        print(f"{y}\n{x}")
    elif y > x:
        print(f"{x}\n{y}")