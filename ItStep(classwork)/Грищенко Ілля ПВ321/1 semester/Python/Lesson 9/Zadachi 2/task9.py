x = int(input("Введіть 1 число: "))
y = int(input("Введіть 2 число: "))

for i in range (2, x + 1):
    k = 0
    if x % i == 0:
        k += 1
        p = 0
        if y % i == 0:
            p += 1
    if k == p:
        print(f"{i} - Спільний дільник")