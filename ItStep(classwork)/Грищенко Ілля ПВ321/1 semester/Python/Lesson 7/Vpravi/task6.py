n = int(input("Введіть n: "))
m = int(input("Введіть m: "))
k = int(input("Введіть k: "))

if n * m - n == k or n * m - m == k or n // m == k or m // n == k:
    print("yes")
elif n * 2 == k or m * 2 == k or n == k or m == k or n // 2 == k or m // 2 == k:
    print("yes")
else:
    print("no")