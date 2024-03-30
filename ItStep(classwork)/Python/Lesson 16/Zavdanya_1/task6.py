import random, math

x = int(input("Введіть кількість елементів: "))
y = [random.randint(1, 10) for i in range(x)]
new_y = []

print("Початковий список:", y)

def f():
    new_y = []
    for i in y:
        new_y.append(math.factorial(i))
    return new_y

print("Змінений список:", f())