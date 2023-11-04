x = input("Введіть рядок: ")

y = ''

for i in x:
    if i.isdigit() == True:
        y += i
        
print(y)