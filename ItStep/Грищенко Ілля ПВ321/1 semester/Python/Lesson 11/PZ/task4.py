x = int(input("Введіть довжину: "))
y = int(input("Введіть ширину: "))

for i in range (x):
    for j in range (y):
        if i == 0 or i == x - 1 or j == 0 or j == y - 1:
            print("*", end=' ')
        else:
            print(" ", end=' ')
    print("\n")
