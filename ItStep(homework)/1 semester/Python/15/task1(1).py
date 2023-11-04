#1
import random

x = []
y = []
my_list = []

for i in range(15):
    x.append(random.randint(-10, 10))
    y.append(random.randint(-10, 10))

print(f"Перший список - {x}\nДругий список - {y}\n")

my_list = x + y
print(f"1) Сформувати третій список, що містить елементи обох списків\n{my_list}")
print(f"Кількість елементів у списку: {len(my_list)}\n")