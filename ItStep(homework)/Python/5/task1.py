a = int(input("Введіть 1 число: "))
b = int(input("Введіть 2 число: "))
c = int(input("Введіть 3 число: "))

x = int(input("1 - сума чисел\n2 - добуток чисел\n"))

if x == 1:
    print(f"{a} + {b} + {c} = {a + b + c}")
elif x == 2:
    print(f"{a} * {b} * {c} = {a * b * c}")