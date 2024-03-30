x = input("Введіть текст: ")

while True:
    y = input("Введіть зарезервоване слово(0 для закінчення): ")
    if y in x:
        x = x.replace(y, y.upper())
    elif y == '0':
        break
    else:
        print("Такого слова немає в рядку")

print(x)