x = input("Введіть рядок: ")

x1 = ''
for j in range(len(x)):
    if x[j] != " ":
        x1 += x[j]

y = ''
for i in range(len(x) - 1, -1, -1):
    if x[i] != ' ':    
        y += x[i]

if x1 == y:
    print(f"Рядок '{x}' паліндром")
else:
    print(f"Рядок '{x}' НЕ паліндром")