def n(x, y):
    if len(x) > len(y):
        print(x)
    elif len(x) == len(y):
        print(x, y, sep='\n')
    else:
        print(y)
        
x = input("Введіть 1 рядок: ")
y = input("Введіть 2 рядок: ")

n(x, y)