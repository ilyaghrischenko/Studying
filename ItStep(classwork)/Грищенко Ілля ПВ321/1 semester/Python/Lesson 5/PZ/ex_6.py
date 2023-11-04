s_kva = int(input("Введіть площу квадрата: "))
s_kol = int(input("Введіть площу кола: "))

pi = 3.14

diag = (2 * s_kva) ** 0.5
diam = 2 * ((s_kva / pi) ** 0.5)

if diam >= diag:
    print("Квадрат поміститься у коло")
else:
    print("Квадрат НЕ поміститься у коло")