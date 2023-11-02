# 1
def dil1(x, y):
    d = x / y
    return d

try:
    x = int(input("Введіть 1 число: "))
    y = int(input("Введіть 2 число: "))
    dil1(x, y)
    print(dil1(x, y))
except ValueError:
    print("Введіть число!")
except ZeroDivisionError:
    print("Ділити на 0 неможливо!")