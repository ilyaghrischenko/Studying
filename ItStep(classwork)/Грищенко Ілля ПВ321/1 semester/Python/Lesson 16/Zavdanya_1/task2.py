import random

x = int(input("Введіть кількість елементів: "))
y = [random.randint(-10, 10) for i in range(x)]

def m_y(y):
    m = 0
    for i in y:
        if i > m:
            m = i
    return m

print(y, '\n', m_y(y))