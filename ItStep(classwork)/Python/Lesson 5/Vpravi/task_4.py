x = int(input("Введіть рік: "))

if x < 1582:
    print(f"{x}р Не в межах григоріанського календарного періоду")
elif x % 4 != 0:
    print("Звичайний рік")
elif x % 100 != 0:
    print("Високосний рік")
elif x % 400 != 0:
    print("Звичайний рік")
else:
    print("Високосний рік")