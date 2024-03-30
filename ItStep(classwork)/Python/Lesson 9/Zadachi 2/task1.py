n = int(input("Введіть кількість чисел: "))

s = 0

for i in range (1, n + 1):
    x = int(input(f"Введіть {i} число: "))
    s += x
print(s / n)   