def line(x, y, z):
    if y == "v":
        for i in range(x):
            print(z)
    else:
        print(z * x)
        
x = int(input("Введіть довжину: "))
y = input("Введіть напрямок: ")
z = input("Введіть символ: ")

line(x, y, z)