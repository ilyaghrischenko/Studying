n = int(input("Введіть число: "))

x = 0

for i in range (n):
    for j in range(i):
        print(i, end=' ')
        x += 1
        if x == n:
            break
    if x == n:
        break
            