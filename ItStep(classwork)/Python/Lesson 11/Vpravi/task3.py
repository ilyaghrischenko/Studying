n = int(input("Введіть число: "))

x = 0
y = 1
i = 0

while i < n:
    i = x + y
    x = y
    y = i
    print(x, end=' ')