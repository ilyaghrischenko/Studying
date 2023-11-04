def p(x):
    for i in range(1, x + 1):
        if i != 1 or i != x:
            if x % i == 0:
                return False
                break
    return True
    
print(p(2))