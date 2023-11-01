import random

x = int(input("Введіть кількість елементів: "))
y = [random.randint(-10, 10) for i in range(x)]

m = lambda x: max(x)

print(y, m(y))