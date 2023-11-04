suma = int(input("Введіть суму: "))
pr = int(input("Введіть відсоток: "))
sumaN = int(input("Введіть бажану суму: "))

pr /= 100
k = 0

while suma <= sumaN:
    suma = suma + suma * pr
    k += 1        
print(k)