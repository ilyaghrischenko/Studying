i = 0

grn_e = float(input("Введіть курс євро: "))
grn_d = float(input("Введіть курс долара: "))

money = 0

while i != -1:
    v_1 = int(input("Введіть валюту обміну (1 - грн, 2 - євро, 3 - долар): "))
    v_2 = int(input("Введіть валюту для отримання (1 - грн, 2 - євро, 3 - долар): "))
    suma = int(input("Введіть суму: "))
    if v_1 == -1 or v_2 == -1 or suma == -1:
        break
    if v_1 == 1 and v_2 == 2:
        y = round(suma / grn_e, 3)
        print(f"Ви отримаєте {y}")
    if v_1 == 1 and v_2 == 3:
        y = round(suma / grn_d, 3)
        print(f"Ви отримаєте {y}")
    if v_1 == 2 and v_2 == 1:
        y = round(suma * grn_e, 3)
        print(f"Ви отримаєте {y}")
    if v_1 == 2 and v_2 == 3:
        y = round(suma * grn_e / grn_d, 3)
        print(f"Ви отримаєте {y}")
    if v_1 == 3 and v_2 == 1:
        y = round(suma * grn_d, 3)
        print(f"Ви отримаєте {y}")
    if v_1 == 3 and v_2 == 2:
        y = round(suma * grn_d / grn_e, 3)
        print(f"Ви отримаєте {y}")