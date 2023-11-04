x = input("Введіть послідовність цифр: ")
x_1 = ''

for i in x:
    if i == "0":
        i = "x"
        x_1 += i
    else:
        x_1 += i

print(x_1)