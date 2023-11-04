def rek(x, y):
    if y == 0: return 1
    elif y == 1: return x
    else:
        d = rek(x, y - 1) * x
        return d
    
print(rek(2, 3))