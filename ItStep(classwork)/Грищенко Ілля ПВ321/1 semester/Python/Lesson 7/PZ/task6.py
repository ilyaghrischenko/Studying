import math

x1 = int(input("Введіть 1 координату для ферзя: "))
y1 = int(input("Введіть 2 координату для ферзя: "))
x2 = int(input("Введіть 1 координату для клітинки: "))
y2 = int(input("Введіть 2 координату для клітинки: "))

if x1 > 8 or x2 > 8 or y1 > 8 or y2 > 8:
    print("Не існуючі координати")
elif x1 == x2 or y1 == y2:
    print("Може")
elif abs(x1 - x2) == abs(y1 - y2):
    print("Може")
else:
    print("Не може")