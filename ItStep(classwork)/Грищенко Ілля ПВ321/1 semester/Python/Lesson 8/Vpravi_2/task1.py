suma = int(input("Введіть суму: "))
pr = int(input("Введіть відсоток річних: "))
x = int(input("Введіть тривалість: "))

pr /= 100
total = suma

for i in range (1, x + 1):
    n = total * pr
    total += n
print(total)