a = int(input("Введіть сторону а: "))
b = int(input("Введіть сторону b: "))
c = int(input("Введіть сторону с: "))

if a == b or b == c or a == c:
    print("Yes")
else:
    print("No")