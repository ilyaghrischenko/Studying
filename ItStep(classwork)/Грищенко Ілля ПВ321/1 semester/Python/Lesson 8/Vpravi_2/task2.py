km = int(input("Введіть кількість км у 1ий день: "))
pr = int(input("Введіть відсоток: "))
days = int(input("Введіть кількість днів: "))

pr /= 100
total = 0
km_1 = km

for i in range (1, days + 1):
    n = km_1 * pr
    km_1 += n
    
    total += km_1
print(round(total, 2))