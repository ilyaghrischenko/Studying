x = int(input("Введіть число: "))

i = 2

while x != 1:
    if x % i == 0:
        x /= i
        print(i)
    else:
        i += 1