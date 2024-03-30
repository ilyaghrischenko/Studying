x = input("Введіть ціле число: ")

for i in x:
    if i == "3" or i == "6":
        i = ''
    else:
        print(int(i), end='')