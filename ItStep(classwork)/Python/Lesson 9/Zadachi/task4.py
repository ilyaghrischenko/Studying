x = int(input("Введіть ціле число: "))
i = 1

while i <= x:
    if x % i == 0:
        print(i, end=' ')
    i += 1