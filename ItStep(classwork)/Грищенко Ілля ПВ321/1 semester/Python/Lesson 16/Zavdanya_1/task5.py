import random

x = int(input("Введіть кількість елементів: "))
y = [random.randint(-10, 10) for i in range(x)]

def povt(y):
    k_p = 0
    p = int(input("Введіть число: "))
    for i in y:
        if i == p:
           k_p += 1
    return k_p
           
print(y, '\nКількість повторень:', povt(y))