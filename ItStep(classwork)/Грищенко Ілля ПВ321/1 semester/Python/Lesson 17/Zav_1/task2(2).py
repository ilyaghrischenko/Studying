# 2
def dil2(x, y):
    d = x / y
    try:
        x = int(input("Введіть 1 число: "))
        y = int(input("Введіть 2 число: "))
        if y == 0:
            raise ZeroDivisionError
    except ZeroDivisionError:
        print("На 0 ділити не можна")
    
    return d

print(dil2(x, y))