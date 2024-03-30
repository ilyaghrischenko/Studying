def gisto(x):
    for i in x:
        print("$" * i)
    
x = list(map(int, input("Введіть числа: ").split()))

gisto(x)