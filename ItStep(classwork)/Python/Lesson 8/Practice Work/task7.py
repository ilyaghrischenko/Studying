x = int(input("Введіть 1 число: "))
y = int(input("Введіть 2 число: "))

if y > x:
    for i in range (y, x - 1, -1):
        print(i)
elif x > y:
    for i in range (x, y - 1, -1):
        print(i)