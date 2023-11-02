n = input("Введіть свій дохід: ")
dohid = float(n)

if dohid <= 85528 and dohid > 0:
    podatok = dohid * 0.18 - 556.2
elif dohid > 85528:
    podatok = 14839.2 + ((dohid - 85528) * 0.32)
elif dohid < 0:
    podatok = 0
podatok_1 = float(round(podatok))
    
print(f"Сума вашого податку = {podatok_1} талера")