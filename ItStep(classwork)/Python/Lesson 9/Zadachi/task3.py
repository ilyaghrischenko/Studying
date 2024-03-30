x = int(input("Введіть число: "))

suma = 0
i = 1

while i < x:
    if i % 2 == 0:
        suma += i
    i += 1

print(suma)