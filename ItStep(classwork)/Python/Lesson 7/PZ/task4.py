x = int(input("Введіть номер місяця (1-12): "))

if x == 1 or x == 2 or x == 12:
    print("Winter")
elif 3 <= x <= 5:
    print("Spring")
elif 6 <= x <= 8:
    print("Summer")
elif 9 <= x <= 11:
    print("Autumn")
else:
    print("Такого місяця не існує!")