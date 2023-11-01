a = int(input("Введіть A: "))
b = int(input("Введіть B: "))

while a != b:
    if a % 2 == 0 and a >= b * 2:
        a //= 2
        print(":2")
    else:
        a -= 1
        print("-1")
print(f"A = B = {b}")