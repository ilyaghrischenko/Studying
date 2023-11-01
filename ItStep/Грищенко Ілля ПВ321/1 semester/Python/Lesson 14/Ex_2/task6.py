x = list(map(int, input("Введіть числа: ").split()))

for i in range(len(x), 0, -1):
    print(i, end=' ')