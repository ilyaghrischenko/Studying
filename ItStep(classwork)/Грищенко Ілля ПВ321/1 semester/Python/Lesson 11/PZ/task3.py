x = int(input("Введіть сторону: "))

for j in range (x):
    for i in range (x):
        if j == 0 or j == x - 1 or i == 0 or i == x - 1:
            print("*", end=' ')
        else:
            print(" ", end=' ')
    print('\n')