a = int(input("Введіть трохьзначне число: "))

a1 = a // 100
a2 = a // 10 - a1 * 10
a3 = a % 10

s = a1 * a2 * a3

if s >= 100:
    print("Так")
else:
    print("Ні")