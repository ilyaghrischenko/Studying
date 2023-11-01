n = int(input("Введіть число: "))

for i in range (n):
    for j in range(n):
        if i == j:
            print("0", end='  ')
        elif i < j:
            print("1", end='  ')
        elif i > j:
            print("-1", end=' ')
    print()