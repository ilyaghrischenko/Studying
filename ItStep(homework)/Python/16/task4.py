import random

x1 = random.randint(-10, 10)
x2 = random.randint(-10, 10)
x3 = random.randint(-10, 10)
x4 = random.randint(-10, 10)
x5 = random.randint(-10, 10)
print("Згенеровані числа:", x1, x2, x3, x4, x5)

def m(x1, x2, x3, x4, x5):
    min = x1
    if x2 < min:
        min = x2
    if x3 < min:
        min = x3
    if x4 < min:
        min = x4
    if x5 < min:
        min = x5
    return min

print("Мінімальне:", m(x1, x2, x3, x4, x5))