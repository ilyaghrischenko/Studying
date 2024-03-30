i = 0
suma = 0
mx = 0
j = 1

while i != 7:
    x = int(input("Введіть число: "))
    if x == 7:
        i = 7
        print("Good bye!\n")
    elif j == 1:
        mn = x
        suma += x
    else:
        suma += x
        if x > mx:
            mx = x
        elif x < mn:
            mn = x
    j += 1
print(f"Сума всіх чисел - {suma}")
print(f"Максимальне число - {mx}")
print(f"Мінімальне число - {mn}")