import random

def pr(x):
    print(x)
    k = 0
    for i in x:
        k1 = 0
        for j in range(1, i + 1):
            if i % j == 0:
                k1 += 1
        if k1 == 2:
            k += 1
    return k

x = [random.randint(0, 10) for i in range(5)]

print("Кількість простих чисел у списку =", pr(x))