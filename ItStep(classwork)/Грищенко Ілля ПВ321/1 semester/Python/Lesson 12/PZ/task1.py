x = int(input("Введіть число: "))

y = x
suma = 0
k = 0

while x > 0:
    y = x % 10
    x //= 10
    k += 1
    suma += y
ar = suma / k
print(f"Кількість чисел: {k}\nСума чисел: {suma}\nСереднє арифметичне: {ar}")