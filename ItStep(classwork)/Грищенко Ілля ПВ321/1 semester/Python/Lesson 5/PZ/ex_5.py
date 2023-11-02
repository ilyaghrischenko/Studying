x = int(input("Перше число: "))
y = int(input("Друге число: "))
c = input("Введіть математичну операцію('+', '-', '*', '/', '?'): ")

if c == "+":
    print(x + y)
elif c == "-":
    print(x - y)
elif c == "*":
    print(x * y)
elif c == "/":
    print(x / y)
elif c == "?":
    print((x + y) / 2)