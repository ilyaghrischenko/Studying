import random

def ydal(x):
    print(x)
    y = int(input("Введіть число, яке бажаєте видалити: "))
    print()
    new_x = [i for i in x if i != y]
    print("Оновлений список:", new_x)
    k = len(x) - len(new_x)
    return k

x = [random.randint(1, 5) for i in range(10)]

print("Кількість видалених елементів:", ydal(x))