a = int(input("Введіть трохьзначне число: "))

a1 = a // 100
a2 = a // 10 - a1 * 10
a3 = a % 10

if (a1 == a2 and a2 != a3) or (a1 == a2 and a1 != a3) or (a2 == a3 and a2 != a1) or (a2 == a3 and a3 != a1) or (a1 == a3 and a1 != a2) or (a1 == a3 and a3 != a2):
    print("Yes")
else:
    print("No") 