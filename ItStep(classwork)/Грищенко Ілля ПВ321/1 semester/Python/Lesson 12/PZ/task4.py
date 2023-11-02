x = int(input("Введіть максимальну ширину: "))

if x % 2 == 0:
    x += 1

k = 1

for i in range(1, x//2 + 1):
    prom = (x - k) // 2
    print(" " * prom, "*" * k, end='\n')
    k += 2
for j in range(x//2 + 1, 0, -1):
    prom = (x - k) // 2
    print(" " * prom, "*" * k, end='\n')
    k -= 2