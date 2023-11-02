x = int(input("Введіть 1 число: "))
y = int(input("Введіть 2 число: "))

for i in range (x, y+1):
    if i % 2 != 0:
        print(i)