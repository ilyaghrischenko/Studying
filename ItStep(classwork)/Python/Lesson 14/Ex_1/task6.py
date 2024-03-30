x = input("Введіть рядок цифр: ")

y = ''

for i in x:
    if int(i) > 5:
        if (int(i) // 2) % 2 != 0:
            y += str(int(i) // 2)
    else:
        y += i
                
print(y)

# 1