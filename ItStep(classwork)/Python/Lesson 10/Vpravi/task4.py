import random

y = random.randint(1, 501)
p = 0

while True:
    x = int(input("Введіть число: "))
    p += 1
    if x == y:
        print("Ви вгадали!")
        break
    elif x == 0:
        print("Число БІЛЬШЕ 0")
    else:
        if y > x:
            print("Загадане число БІЛЬШЕ")
        else:
            print("Загадане число МЕНШЕ")
print(f"Число було вгадане за {p} спроб")