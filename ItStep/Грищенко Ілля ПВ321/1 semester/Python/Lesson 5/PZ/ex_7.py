s_kva = int(input("Введіть площу квадрата: "))
s_kol = int(input("Введіть площу кола: "))

if s_kva < s_kol:
    print("Коло НЕ поміститься у квадраті")
elif s_kva > s_kol:
    print("Коло поміститься у квадраті")