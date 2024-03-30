n = int(input("Введіть n: "))

for j in range(1, n + 1):
    x = j
    for i in range(1, n - j + 2):
        print(x, end='   ')
        x += 1
    print()