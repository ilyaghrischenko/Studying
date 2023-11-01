import random

x = int(input("Введіть кількість елементів: "))
y = [random.randint(-10, 10) for i in range(x)]

rev = lambda x: x[::-1]

print(y, '\n', rev(y))