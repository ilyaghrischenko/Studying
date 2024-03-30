x = int(input("Введіть 1 число: "))
y = int(input("Введіть 2 число: "))

if x > y:
    for i in range (y, x + 1):
        if i % 2 != 0:
            print(i)
elif y > x:
    for i in range (x, y + 1):
        if i % 2 != 0:
            print(i)