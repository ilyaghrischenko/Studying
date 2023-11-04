import random

def dob(x):
    print(x)
    d = 1
    for i in x:
        d *= i
    return d

x = [random.randint(-10, 10) for i in range(5)]

print("Добуток елементів списку =", dob(x))