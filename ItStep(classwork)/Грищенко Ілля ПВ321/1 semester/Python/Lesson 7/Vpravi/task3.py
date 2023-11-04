x1 = int(input("Введіть 1 координату: "))
y1 = int(input("Введіть 2 координату: "))

x2 = int(input("Введіть 1 координату: "))
y2 = int(input("Введіть 2 координату: "))

if x1 > 0 and y1 > 0:
    n1 = 1
elif x1 < 0 and y1 < 0:
    n1 = 3
elif x1 > 0 and y1 < 0:
    n1 = 4
elif x1 < 0 and y1 > 0:
    n1 = 2

if x2 > 0 and y2 > 0:
    n2 = 1
elif x2 < 0 and y2 < 0:
    n2 = 3
elif x2 > 0 and y2 < 0:
    n2 = 4
elif x2 < 0 and y2 > 0:
    n2 = 2
    
if n1 == n2:
    print("Так")
else:
    print("Ні")