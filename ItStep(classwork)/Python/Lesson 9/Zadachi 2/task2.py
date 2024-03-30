n = int(input("Введіть кількість чисел: "))

s = 0

for i in range (1, n + 1):
    x = int(input(f"Введіть {i} число: "))
    if x < 0:
        s += 1
print(s)