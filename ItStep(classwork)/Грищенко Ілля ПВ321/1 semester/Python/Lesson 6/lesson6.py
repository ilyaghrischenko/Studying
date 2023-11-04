a = int(input("Введіть сторону а: "))
b = int(input("Введіть сторону b: "))
c = int(input("Введіть сторону c: "))

if a + b > c and b + a > a and c + a > b:
    print("Yes")
else:
    print("No")