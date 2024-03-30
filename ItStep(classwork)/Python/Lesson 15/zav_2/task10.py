def s(x, y):
    syma = 0
    if x > y:
        x, y = y, x
    for i in range(x, y + 1):
        syma += i
    print(syma)

s(1, 2)