x = input("Введіть текст: ")
k = 0

for i in range(len(x)):
    if x[i] == '.' or x [i] == '!' or x[i] == '?':
        k += 1

print(f"Кількість речень: {k}")