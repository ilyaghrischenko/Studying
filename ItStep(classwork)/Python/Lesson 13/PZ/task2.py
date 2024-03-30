x = input("Введіть рядок: ")

c = 0
b = 0

for i in x:
    if i.isdigit() == True:
        c += 1
    elif i.isalpha() == True:
        b += 1

print(f"Кількість цифр: {c}")
print(f"Кількість букв: {b}")