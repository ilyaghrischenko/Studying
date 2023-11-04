n1 = int(input("Введіть ціле число: "))
n2 = int(input("Введіть ціле число: "))

if n1 % 2 != 0:
    n1 += 1

while n1 <= n2:
    print(n1)
    n1 += 2