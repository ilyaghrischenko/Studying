x = list(map(int, input("Введіть числа: ").split()))

for i in range(1, len(x) + 1, 2):
    print(i, end=' ')