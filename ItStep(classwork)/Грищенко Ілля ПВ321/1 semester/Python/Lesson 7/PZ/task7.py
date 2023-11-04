x1 = int(input("Введіть 1 координату для коня: "))
y1 = int(input("Введіть 2 координату для коня: "))
x2 = int(input("Введіть 1 координату для клітинки: "))
y2 = int(input("Введіть 2 координату для клітинки: "))

if x1 > 8 or x2 > 8 or y1 > 8 or y2 > 8:
    print("Не існуючі координати")
elif x1 < 1 or x2 < 1 or y1 < 1 or y2 < 1:
    print("Не існуючі координати")

elif x1 + 2 == x2 and y1 + 1 == y2:
    print("Може")
elif x1 + 2 == x2 and y1 - 1 == y2:
    print("Може")
elif x1 - 2 == x2 and y1 + 1 == y2:
    print("Може")
elif x1 - 2 == x2 and y1 - 1 == y2:
    print("Може")
elif y1 + 2 == y2 and x1 + 1 == x2:
    print("Може")
elif y1 + 2 == y2 and x1 - 1 == x2:
    print("Може")
elif y1 - 2 == y2 and x1 + 1 == x2:
    print("Може")
elif y1 - 2 == y2 and x1 - 1 == x2:
    print("Може")
else:
    print("Не може")