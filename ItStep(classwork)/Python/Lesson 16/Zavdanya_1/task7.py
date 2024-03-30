import random

x = int(input("Введіть кількість елементів: "))
y = [random.randint(-10, 10) for i in range(x)]

sum = 0
for i in y:
    l = lambda x: sum + x
    sum = l(i)
print(y, "Сума:", sum)