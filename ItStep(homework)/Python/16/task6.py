def kilk(x):
    k = 0
    for i in x:
        if i.isdigit() == True:
            k += 1
    return k
        
x = input("Введіть число: ")

print(f"Кількість цифр у числі {x} =", kilk(x))