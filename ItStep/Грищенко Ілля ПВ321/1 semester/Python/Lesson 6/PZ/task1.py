sec = int(input("Введіть час у секундах: "))
vs_sec = 24 * 60 * 60

zal = vs_sec - sec

x = int(input("Введіть 1 для годин, 2 для хвилин, 3 для секунд: "))

if x == 1:
    hours = zal // 3600
    hv = zal % 3600 // 60
    s = zal % 60
    print(f"До опівночі залишилося {hours} год {hv} хв {s} сек")
elif x == 2:
    hv = zal // 60
    s = zal % 60
    print(f"До опівночі залишилося {hv} хв {s} сек")
elif x == 3:
    print(f"До опівночі залишилося {zal} сек")