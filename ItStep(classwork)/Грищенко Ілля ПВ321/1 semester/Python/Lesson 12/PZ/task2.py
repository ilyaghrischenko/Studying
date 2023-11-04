x = int(input("Введіть розмір: "))

i = 0

for j in range (8):
    for b in range (4):
        if j % 2 != 0:
           print("*" * x, "-" * x, end='', sep='')
        elif j % 2 == 0:
            print("-" * x, "*" * x, end='', sep='')
    print("\n")