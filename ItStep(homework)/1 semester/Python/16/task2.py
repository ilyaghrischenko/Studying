x = int(input("Введіть 1 число: "))
y = int(input("Введіть 2 число: "))

def par(x, y):
    for i in range(x + 1, y):
        if i % 2 == 0:
            print(i, end=' ')

par(x, y)