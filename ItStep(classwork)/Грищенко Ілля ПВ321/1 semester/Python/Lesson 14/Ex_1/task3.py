x = input("Введіть рядок: ")

y = ''

for i in x:
    if i == " ":
        break
    else:
        y += i
        
print(y)