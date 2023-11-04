x = int(input("Введіть початок: "))
y = int(input("Введіть кінець: "))

for i in range (x, y + 1):
    k = 0
    for j in range (x, y + 1):
        if i % j == 0:
            k += 1
    if k == 2:
        k += 1
print(f"Кількість простих чисел в діапазоні ({x}, {y}) = {k}")