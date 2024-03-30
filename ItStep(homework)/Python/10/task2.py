kilk = 0

for i in range (100, 1000):
    x = i
    x1 = x // 100
    x2 = x // 10 - x1 * 10
    x3 = x % 10
    if x1 == x2 or x1 == x3 or x2 == x3:
        kilk += 1
print(f"Кількість чисел {kilk}")