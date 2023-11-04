n = int(input("Введіть суму: "))

b = n

k_1 = 0
k_2 = 0
k_4 = 0
k_8 = 0
k_16 = 0
k_32 = 0
k_64 = 0

while b != 0:
    if b >= 64:
        b -= 64
        k_64 += 1
    elif  32 <= b < 64:
        b -= 32
        k_32 += 1
    elif 16 <= b < 32:
        b -= 16
        k_16 += 1
    elif 8 <= b < 16:
        b -= 8
        k_8 += 1
    elif 4 <= b < 8:
        b -= 4
        k_4 += 1
    elif 2 <= b < 4:
        b -= 2
        k_2 += 1
    elif 1 <= b < 2:
        b -= 1
        k_1 += 1

if k_64 > 0:
    print(f"{k_64} - (64)")
if k_32 > 0:
    print(f"{k_32} - (32)")
if k_16 > 0:
    print(f"{k_16} - (16)")
if k_8 > 0:
    print(f"{k_8} - (8)")
if k_4 > 0:
    print(f"{k_4} - (4)")
if k_2 > 0:
    print(f"{k_2} - (2)")
if k_1 > 0:
    print(f"{k_1} - (1)")