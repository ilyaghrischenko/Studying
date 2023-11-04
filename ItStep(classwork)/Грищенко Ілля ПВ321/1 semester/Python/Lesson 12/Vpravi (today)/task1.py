n = int(input("Введіть n: "))
m = int(input("Введіть m: "))

for i in range(n + 1):
    for j in range(1, m + 1):
        print(i, end='  ')
    print()