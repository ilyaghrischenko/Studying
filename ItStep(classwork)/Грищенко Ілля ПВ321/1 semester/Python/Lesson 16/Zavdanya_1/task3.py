import random

x = int(input("Введіть кількість елементів: "))
y = [random.randint(-10, 10) for i in range(x)]

def ob(y):
    p = 0
    np = 0
    d = 0
    vid = 0
    for i in y:
        if i == 0:
            continue
        if i < 0:
            vid += 1
        if i > 0:
            d += 1
        if i % 2 == 0:
            p += 1
        if i % 2 != 0:
            np += 1
    print(f"Список - {y}\nПарних {p}\nНепарних {np}\nДодатних {d}\nВід'ємних {vid}")
    
ob(y)