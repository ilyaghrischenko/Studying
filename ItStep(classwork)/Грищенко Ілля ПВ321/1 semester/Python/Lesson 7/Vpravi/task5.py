x1 = int(input("Введіть число: "))
x2 = int(input("Введіть число: "))
x3 = int(input("Введіть число: "))

if x1 == x2 == x3:
    print("3")
elif x1 == x2 or x1 == x3 or x2 == x3:
    print("2")
elif x1 != x2 != x3:
    print("0")