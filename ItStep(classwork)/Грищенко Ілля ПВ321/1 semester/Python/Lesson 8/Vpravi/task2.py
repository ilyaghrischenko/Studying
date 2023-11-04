x = int(input("Введіть число: "))
suma = 0
n = 1
for i in range (1, x + 1):
    suma += n
    n += 2
print(suma)