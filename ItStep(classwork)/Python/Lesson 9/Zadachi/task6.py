x = int(input("Введіть ціле число: "))

i = 1
k = 0

while i <= x:
    if x % i == 0:
        k += 1
    i += 1
print(k)