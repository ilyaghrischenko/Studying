a = int(input("Введіть а: "))
b = int(input("Введіть b: "))
c = int(input("Введіть с: "))

if c**2 == a**2 + b**2:
    s = 0.5 * a * b
    print(f"Трикутник прямокутний, площа = {s}")
elif a**2 == c**2 + b**2:
    s = 0.5 * c * b
    print(f"Трикутник прямокутний, площа = {s}")
elif b**2 == a**2 + c**2:
    s = 0.5 * a * c
    print(f"Трикутник прямокутний, площа = {s}")
else:
    print("Трикутник не прямокутний")