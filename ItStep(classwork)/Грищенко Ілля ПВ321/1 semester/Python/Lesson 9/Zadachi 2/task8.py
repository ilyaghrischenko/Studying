x = int(input("Введіть початок: "))
y = int(input("Введіть кінець: "))

for i in range (x, y + 1):
    k = 0
    for j in range (2, i):
        if i % j == 0:
            k += 1
    if k == 0:
        i2 = i + 2
        k2 = 0
        for n in range (2, i2):
            if i2 % n == 0:
                k2 += 1
        if k2 == 0:
            print(f"{i}, {i2}")