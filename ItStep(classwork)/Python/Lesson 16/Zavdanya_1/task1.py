import random

def suma(x):
    sum = 0
    for i in x:
        sum += i
    return sum
y = int(input("Введіть кількість елементів: "))
x = [random.randint(-10, 10) for i in range(y)]

print(x, '\n', suma(x))