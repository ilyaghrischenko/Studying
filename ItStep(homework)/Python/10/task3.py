kilk = 0

for i in range (100, 10000):
    x = i
    if 100 <= x < 1000:
        d = 100
    elif 1000 <= x < 10000:
        d = 1000
    x1 = x // d
    x2 = (x // (d // 10)) % 10
    if 100 <= x < 1000:
        x3 = x % 10
        if x1 != x2 and x1 != x3 and x2 != x3:
            kilk += 1
    elif 1000 <= x < 10000:
        x3 = (x // 10) % 10
        x4 = x % 10
        if x1 != x2 and x1 != x3 and x1 != x4 and x2 != x3 and x2 != x4 and x3 != x4:
            kilk += 1
print(f"Кількість чисел - {kilk}")