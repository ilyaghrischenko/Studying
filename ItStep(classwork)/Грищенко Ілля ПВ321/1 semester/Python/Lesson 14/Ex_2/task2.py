x = list(map(int, input("Введіть числа: ").split()))

y = []

for i in range(-2, len(x) - 2):
    y.append(x[i])

print(y)