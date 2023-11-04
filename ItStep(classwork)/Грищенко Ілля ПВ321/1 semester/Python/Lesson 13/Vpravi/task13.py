x = input("Введіть число: ")

for i in x:
    if i == x[0]:
        i = x[-1]
    elif i == x[-1]:
        i = x[0]
    print(i, end='')