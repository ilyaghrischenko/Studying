import random

def mn(x):
    print(x)
    m = 10
    for i in x:
        if i < m:
            m = i
    return m

x = [random.randint(-10, 10) for i in range(5)]

print("Мінімальне значення у списку =", mn(x))