import random

x = int(input("Введіть кількість елементів: "))
y = [random.randint(-10, 10) for i in range(x)]

def rev(y):
    return y[::-1]

print(y, '\n', rev(y))