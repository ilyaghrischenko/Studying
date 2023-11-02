x = int(input("Введіть число: "))

y = x

for i in range(1, 1001):
    if (((i // 2) // 3) // 4) == x:
        print(i, end=' ')