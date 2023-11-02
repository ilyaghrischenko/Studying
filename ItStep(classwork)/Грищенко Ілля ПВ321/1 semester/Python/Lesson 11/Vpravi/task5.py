k = 0
x = 0
n = 1
while True:
    x = n
    n = int(input("Введіть число: "))
    
    if n == 0:
        print(f"\nКількість змін: {k}")
        break
    if n < 0 and x > 0:
        k += 1
    if n > 0 and x < 0:
        k += 1