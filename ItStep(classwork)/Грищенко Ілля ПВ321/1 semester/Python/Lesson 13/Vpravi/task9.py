x = input("Введіть рядок: ")
y = input("Введіть шуканий символ: ")

for i in range(len(x)):
    if x[i] == y:
        print(i + 1)
        break