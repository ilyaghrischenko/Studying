d = int(input("Введіть діаметр кола: "))
pi = 3.14

n = int(input("1 - площа, 2 - периметр: "))
if n == 1:
    pl = pi * (d/2)**2
    print(f"Площа = {pl}")
elif n == 2:
    per = 2 * pi * (d/2)
    print(f"Периметр = {per}")