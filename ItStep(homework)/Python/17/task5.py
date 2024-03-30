import random

def sp(x, y):
    print("Перший список", x)
    print("Другий список", y)

    t = x + y
    return t

x = [random.randint(-10, 10) for i in range(10)]
y = [random.randint(-10, 10) for i in range(10)]

print("Змішаний список:", sp(x, y))