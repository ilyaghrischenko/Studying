x = input("Введіть слово: ")
for i in x:
    if i == "a" or i == "e" or i == "i" or i == "o" or i == "u":
        continue
    else:
        print(i)