x = input("Введіть адресу: ")
poshta = ""

for i in x:
    if i == '@':
        break
    else:
        poshta += i

print(poshta)