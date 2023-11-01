n = int(input("Введіть число: "))

k = 0

for i in range (2, n):
    if n % i == 0:
        k += 1
if k == 0:
    print("Число просте")
else:
    print("Складене")
        