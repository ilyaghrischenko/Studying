#2
import random

x = []
y = []
my_list = []

for i in range(15):
    x.append(random.randint(-10, 10))
    y.append(random.randint(-10, 10))

print(f"Перший список - {x}\nДругий список - {y}\n")

for i in range(len(x)):
    for j in range(len(y)):
        if i == 0:
            if x[i] != y[j] and y[j] not in my_list:
                my_list.append(y[j])
        else:
            if x[i] != y[j] and x[i] not in my_list:
                my_list.append(x[i])

print(f"2) Сформувати третій список, що містить елементи обох списків без пов­торів\n{my_list}")
print(f"Кількість елементів у списку: {len(my_list)}\n")