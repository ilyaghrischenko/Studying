x = int(input("Введіть число: "))

m = 1

for i in range (2, x + 1):
    k = 0
    for j in range (1, i + 1):
        if i % j == 0:
            k += 1
    if k == 2:
        k += 1
        if j > m:
            m = j
print(m)