x = int(input("Введіть 1 число: "))
y = int(input("Введіть 2 число: "))

suma_p = 0
suma_np = 0
suma_9 = 0

k1 = 0
k2 = 0
k3 = 0

for i in range (x, y + 1):
    if i % 2 == 0 and i % 9 == 0:
        suma_9 += i
        k3 += 1
        suma_p += i
        k1 += 1
    elif i % 2 != 0 and i % 9 == 0:
        suma_np += i
        k2 += 1
        suma_9 += i
        k3 += 1
    elif i % 9 == 0:
        suma_9 += i
        k3 += 1
    elif i % 2 == 0:
        suma_p += i
        k1 += 1
    elif i % 2 != 0:
        suma_np += i
        k2 += 1
print(f"\nСума парних чисел - {suma_p}\nЇх середньоарифметичне - {suma_p / k1}\n")
print(f"Сума непарних чисел - {suma_np}\nЇх середньоарифметичне - {suma_np / k2}\n")
if k3 > 0:
    print(f"Сума чисел, кратних 9 - {suma_9}\nЇх середньо арифметичне - {suma_9 / k3}\n")
else:
    print("Немає чисел, кратних 9")