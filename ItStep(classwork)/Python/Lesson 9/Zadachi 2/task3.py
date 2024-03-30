n = int(input("Введіть кількість чисел: "))

s = 1

for i in range (1, n + 1):
    x = int(input(f"Введіть {i} число: "))
    if x % 3 == 0:
        s *= x
print(s)