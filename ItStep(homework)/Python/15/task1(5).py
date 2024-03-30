#5
import random

x = []
y = []
my_list = []

for i in range(15):
    x.append(random.randint(-10, 10))
    y.append(random.randint(-10, 10))

print(f"Перший список - {x}\nДругий список - {y}\n")

for i in range(2):
    if i == 0:
        i = x
    else:
        i = y
    my_list.append(max(i))
    my_list.append(min(i))

print(f"5) Сформувати третій список, що містить тільки мінімальне та максимальне значення кожного зі списків\n{my_list}")
print(f"Кількість елементів у списку: {len(my_list)}\n")