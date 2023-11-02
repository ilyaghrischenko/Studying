x = list(map(int, input("Введіть числа: ").split()))

y = int(input("Введіть число: "))

for i in x:
    if i < y:
        print(i, end=' ')