import random

def st(x, y):
    print(x)
    g = [i**y for i in x]
    return g

x = [random.randint(-10, 10) for i in range(10)]
y = int(input("Введіть ступінь: "))

print("Оновлений список:", st(x, y))