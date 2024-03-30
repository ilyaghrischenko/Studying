x = int(input("Введіть довжину: "))
y = input("Введіть символ: ")
o = input("Введіть логічний тип(True, False): ")
if o == "True":
    o = True
elif o == "False":
    o = False

def rv(x, y, o):
    if o == False:
        for i in range(x):
            if i == 0 or i == (x - 1):
                print(f"{y} " * x)
            else:
                print(f"{y} ", "  " * (x - 3), f"{y} ")

    elif o == True:
        for i in range(x):
            if i == 0 or i == (x - 1):
                print(f"{y} " * x)
            else:
                print(f"{y} ", end='')
                for j in range(1, x - 1):
                    print(f"{y} ", end='')
                print(f"{y} ")

rv(x, y, o)