vart = float(input("Введіть вартість палива: "))
rash = float(input("Введіть расход на 100км: "))
vids = float(input("Введіть відстань(в км): "))
total = (vids * (rash / 100)) * vart
print("Загальна вартість =", total)