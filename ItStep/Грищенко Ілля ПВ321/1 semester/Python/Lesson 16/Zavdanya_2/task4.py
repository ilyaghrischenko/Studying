import random

x = [random.randint(-10,10) for i in range(20)]
print(x)

suma = 0
b = 0

def s(x, start = 0):
    if start + 5 > len(x): return 0
    min_s = sum(x[start:start+5])
    min_p = start
    next_p = s(x, start + 1)
    if next_p is not 0:
        next_sum = sum(x[next_p:next_p+5])
        if next_sum < min_s:
            min_x = next_sum
            min_p = next_p
    return min_p

print(s(x))