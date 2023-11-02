x = int(input("Введіть кількість: "))

suma1 = 0

for j in range(1, x + 1):
    suma1 += j

suma2 = 0

for i in range(1, x):
    y = int(input(f"Введіть {i} число: "))
    suma2 += y

k = suma1 - suma2
 
print(f"Загублене число: {k}")